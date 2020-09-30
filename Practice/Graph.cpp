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

    Graph(const vector<pair<size_t, vector<size_t>>> neighbours) {
      this->neighbours = neighbours;
    }

    void enter_neighbours();
    void build_matrix();
    void print_matrix();
    void print_neighbours();
    void run_through_graph(size_t);

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

    cout << "Enter a neighbours for " << i << " row: ";  getline(cin, line);
    
    if (line.size()) {
      stringstream ss(line);

      while (ss >> line) splitted_line.push_back(stoi(line));
      
      pair<size_t, vector<size_t>> pair(i, splitted_line);
      this->neighbours.push_back(pair);
    } else {
      pair<size_t, vector<size_t>> pair(i, {});
      this->neighbours.push_back(pair);
    }
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
    // Current row<int> : neighbours<vector>
    pair<size_t, vector<size_t>> current_pair(this->neighbours[i].first, this->neighbours[i].second);
    size_t pair_index = 0;

    if (current_pair.second.size()) {
      for (size_t j = 0; j < length; j++) {
        if (current_pair.second[pair_index] == j) {
          
          this->matrix[i][j] = 1;
          pair_index++;
        } else {
          this->matrix[i][j] = 0;
        }
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
    cout << "Neighbours in " << pair.first << " row: ";
    for (auto value : pair.second) {
      cout << value << ' ';
    } cout << endl;
  }
}

void Graph::run_through_graph(size_t current_vortex = 0) {
  vector<size_t> current_row = this->neighbours[current_vortex].second;
  const size_t length = current_row.size();

  if (length) {
    for (size_t i = 0; i < length; i++) {
      this->run_through_graph(current_row[i]);
    }
  } else {
    for (auto x : current_row) {
      cout << x << ' ';
    }
  }
}

// -------------------------------         MAIN         -------------------------------
int main() {
  const vector<pair<size_t, vector<size_t>>> neighbours = {
    {pair<size_t, vector<size_t>>(0, {1,2})},
    {pair<size_t, vector<size_t>>(1, {3,4,5})},
    {pair<size_t, vector<size_t>>(2, {6,7,8})},
    {pair<size_t, vector<size_t>>(3, {})},
    {pair<size_t, vector<size_t>>(4, {})},
    {pair<size_t, vector<size_t>>(5, {})},
    {pair<size_t, vector<size_t>>(6, {9,10})},
    {pair<size_t, vector<size_t>>(7, {})},
    {pair<size_t, vector<size_t>>(8, {11,13})},
    {pair<size_t, vector<size_t>>(9, {})},
    {pair<size_t, vector<size_t>>(10, {})},
    {pair<size_t, vector<size_t>>(11, {})},
    {pair<size_t, vector<size_t>>(12, {})},
  };

  Graph my_graph(neighbours);

  // Graph my_graph;

  my_graph.print_neighbours();
  // my_graph.build_matrix();
  // my_graph.print_matrix();

  my_graph.run_through_graph();

  return 0;
}

