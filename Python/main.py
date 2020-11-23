import requests
from bs4 import BeautifulSoup
import xlsxwriter
import datetime
import matplotlib.pyplot as plt

URL = 'https://pogoda1.ru/katalog/sverdlovsk-oblast/temperatura-vody/'  # Main site url
COLLECTED_INFO = {}                                                     # Dict {date: (temp, place)}
AVERAGE_TEMPERATURES = {}                                               # Dict {date: average_temperature}


# Create a list of current month dates
def make_dates_list(from_day=0):
  m = datetime.datetime.now().month
  y = datetime.datetime.now().year
  dates = (datetime.date(y, m + 1, 1) - datetime.date(y, m, 1)).days
  d1 = datetime.date(y, m, 1) if not from_day else datetime.date(y, m, from_day)
  d2 = datetime.date(y, m, dates)
  delta = d2 - d1

  return [(d1 + datetime.timedelta(days=i)).strftime('%d-%m-%Y') for i in range(delta.days + 1)]


# Get the site as a text
def get_today_html(date):
  return requests.get(URL + date + '/').text


# Write all information into excel table
def make_excel(information):
  workbook = xlsxwriter.Workbook('table.xlsx')  # Open to editing existing table
  worksheet = workbook.add_worksheet('Table')  # Create a new working sheet
  cell_format = workbook.add_format({'fg_color': '#bfbfbf'})  # Some styles
  worksheet.write(0, 0, 'Date', cell_format)  # Fill the header Date
  worksheet.write(0, 1, 'Place', cell_format)  # Fill the header Place
  worksheet.write(0, 2, 'Temperature', cell_format)  # Fill the header Temperature
  worksheet.set_column(1, 2, 15)  # Set width to 15 of first and second columns
  row, m_average = 1, []
  global AVERAGE_TEMPERATURES

  for date in information:
    average = []
    worksheet.write(row, 0, date)

    for temp, place in information[date]:
      worksheet.write(row, 1, place)
      worksheet.write(row, 2, temp)
      average.append(float(temp))
      m_average.append(float(temp))
      row += 1

    average_result = round(sum(average) / len(average), 3)
    AVERAGE_TEMPERATURES.update({int(date[:2]): average_result})
    worksheet.write(row - 1, 3, average_result, workbook.add_format({'fg_color': '#c4d79b'}))

  worksheet.write(row + 1, 3, round(sum(m_average) / len(m_average), 3), workbook.add_format({'fg_color': '#da9694'}))
  workbook.close()


# Graph of average temperatures from start of the month to the current day
def draw_graph():
  days = [day for day in AVERAGE_TEMPERATURES]        # Days
  temperatures = list(AVERAGE_TEMPERATURES.values())  # Temperatures

  plt.plot(days, temperatures)
  plt.show()


# Will take info for the specific day
def parse_it(date):
  html = get_today_html(date)
  soup = BeautifulSoup(html, 'lxml')

  # Structure 'x-table' -> 'x-row' -> temperature in 'x-cell x-cell-water-temp' and place in 'link'
  table = soup.find_all('div', class_='x-row')  # The main table contains all the information

  return [
    (row.find('div', class_='x-cell-water-temp').text.strip(),
     row.find(lambda t: t.name == 'div' and t.get('class') == ['x-cell']).find('a').text)
    for row in table
  ]


# Main [\0_0/]
def main():
  global COLLECTED_INFO
  COLLECTED_INFO = {date: parse_it(date) for date in make_dates_list()}

  make_excel(COLLECTED_INFO)
  draw_graph()


if __name__ == '__main__':
  main()
