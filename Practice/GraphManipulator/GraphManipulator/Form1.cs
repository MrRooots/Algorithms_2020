﻿a {
  "a": "a"",
}


using System;
 using System.Collections;
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
    
    // The matrix of the Graph
    private List<List<int>> _matrix = new List<List<int>>();
    
    // The neighbours list of the Graph Unweighted
    private readonly List<List<int>> _neighboursUnweighted = new List<List<int>>();
    
    // The Graph object
    private Graph myGraph;
    
    // Count of nodes for Weighted Graph
    private int countWeighted;
    
    // The neighbours list of the Graph Weighted
    private readonly List<List<int>> _neighboursWeighted = new List<List<int>>();
    
    // Pair structure for the weighted graph 
    struct Pair<T1, T2> {
      public Pair(T1 first, T2 second) {
        this.first = first;
        this.second = second;
      }
      
      public T1 First() { return this.first; }

      public T2 Second() { return this.second; }
      
      private T1 first;
      private T2 second;

    }
    
    // Special Pair structure
    struct PriorityPair<T1, T2, T3> {
      public PriorityPair(T1 first, T2 second, T3 third) {
        this.first = first;
        this.second = second;
        this.third = third;
      }
      
      public T1 First() { return this.first; }

      public T2 Second() { return this.second; }
      
      public T3 Third() { return this.third; }
      
      private T1 first;
      private T2 second;
      private T3 third;
    }

    // The Form initialization point
    public Form1() {
      InitializeComponent();
      this.unweightedGraphPanel.Hide();
      this.weightedGraphPanel.Hide();
    }
    
    // The Class that contains control for the Weighted Graph
    private class Graph {
      public Graph(int count) {
        this._vertexes = new List<List<Pair<int, int>>>();

        for (var i = 0; i < count+1; i++) {
          _vertexes.Add(new List<Pair<int, int>>());
        }
      }
      
      // Create the special array of vertexes and distance between
      public void AddEdge(int @from, int to, int weight) {
        this._vertexes[@from].Add(new Pair<int, int>(to, weight));
        this._vertexes[to].Add(new Pair<int, int>(@from, weight));
      }

      public List<List<Pair<int, int>>> GetVertexes() {
        return this._vertexes;
      }
      
      private readonly List<List<Pair<int, int>>> _vertexes;
    }
    
    
    /* --------------------------- MAIN FUNCTIONS --------------------------- */
    
    // This function will print the shortest ways from the startPoint to all others points of Graph with their weight
    private void CalculateShortestWay(int startPoint) {
      // for (var i = 0; i < myGraph.GetVertexes().Count; i++) {
      //   this.pairPrint.Text += myGraph.GetVertexes()[i].First().ToString() + "    " + myGraph.GetVertexes()[i].Second().ToString() + Environment.NewLine;
      // }
      
      startPoint -= 1;
      // Make the list of pairs sorted by the pair.first() element
      // var sortedVertexes = myGraph.GetVertexes().OrderBy(o => o.First()).ToList();
      var queue = new List<Pair<int, int>>();
      // Print the first elements of pairs
      // for (var i = 0; i < myGraph.GetVertexes().Count; i++) {
      //   this.pairPrint.Text += sortedVertexes[i].First() + @" " + sortedVertexes[i].Second() + @" | ";
      //   this.pairPrint.Text += Environment.NewLine;
      // }
      
	    var dist = new List<int>();
      for (var i = 0; i < countWeighted; i++) {
        dist.Add(Int32.MinValue);
      }

	    queue.Add(new Pair<int, int>(0, startPoint));
      // queue = queue.OrderBy(o => o.First()).ToList();
	    dist[startPoint] = 0; 

	    while (queue.Count != 0) { 
        var secondElement = queue[0].Second();
        queue.RemoveAt(0);
      } 
      
      this.pairPrint.Text += @"Vertex |Distance from Source: " + startPoint + Environment.NewLine;

      for (var i = 0; i < dist.Count; ++i) {
        this.pairPrint.Text += i + @"      |" + dist[i] + Environment.NewLine;
      }
    }

    // Convert the string into List of integers
    private static List<int> LineToNumbers(string line) {
      return line.Split(' ').Select(value => Convert.ToInt32(value)).ToList();
    }
    
    // Will build matrix from the list of neighbours
    private List<List<int>> BuildMatrix() {
      var length = _neighboursUnweighted.Count;   // The size of the matrix
      
      // Fill the matrix by zeroes
      for (var i = 0; i < length; i++) {
        _matrix.Add(new List<int>());
        
        for (var j = 0; j < length; j++) {
          _matrix[i].Add(0);  
        }
      }
      
      // Fill the result matrix
      for (var i = 0; i < length; i++) {
        var currentPair = _neighboursUnweighted[i];    // The second element of the pair is List<int>
        var pairLength = currentPair.Count;            // The length of the current pair
        var pairIndex = 0;
        
        if (pairLength > 0) {
          for (var j = 0; j < length; j++) {
            if (pairIndex < pairLength && currentPair[pairIndex] == j+1) {
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
      var length = _neighboursUnweighted.Count;
      var visited = new List<bool>();
      
      for (var i = 0; i < length + 1; i++) {
        visited.Add(false);
      }

      DeepFirstSearch(0, visited);    // DFS
      
      visited.Clear();
      for (var i = 0; i < length + 1; i++) {
        visited.Add(false);
      }
      
      BreadthFirstSearch(0, visited);  // BFS
    }
    
    // Will run through the Graph using the neighbours list {recursively} -> DFS
    private void DeepFirstSearch(int index, IList<bool> visited) {
      visited[index] = true;
      this.GraphOutputDFS.Text += (index + 1).ToString() + ' ';

      if (_neighboursUnweighted[index].Count > 0) {
        for (var i = 0; i < _neighboursUnweighted[index].Count; i++) {
          var value = _neighboursUnweighted[index][i] - 1;

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

        var pair = _neighboursUnweighted[value];

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

      for (var i = 0; i < _neighboursUnweighted.Count; i++) { newNeighbours.Add(new List<int>()); }
      
      for (var i = 0; i < _neighboursUnweighted.Count; i++) {
        for (var j = 0; j < _neighboursUnweighted[i].Count; j++) {
          AddToNewNeighbours(newNeighbours, i, _neighboursUnweighted[i][j] - 1);
        }
      }

      return newNeighbours;
    }
    
    // Modified BFS for shortest way search
    private bool ModifiedBreadthFirstSearch(int from, int to, IList<int> pred) {
      var queue = new List<int>();              // The queue array
      var visited = new List<bool>();           // The visited\unvisited array
      var newNeighbours = RebuildNeighbours();  
      
      from -= 1;
      to -= 1;
      
      for (var i = 0; i < _neighboursUnweighted.Count; i++) {
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
    private static Label CreateLabel(int i, string name="", string text="", bool isPanel3=false) {
      var font = new Font("Arial", 14, FontStyle.Regular);
      var label = new Label {
        AutoSize = true,
        Name = "vortexNumber" + i.ToString(),
        Font = font,
        Location = new Point(10, 150 + i * 50),
        Text = Convert.ToString(i + 1),
        TextAlign = ContentAlignment.MiddleCenter
      };

      return label;
    }
    
    // Will create an input labels for the neighbours for each vertex
    private static List<TextBox> CreateTextBox(int i, string name="", int height=20, int width=150, bool isPanel3=false) {
      var distanceInput = new TextBox();
      var neighboursInput = new TextBox {
        Name = "neighboursInputBox" + Convert.ToString(i),
        Height = 20,
        Width = 150,
        Font = new Font("Arial", 14, FontStyle.Regular),
        Location = new Point(50, 150 + i * 50),
        TextAlign = HorizontalAlignment.Left
      };
      
      // Check the Weighted Graph
      if (isPanel3) {
        distanceInput.Name = "distanceInputBox" + Convert.ToString(i);
        distanceInput.Height = 20;
        distanceInput.Width = 150;
        distanceInput.Font = new Font("Arial", 14, FontStyle.Regular);
        distanceInput.Location = new Point(50 + neighboursInput.Width + 10, 150 + i * 50);
        distanceInput.TextAlign = HorizontalAlignment.Left;
        
        return new List<TextBox>(){neighboursInput, distanceInput};
      }
      else {
        return new List<TextBox>() {neighboursInput};
      }
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
    
    /* --------------------------- UNWEIGHTED GRAPH --------------------------- */
    // Entering th count of vertexes
    private void submitVertexCount_Click(object sender, EventArgs e) {
      var count = Convert.ToInt32(countInput.Text);
      
      // Will create 'count' of label+input pairs
      for (var i = 0; i < count; i++) {
        this.unweightedGraphPanel.Controls.Add(CreateLabel(i));
        this.unweightedGraphPanel.Controls.Add(CreateTextBox(i)[0]);
      }
    }
    
    // Entering the connected vertexes
    private void submitVertexCoord_Click(object sender, EventArgs e) {
      var count = Convert.ToInt32(countInput.Text);
      const string namePrefix = "neighboursInputBox";

      // Create List of pairs: rowNumber==vortex - neighbours
      for (var i = 0; i < count; i++) {
        var inputBoxName = namePrefix + Convert.ToString(i);
        var labelText = this.unweightedGraphPanel.Controls[inputBoxName].Text.Trim(' ');

        _neighboursUnweighted.Add(labelText != ""
          ? new List<int>(LineToNumbers(labelText))
          : new List<int>(new List<int>()));
      }

      _matrix = BuildMatrix();  // The matrix of the Graph

      BuildMatrixGridView(_matrix);
    }
  
    // Will recursively run through graph and output them into special label
    private void runThroughGraph_Click(object sender, EventArgs e) {
      RunThroughGraph();  // Start run!!!
    }
    
    // Will print the shortest way from {from} vertex to {to} vertex
    private void calculateWay_Click(object sender, EventArgs e) {
      GetTheShortestWay(Convert.ToInt32(this.inputFromLabel.Text), Convert.ToInt32(this.inputToLabel.Text));
    }
    
    // Will print some of the current variables state into special box {debug function}
    private void getDebugInfo_Click(object sender, EventArgs e) {
      var i = 0;
      
      foreach (var neighbours in _neighboursUnweighted) {
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

    // Display the control panel for Unweighted Graph
    private void unweightedGraphControl_Click(object sender, EventArgs e) {
      this.weightedGraphPanel.Hide();
      this.unweightedGraphPanel.Show();
      
      this.weightedGraphControl.BackColor = Color.LightGray;
      this.unweightedGraphControl.BackColor = Color.DimGray;
    }
    
    
    /* --------------------------- WEIGHTED GRAPH --------------------------- */
    // Display the control panel for Weighted Graph
    private void weightedGraphControl_Click(object sender, EventArgs e) {
      this.unweightedGraphPanel.Hide();
      this.weightedGraphPanel.Show();
      
      this.unweightedGraphControl.BackColor = Color.LightGray;
      this.weightedGraphControl.BackColor = Color.DimGray;
    }
    
    // Submit vertex count for weighted graph
    private void submitVertexCount_1_Click(object sender, EventArgs e) {
      var count = Convert.ToInt32(countInput_1.Text);
      
      // Will create 'count' of label+input pairs
      for (var i = 0; i < count; i++) {
        var input = CreateTextBox(i, isPanel3: true);
        
        this.weightedGraphPanel.Controls.Add(CreateLabel(i, isPanel3:true));
        this.weightedGraphPanel.Controls.Add(input[0]);
        this.weightedGraphPanel.Controls.Add(input[1]);
      }
    }
    
    // Submit the neighbours and weights
    private void submitNeighbours_1_Click(object sender, EventArgs e) {
      const string neighboursBoxPrefix = "neighboursInputBox";
      const string distanceBoxPrefix = "distanceInputBox";
      
      countWeighted = Convert.ToInt32(countInput_1.Text);
      myGraph = new Graph(countWeighted);  // Create a structure Graph with some functions

      // Create List of pairs: rowNumber==vortex - neighbours
      for (var i = 0; i < countWeighted; i++) {
        var distanceBoxName = distanceBoxPrefix + i;
        var inputBoxName = neighboursBoxPrefix + i;
        var neighboursText = this.weightedGraphPanel.Controls[inputBoxName].Text.Trim(' ');
        var distanceText = this.weightedGraphPanel.Controls[distanceBoxName].Text.Trim(' ');
        
        // 1: neighbours 2 8 | distance 4 8
        if (neighboursText != "") {
          var neighboursList = LineToNumbers(neighboursText);
          var distanceList = LineToNumbers(distanceText);

          for (var j = 0; j < neighboursList.Count; j++) {
            // Create the Graph Edges array
            var to = neighboursList[j] - 1;
            var weight = distanceList[j];
            myGraph.AddEdge(i, to, weight);
          }
        }
      }
    }

    private void button2_Click(object sender, EventArgs e) {
      CalculateShortestWay(Convert.ToInt32(this.startPointEnetr.Text));
    }
  }
}