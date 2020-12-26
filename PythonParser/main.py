import requests
import re
import time
import datetime
import calendar
import xlsxwriter
from bs4 import BeautifulSoup
import matplotlib.pyplot as plt
import multiprocessing

URL = 'https://pogoda1.ru/katalog/sverdlovsk-oblast/temperatura-vody/'  # Main site url
COLLECTED_INFO = {}                                                     # Dict {date: (temp, place)}
AVERAGE_TEMPERATURES = {}                                               # Dict {date: average_temperature}


# Simple decorator to measure time of the function execution
def measure(func):
  def wrapper():
    start = time.time()
    func()
    print(f'Time of the "{func.__name__}" execution is: {time.time() - start}')

  return wrapper


# Create a list of current month dates
def make_dates_list(from_day=1) -> list:
  year = datetime.datetime.now().year
  month = datetime.datetime.now().month

  return [str(datetime.date(year, month, day).strftime('%d-%m-%Y')) for day in range(from_day, calendar.monthrange(year, month)[1] + 1)]


# Get the site as a text
def get_today_html(date) -> str:
  return requests.get(URL + date + '/').text


# Write all information into excel table
def make_excel() -> None:
  workbook = xlsxwriter.Workbook('table.xlsx')                # Open to editing existing table
  worksheet = workbook.add_worksheet('Table')                 # Create a new working sheet
  cell_format = workbook.add_format({'fg_color': '#bfbfbf'})  # Some styles

  worksheet.write(0, 0, 'Date',        cell_format)           # Fill the header Date
  worksheet.write(0, 1, 'Place',       cell_format)           # Fill the header Place
  worksheet.write(0, 2, 'Temperature', cell_format)           # Fill the header Temperature

  worksheet.set_column(1, 2, 15)                              # Set width to 15 of first and second columns

  row, global_average = 1, []
  global AVERAGE_TEMPERATURES

  for date in COLLECTED_INFO:
    average = []
    worksheet.write(row, 0, date)

    for temp, place in COLLECTED_INFO[date]:
      worksheet.write(row, 1, place)
      worksheet.write(row, 2, temp)

      average.append(float(temp))
      global_average.append(float(temp))

      row += 1

    average_result = round(sum(average) / len(average), 3)
    AVERAGE_TEMPERATURES.update({int(date[:2]): average_result})
    worksheet.write(row - 1, 3, average_result, workbook.add_format({'fg_color': '#c4d79b'}))

  cell_format = workbook.add_format({'fg_color': '#da9694'})
  global_average_result = round(sum(global_average) / len(global_average), 3)
  worksheet.write(row + 1, 3, global_average_result, cell_format)
  workbook.close()


# Graph of average temperatures from start of the month to the current day
def draw_graph() -> None:
  days = [day for day in AVERAGE_TEMPERATURES]        # Days
  temperatures = list(AVERAGE_TEMPERATURES.values())  # Temperatures

  plt.plot(days, temperatures)
  plt.show()


# Will take info for the specific day
def parse_it(date) -> None:
  soup = BeautifulSoup(get_today_html(date), 'lxml')

  # Structure 'x-table' -> 'x-row' -> temperature in 'x-cell x-cell-water-temp' and place in 'link'
  table = soup.find_all('div', class_='x-row')  # The main table contains all the information

  # print(temperatures)
  # global COLLECTED_INFO
  # COLLECTED_INFO.update({date: temperatures})
  temperatures = [
    (row.find('div', class_='x-cell-water-temp').text.strip(),
     row.find(lambda t: t.name == 'div' and t.get('class') == ['x-cell']).find('a').text)
    for row in table
  ]

  # Array of tuples (less size + protected)
  with open('today.txt', 'a') as file:
    file.write(date + ': ')
    for temp in temperatures:
      file.write(temp[0] + ' ' + temp[1] + ', ')

    file.write('\n')


# Collect all information about temperatures (Run all at the same time (xDAY_COUNT speed up!!!) -> write to file)
def collect_info() -> None:
  open('today.txt', 'w').close()  # Clear the file from previous operations

  with multiprocessing.Pool(multiprocessing.cpu_count()) as p:
    p.map(parse_it, make_dates_list())


# Parse file and sort the info by date
def format_collected_info():
  temp_info = {}

  with open('today.txt', 'r') as file:
    for line in file:
      line = re.split(': |, ', line.strip())
      temp_info.update({line[0]: tuple([i.split(' ', 1) for i in line[1:]])})

  global COLLECTED_INFO
  for key in sorted(temp_info.keys()):
    COLLECTED_INFO.update({key: temp_info[key]})


# Main [\0_0/]
@measure
def main() -> None:
  collect_info()                  # Collect all information about temperatures
  format_collected_info()
  make_excel()                  # Build excel file from the collected info
  draw_graph()                  # Draw the graph from the collected info


# Script enter point
if __name__ == '__main__':
  main()
