﻿﻿﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
   using System.Drawing.Printing;
   using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Weighted_Graph_GUI {
  public partial class Form1 : Form {
    // -------------------------------------------- GLOBAL VARIABLES ------------------------------------------ \\
    // Count of vertexes in UNWEIGHTED Graph
    private int _unweightedVertexesCount;
    private int _weightedVertexCount;

    // Special list of neighbours for Unweighted Graph
    private readonly List<List<int>> _neighboursUnweighted = new List<List<int>>();

    // Special matrix of weights between vertexes for Weighted Graph
    private List<List<int>> _neighboursWeightedMatrix = new List<List<int>>();

    // Form initialization
    public Form1() {
      InitializeComponent();
      unweightedGraphPanel.Hide();
      weightedGraphPanel.Hide();
      // Unweighted Panel Exception Labels
      unweightedGraphPanel.Controls["acceptedLabel"].Visible = false;
      unweightedGraphPanel.Controls["countException"].Visible = false;
      unweightedGraphPanel.Controls["submitException"].Visible = false;
      unweightedGraphPanel.Controls["calculateException"].Visible = false;
      // Weighted Panel Exception Labels
      weightedGraphPanel.Controls["weightedInputException"].Visible = false;
      // weightedGraphPanel.Controls["weightedNeighboursException"].Visible = false;
    }

    // Pair<> class
    private class Pair<T1, T2> {
      public Pair(T1 first, T2 second) {
        First = first;
        Second = second;
      }

      public T1 First { get; set; }
      public T2 Second { get; set; }
    }

    // -------------------------------------------- MAIN FUNCTIONS ------------------------------------------- \\
    // Create List of integers from string {will be x-1 foreach x in line}
    private static List<int> LineToArray(string line) {
      return line.Trim(' ').Split(' ').Select(number => Convert.ToInt32(number) - 1).ToList();
    }

    // Will run through Graph via BFS and DFS
    private void RunThroughGraph() {
      var length = _neighboursUnweighted.Count;
      var visited = new List<bool>();
      outputBfs.Text = @"BFS Output: ";
      outputDfs.Text = @"DFS Output: ";

      for (var i = 0; i < length + 1; i++) {
        visited.Add(false);
      } // Create the visiting list

      DeepFirstSearch(0, visited); // DFS

      for (var i = 0; i < length + 1; i++) {
        visited[i] = false;
      } // Clear the list for the BFS

      BreadthFirstSearch(0, visited); // BFS
    }

    // BFS Realisation
    private void BreadthFirstSearch(int index, IList<bool> visited) {
      visited[index] = true;
      var queue = new List<int> {index};

      while (queue.Count != 0) {
        var value = queue[0];
        outputBfs.Text += (value + 1).ToString() + ' ';
        queue.RemoveAt(0);

        var pair = _neighboursUnweighted[value];

        foreach (var x in pair.Where(x => !visited[x])) {
          visited[x] = true;
          queue.Add(x);
        }
      }
    }

    // DFS realisation
    private void DeepFirstSearch(int index, IList<bool> visited) {
      visited[index] = true;
      outputDfs.Text += (index + 1).ToString() + ' ';

      if (_neighboursUnweighted[index].Count <= 0) return;
      for (var i = 0; i < _neighboursUnweighted[index].Count; i++) {
        var value = _neighboursUnweighted[index][i];

        if (!visited[value]) {
          DeepFirstSearch(value, visited);
        }
      }
    }

    // Rebuild the current neighbours list for the shortest way calculation
    private static void AddToNewNeighbours(IReadOnlyList<List<int>> newNeighbours, int from, int to) {
      newNeighbours[from].Add(to);
      newNeighbours[to].Add(from);
    }

    // Will rebuild _neighbours array for the Shortest Path Search
    private List<List<int>> RebuildNeighbours() {
      var newNeighbours = new List<List<int>>();

      for (var i = 0; i < _neighboursUnweighted.Count; i++) {
        newNeighbours.Add(new List<int>());
      }

      for (var i = 0; i < _neighboursUnweighted.Count; i++) {
        for (var j = 0; j < _neighboursUnweighted[i].Count; j++) {
          AddToNewNeighbours(newNeighbours, i, _neighboursUnweighted[i][j]);
        }
      }

      return newNeighbours;
    }

    // Modified BFS for shortest way search
    private bool ModifiedBreadthFirstSearch(int sourcePoint, int destinationPoint, IList<int> pred) {
      var queue = new List<int>(); // The queue array
      var visited = new List<bool>(); // The visited\unvisited array
      var newNeighbours = RebuildNeighbours();

      for (var i = 0; i < _neighboursUnweighted.Count; i++) {
        visited.Add(false);
        pred.Add(-1);
      }

      visited[sourcePoint] = true;
      queue.Add(sourcePoint);

      while (queue.Count != 0) {
        var index = queue[0];
        queue.RemoveAt(0);

        for (var i = 0; i < newNeighbours[index].Count; i++) {
          var tempIndex = newNeighbours[index][i];

          if (visited[tempIndex]) continue;
          visited[tempIndex] = true;
          pred[tempIndex] = index;
          queue.Add(tempIndex);

          if (tempIndex == destinationPoint) {
            return true;
          }
        }
      }

      return false;
    }

    // Will print the shortest way in unweighted Graph
    private void GetTheShortestWay(int sourcePoint, int destinationPoint) {
      var pred = new List<int>(); // Predecessor[i] array stores predecessor of i 
      outputShortestWay.Text = @"The shortest way is: ";

      if (ModifiedBreadthFirstSearch(sourcePoint, destinationPoint, pred)) {
        var path = new List<int>() {destinationPoint}; // Path array stores the shortest path
        var element = destinationPoint;

        while (pred[element] != -1) {
          path.Add(pred[element]);
          element = pred[element];
        }

        path.Reverse();

        foreach (var step in path) {
          outputShortestWay.Text += (step + 1).ToString() + ' ';
        }

        outputShortestWay.Text += @"(Way length: " + path.Count + ')';
      }
      else {
        outputShortestWay.Text += @"The entered points does not connected!";
      }
    }

    // -------------------------------------------- OBJECT CREATORS ------------------------------------------- \\
    private static Label CreateLabel(int i, bool forWeight = false) {
      string text, name;
      int height;

      // Spaces check
      if (i < 9) {
        text = (i + 1).ToString() + ' ';
      }
      else {
        text = (i + 1).ToString();
      }

      // Name corrections
      if (!forWeight) {
        name = "neighboursFor" + i;
        height = 125;
      }
      else {
        name = "weightedNeighboursFor" + i;
        height = 160;
      }

      // Label initialization
      var label = new Label {
        Name = name, // Name of the label
        Location = new Point(x: 3, y: height + i * 50),
        Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point),
        Text = text,
        Width = 35,
        ForeColor = Color.FromArgb(240, 240, 240)
      };

      return label;
    }

    // Will create an input box
    private static Tuple<TextBox, TextBox> CreateInput(int i, bool forWeight = false) {
      if (forWeight) {
        var inputFirst = new TextBox() {
          Name = "weightedNeighboursInput" + i,
          Location = new Point(x: 40, y: 160 + i * 50),
          Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point),
          Width = 100,
          BackColor = Color.FromArgb(240, 240, 240)
        };

        var inputSecond = new TextBox() {
          Name = "weightedLengthInput" + i,
          Location = new Point(x: 150, y: 160 + i * 50),
          Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point),
          Width = 100,
          BackColor = Color.FromArgb(240, 240, 240)
        };

        return new Tuple<TextBox, TextBox>(inputFirst, inputSecond);
      }
      else {
        var input = new TextBox() {
          Name = "neighboursInput" + i,
          Location = new Point(x: 40, y: 125 + i * 50),
          Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point),
          Width = 100,
          BackColor = Color.FromArgb(240, 240, 240)
        };

        return new Tuple<TextBox, TextBox>(input, input);
      }
    }

    // -------------------------------------------- EVENT HANDLERS -------------------------------------------- \\

    // Open the Unweighted Graph Control Panel via button click
    private void unweightedGraphButton_Click(object sender, EventArgs e) {
      unweightedGraphPanel.Show();
      weightedGraphPanel.Hide();
    }

    // Submit the count of vertexes and create the input boxes for neighbours of each vertex
    private void submitVertexCountButton_Click(object sender, EventArgs e) {
      var flag = true;

      foreach (var dummy in vertexCountInput.Text.Where(char.IsLetter)) {
        flag = false;
      }

      if (flag) {
        countException.Visible = false;
        _unweightedVertexesCount = Convert.ToInt32(vertexCountInput.Text); // Assign the count of vertexes

        for (var i = 0; i < _unweightedVertexesCount; i++) {
          unweightedGraphPanel.Controls.Add(CreateLabel(i)); // Add a new label for vertex number
          unweightedGraphPanel.Controls.Add(CreateInput(i).Item1); // Add a new input box for vertex neighbours
        }
      }
      else {
        countException.Visible = true;
      }
    }

    // Take the neighbours and build the _neighboursUnweighted list
    private void submitNeighboursButton_Click(object sender, EventArgs e) {
      const string namePrefix = "neighboursInput";

      // Create List of pairs: rowNumber==vortex - neighbours
      for (var i = 0; i < _unweightedVertexesCount; i++) {
        var inputBoxName = namePrefix + i;
        var labelText = unweightedGraphPanel.Controls[inputBoxName].Text;

        // Append the line of neighbours to the list
        _neighboursUnweighted.Add(labelText != ""
          ? new List<int>(LineToArray(labelText))
          : new List<int>(new List<int>()));
      }

      unweightedGraphPanel.Controls["acceptedLabel"].Visible = true;
    }

    // Activate BFS and DFS methods and print the results
    private void runThroughGraphButton_Click(object sender, EventArgs e) {
      RunThroughGraph();
    }

    // Calculate the shortest way from sourcePoint to destinationPoint  
    private void calculateButton_Click(object sender, EventArgs e) {
      var flag = true;

      foreach (var dummy in from.Text.Where(char.IsLetter)) {
        flag = false;
      }

      foreach (var dummy in to.Text.Where(char.IsLetter)) {
        flag = false;
      }

      if (flag) {
        calculateException.Visible = false;
        var sourcePoint = Convert.ToInt32(from.Text);
        var destinationPoint = Convert.ToInt32(to.Text);

        GetTheShortestWay(--sourcePoint, --destinationPoint);
      }
      else {
        calculateException.Visible = true;
      }
    }

    // Open the Weighted Graph Control Panel via button click
    private void weightedGraphButton_Click(object sender, EventArgs e) {
      unweightedGraphPanel.Hide();
      weightedGraphPanel.Show();
      neighboursTable.Visible = false;
      weightTable.Visible = false;
    }

    // Submit the count of vertexes and create the input boxes for neighbours and weight of each vertex
    private void weightedCountSubmitButton_Click(object sender, EventArgs e) {
      var flag = true;

      foreach (var dummy in weightedCountInput.Text.Where(char.IsLetter)) { flag = false; }

      if (flag) {
        weightedInputException.Visible = false;
        _weightedVertexCount = Convert.ToInt32(weightedCountInput.Text); // Assign the count of vertexes

        // Create labels and input boxes for each vertex
        for (var i = 0; i < _weightedVertexCount; i++) {
          weightedGraphPanel.Controls.Add(CreateLabel(i, true)); // Create and add label to the current panel
          weightedGraphPanel.Controls.Add(CreateInput(i, true).Item1); // Create input for neighbours
          weightedGraphPanel.Controls.Add(CreateInput(i, true).Item2); // Create special input for weight 
        }
        
        // Input Table Headers
        neighboursTable.Visible = true;
        weightTable.Visible = true;
      }
      else {
        weightedInputException.Visible = true;
      }
    }

    // Build Matrix of weights between Graph vertexes
    private List<List<int>> BuildWeightMatrix(IReadOnlyList<string> input) {
      var inputPairs = new List<Pair<List<int>, List<int>>>();
      var matrix = new List<List<int>>();

      // Fill the matrix via 0
      for (var i = 0; i < _weightedVertexCount; i++) {
        matrix.Add(new List<int>());
        for (var j = 0; j < _weightedVertexCount; j++) {
          matrix[i].Add(0);
        }
      }

      for (var i = 0; i < _weightedVertexCount; i++) {
        inputPairs.Add(new Pair<List<int>, List<int>>(new List<int>(), new List<int>()));
      }

      for (var i = 0; i < _weightedVertexCount; i++) {
        var pair = input[i].Split('|');

        if (pair[0] != "") {
          inputPairs[i] = new Pair<List<int>, List<int>>(LineToArray(pair[0]), LineToArray(pair[1]));
        }
      }

      for (var i = 0; i < _weightedVertexCount; i++) {
        for (var j = 0; j < inputPairs[i].First.Count; j++) {
          matrix[i][inputPairs[i].First[j]] = inputPairs[i].Second[j] + 1;
          matrix[inputPairs[i].First[j]][i] = inputPairs[i].Second[j] + 1;
        }
      }

      return matrix;
    }

    // Collect all data from inputs about neighbours and weight
    private void weightedNeighboursSubmitButton_Click(object sender, EventArgs e) {
      const string nPrefix = "weightedNeighboursInput";
      const string wPrefix = "weightedLengthInput";
      var input = new List<string>();

      // Get the user input in special format
      for (var i = 0; i < _weightedVertexCount; i++) {
        input.Add(
          weightedGraphPanel.Controls[nPrefix + i].Text
          + '|'
          + weightedGraphPanel.Controls[wPrefix + i].Text
        );
      }

      _neighboursWeightedMatrix = BuildWeightMatrix(input); // Create the matrix of weights

      DijkstraAlgorithm(_neighboursWeightedMatrix);
    }

    // An utility function to find the vertex with minimum distance value
    private int GetMinDistance(IReadOnlyList<int> distance, IReadOnlyList<bool> isInTree) {
      int min = int.MaxValue, minIndex = 0;

      for (var i = 0; i < _weightedVertexCount; i++) {
        if (!isInTree[i] && distance[i] <= min) {
          min = distance[i]; 
          minIndex = i; 
        }
      }

      return minIndex;
    }

    private void DijkstraAlgorithm(IReadOnlyList<List<int>> matrix, int source=0) {
      var distance = new List<int>();   // The output array.  dist[i] will hold the shortest distance from src to i
      var isInTree = new List<bool>();  // sptSet[i] will be true if vertex i is included in shortest path tree or shortest distance from src to i is finalized 

      // Initialize all distances as INFINITE and stpSet[] as false 
      for (var i = 0; i < _weightedVertexCount; i++) { distance.Add(int.MaxValue); isInTree.Add(false); }

      distance[source] = 0;        // Distance of source vertex from itself is always 0 

      // Find shortest path for all vertices 
      for (var i = 0; i < _weightedVertexCount - 1; i++) {
        var min = GetMinDistance(distance, isInTree);
        
        isInTree[min] = true;  // Mark the picked vertex as processed

        // Update dist value of the adjacent vertices of the picked vertex. 
        for (var j = 0; j < _weightedVertexCount; j++) {
          if (!isInTree[j] && matrix[min][j] != 0 && distance[min] != int.MaxValue && distance[min] + matrix[min][j] < distance[j]) {
            distance[j] = distance[min] + matrix[min][j];
          }
        }
      }
      
      PrettyPrint(distance);
    }
    
    private void PrettyPrint(IReadOnlyList<int> distance) {
      // Vertex        Distance From Source
      waysWeightOutput.Text += Environment.NewLine;
      
      for (var i = 0; i < _weightedVertexCount; i++) {
        waysWeightOutput.Text += i + @"                 |" + distance[i] + Environment.NewLine;
      }
    } 
  }
}