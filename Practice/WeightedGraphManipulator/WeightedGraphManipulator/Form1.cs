using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightedGraphManipulator {
  public partial class Form1 : Form {
    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace GraphManipulator {
  public partial class Form1 : Form {
    /* --------------------------- GLOBAL VARIABLES AND STRUCTURES --------------------------- */
    const int INFINITY = int.MaxValue;

    // The matrix of the Graph
    private List<List<int>> _matrix = new List<List<int>>();

    // The neighbours list of the Graph
    private readonly List<List<int>> _neighbours = new List<List<int>>();

    // The Edge structure
    struct Edge {
      private int startPoint, endPoint, weight;

      public Edge(int startPoint, int endPoint, int weight) {
        this.startPoint = startPoint;
        this.endPoint = endPoint;
        this.weight = weight;
      }

      public int getWeight() {
        return this.weight;
      }
    }

    // The Form initialization point
    public Form1() {
      InitializeComponent();
    }


    /* --------------------------- MAIN FUNCTIONS --------------------------- */

    // Convert the string into List of integers
    private static List<int> LineToNumbers(string line) {
      return line.Split(' ').Select(value => Convert.ToInt32(value)).ToList();
    }

    // Will build matrix from the list of neighbours
    private List<List<int>> BuildMatrix() {
      var length = _neighbours.Count; // The size of the matrix

      // Fill the matrix by zeroes
      for (var i = 0; i < length; i++) {
        _matrix.Add(new List<int>());

        for (var j = 0; j < length; j++) {
          _matrix[i].Add(0);
        }
      }

      // Fill the result matrix
      for (var i = 0; i < length; i++) {
        var currentPair = _neighbours[i]; // The second element of the pair is List<int>
        var pairLength = currentPair.Count; // The length of the current pair
        var pairIndex = 0;

        if (pairLength > 0) {
          for (var j = 0; j < length; j++) {
            if (pairIndex < pairLength && currentPair[pairIndex] == j + 1) {
              _matrix[i][j] = 1;
              pairIndex++;
            }
          }
        }
      }

      return _matrix;
    }

    // Will create a visiting list for the Graph vertexes and launch the DFS search method
    private void RunThroughGraph() {
      var length = _neighbours.Count;
      var visited = new List<bool>();

      for (var i = 0; i < length + 1; i++) {
        visited.Add(false);
      }

      DeepFirstSearch(0, visited); // DFS

      visited.Clear();
      for (var i = 0; i < length + 1; i++) {
        visited.Add(false);
      }

      BreadthFirstSearch(0, visited); // BFS
    }

    // Will run through the Graph using the neighbours list {recursively} -> DFS
    private void DeepFirstSearch(int index, IList<bool> visited) {
      visited[index] = true;
      this.GraphOutputDFS.Text += (index + 1).ToString() + ' ';

      if (_neighbours[index].Count > 0) {
        for (var i = 0; i < _neighbours[index].Count; i++) {
          var value = _neighbours[index][i] - 1;

          if (!visited[value]) {
            DeepFirstSearch(value, visited);
          }
        }
      }
    }

    // Will run through the Graph using the neighbours list {recursively} -> BFS
    private void BreadthFirstSearch(int index, IList<bool> visited) {
      visited[index] = true;
      var queue = new List<int> {index};

      while (queue.Count != 0) {
        var value = queue[0];
        this.GraphOutputBFS.Text += (value + 1).ToString() + ' ';
        queue.RemoveAt(0);

        var pair = _neighbours[value];

        foreach (var x in pair.Where(x => !visited[x - 1])) {
          visited[x - 1] = true;
          queue.Add(x - 1);
        }
      }
    }

    // Will rebuild the current neighbours list
    private static void AddToNewNeighbours(List<List<int>> newNeighbours, int from, int to) {
      newNeighbours[from].Add(to);
      newNeighbours[to].Add(from);
    }

    // Will rebuild _neighbours array for the Shortest Path Search
    private List<List<int>> RebuildNeighbours() {
      var newNeighbours = new List<List<int>>();

      for (var i = 0; i < _neighbours.Count; i++) {
        newNeighbours.Add(new List<int>());
      }
      
      for (var i = 0; i < _neighbours.Count; i++) {
        for (var j = 0; j < _neighbours[i].Count; j++) {
          AddToNewNeighbours(newNeighbours, i, _neighbours[i][j] - 1);
        }
      }

      return newNeighbours;
    }
    
    // Modified BFS for shortest way search
    private bool ModifiedBreadthFirstSearch(int from, int to, IList<int> pred) {
      var queue = new List<int>();     // The queue array
      var visited = new List<bool>();  // The visited\unvisited array
      var newNeighbours = RebuildNeighbours();
      
      from -= 1;
      to -= 1;
      
      for (var i = 0; i < _neighbours.Count; i++) {
        visited.Add(false);
        pred.Add(-1);
      }

      visited[from] = true;
      queue.Add(from);

      while (queue.Count != 0) {
        var index = queue[0];
        queue.RemoveAt(0);

        for (var i = 0; i < newNeighbours[index].Count; i++) {
          var tempIndex = newNeighbours[index][i];

          if (!visited[tempIndex]) {
            visited[tempIndex] = true;
            pred[tempIndex] = index;
            queue.Add(tempIndex);

            if (tempIndex == to) { return true; }
          }
        }
      }

      return false;
    }

    // Will print the shortest way in unweighted Graph
    private void GetTheShortestWay(int from, int to) {
      var pred = new List<int>();              // Predecessor[i] array stores predecessor of i 
      this.graphOutputWay.Text = @"The shortest way is: ";
      
      if (ModifiedBreadthFirstSearch(from, to, pred)) {
        var path = new List<int>() {to - 1};   // Path array stores the shortest path
        var element = to - 1;
      
        while (pred[element] != -1) {
          path.Add(pred[element]);
          element = pred[element];
        }
      
        path.Reverse();
      
        foreach (var step in path) {
          this.graphOutputWay.Text += (step + 1).ToString() + ' ';
        }

        this.graphOutputWay.Text += @"(Way length: " + path.Count.ToString() + ')';
      }
      else {
        this.graphOutputWay.Text += @"The entered points does not connected!";
      }
    }
    
    
    /* --------------------------- FORM PARTS BUILDERS --------------------------- */
    
    // Will create a text label with the vortex number
    private static Label CreateLabel(int i, string name="", string text="") {
      var label = new Label {
        AutoSize = true,
        Name = "vortexNumber" + i.ToString(),
        Font = new Font("Arial", 14, FontStyle.Regular),
        Location = new Point(10, 150 + i * 50),
        Text = Convert.ToString(i + 1),
        TextAlign = ContentAlignment.MiddleCenter
      };
      
      return label;
    }
    
    // Will create an input labels for the neighbours for each vertex
    private static TextBox CreateTextBox(int i, string name="", int height=20, int width=150) {
      var textBox = new TextBox {
        Name = "neighboursInputBox" + Convert.ToString(i),
        Height = 20,
        Width = 150,
        Font = new Font("Arial", 14, FontStyle.Regular),
        Location = new Point(50, 150 + i * 50),
        TextAlign = HorizontalAlignment.Left
      };

      return textBox;
    }
    
    // Will fill the DataGridView with matrix
    private void BuildMatrixGridView(IReadOnlyList<List<int>> inputMatrix) {
      var length = inputMatrix.Count;

      matrixView.RowCount = length;
      matrixView.ColumnCount = length;
      
      // Fill the headers of the grid
      for (var i = 0; i < length; i++) {
        var header = (i + 1).ToString();
        matrixView.Columns[i].HeaderText = header;
        matrixView.Rows[i].HeaderCell.Value = header;
      }
      
      for (var i = 0; i < length; i++) {
        for (var j = 0; j < length; j++) {
          if (matrixView != null) {
            matrixView.Rows[i].Cells[j].Value = inputMatrix[i][j].ToString();
          }
        }
      }
    }
    
    
    /* --------------------------- EVENT HANDLERS --------------------------- */
    
    // Entering the count of vertexes
    private void submitVertexCountButton_Click(object sender, EventArgs e) {
      var count = Convert.ToInt32(countInput.Text);
      
      // Will create 'count' of label+input pairs
      for (var i = 0; i < count; i++) {
        this.Controls.Add(CreateLabel(i));
        this.Controls.Add(CreateTextBox(i));
      }
    }
    
    // Entering the connected vertexes
    private void submitVertexCoordButton_Click(object sender, EventArgs e) {
      var count = Convert.ToInt32(countInput.Text);
      const string namePrefix = "neighboursInputBox";

      // Create List of pairs: rowNumber==vortex - neighbours
      for (var i = 0; i < count; i++) {
        var inputBoxName = namePrefix + Convert.ToString(i);
        var labelText = this.Controls[inputBoxName].Text.Trim(' ');

        _neighbours.Add(labelText != ""
          ? new List<int>(LineToNumbers(labelText))
          : new List<int>(new List<int>()));
      }

      _matrix = BuildMatrix();  // The matrix of the Graph

      BuildMatrixGridView(_matrix);
    }
  
    // Will recursively run through graph and output them into special label
    private void runThroughGraphButton_Click(object sender, EventArgs e) {
      RunThroughGraph();  // Start run!!!
    }
    
    // Will print the shortest way from {from} vertex to {to} vertex
    private void calculateWay_Click(object sender, EventArgs e) {
      GetTheShortestWay(Convert.ToInt32(this.inputFromLabel.Text), Convert.ToInt32(this.inputToLabel.Text));
    }
    
    // Will print some of the current variables state into special box {debug function}
    private void getDebugInfo_Click(object sender, EventArgs e) {
      var i = 0;

      foreach (var neighbours in _neighbours) {
        if (i < 9) {
          this.debugOutput.Text += ++i + @"  | ";
        }
        else {
          this.debugOutput.Text += ++i + @" | ";
        }

        foreach (var neighbour in neighbours) {
          this.debugOutput.Text += (neighbour).ToString() + ' ';
        }

        this.debugOutput.AppendText(Environment.NewLine);
      }
    }
    
    // Another function stack for WEIGHTED GRAPH
    private void submitVertexWeightGraph_Click(object sender, EventArgs e) {
      var count = Convert.ToInt32(countInput.Text);
      
      // Will create 'count' of label+input pairs
      for (var i = 0; i < count; i++) {
        this.Controls.Add(CreateLabel(i));
        this.Controls.Add(CreateTextBox(i));
      }
    }
  }
}
  }
}