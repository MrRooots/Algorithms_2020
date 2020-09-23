#include <iostream>
#include <string>  
#include <vector>
#include <sstream>
using namespace std;


// -------------------------------        CLASS         -------------------------------
class Graph {
  public:
    Graph() {
      this->enter_neighbours();
    }

    void enter_neighbours();
    void build_matrix();
    void print_matrix();
    void print_neighbours();

  private:
    vector<pair<size_t, vector<size_t>>> neighbours;
    vector<vector<size_t>> matrix;
};


// ------------------------------- FUNCTIONS DEFINITION -------------------------------
void Graph::enter_neighbours() {
    string row_count;
    
    cout << "Enter a count of rows: "; getline(cin, row_count);
    
    const size_t length = stoi(row_count);

    for (size_t i = 0; i < length; i++) {
      string line; vector<size_t> splitted_line;

      cout << "Enter a neighbours for " << i+1 << " row: ";  getline(cin, line);
      stringstream ss(line);

      while (ss >> line) splitted_line.push_back(stoi(line));
      
      pair<size_t, vector<size_t>> pair(i, splitted_line);

      this->neighbours.push_back(pair);
    }
}

void Graph::build_matrix () {
  const size_t length = this->neighbours.size();
  
  // Filling the result by 0
  for (size_t i = 0; i < length; i++) {
    vector<size_t> temp = {};
    for (size_t l = 0; l < length; l++) temp.push_back(0);
    
    this->matrix.push_back(temp);
  }
  
  for (size_t i = 0; i < length; i++) {
    pair<size_t, vector<size_t>> current_pair(this->neighbours[i].first, this->neighbours[i].second);  // Current row<int> : neighbours<vector>
    size_t pair_index = 0;

    for (size_t j = 0; j < length; j++) {
      if (current_pair.second[pair_index] == j+1) {
        this->matrix[i][j] = 1;
        pair_index++;
      } else {
        this->matrix[i][j] = 0;
      }
    }
  }
}

void Graph::print_matrix() {
  cout << endl << "The Matrix Is:" << endl;
  for (auto row : this->matrix) {
    for (auto value : row) {
      cout << value << ' ';
    } cout << endl;
  }
}

void Graph::print_neighbours() {
  cout << endl << "The Neighbours Is:" << endl;

  for (auto pair : this->neighbours) {
    cout << "Neighbours in " << pair.first + 1 << " row: ";
    for (auto value : pair.second) {
      cout << value << ' ';
    } cout << endl;
  }
}


// -------------------------------         MAIN         -------------------------------
int main() {
  Graph my_graph;

  my_graph.print_neighbours();
  my_graph.build_matrix();
  my_graph.print_matrix();

  return 0;
}

