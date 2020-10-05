﻿using System;
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

namespace GraphManipulator {
  public partial class Form1 : Form {
    /* --------------------------- GLOBAL VARIABLES AND STRUCTURES --------------------------- */
    
    // The matrix of the Graph
    private List<List<int>> _matrix = new List<List<int>>();
    
    // The neighbours list of the Graph
    private readonly List<Pair<int, List<int>>> _neighbours = new List<Pair<int, List<int>>>();
    
    // The Simple Pair structure
    private struct Pair<T, T1> {
      private T _firstElement;
      private T1 _secondElement;

      public Pair(T first, T1 second) {
        this._firstElement = first;
        this._secondElement = second;
      }
      
      public T First() {return this._firstElement;}
      public T1 Second() { return this._secondElement; }
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
      var length = _neighbours.Count;   // The size of the matrix
      
      // Fill the matrix by zeroes
      for (int i = 0; i < length; i++) {
        _matrix.Add(new List<int>());
        
        for (int j = 0; j < length; j++) {
          _matrix[i].Add(0);  
        }
      }
      
      // Fill the result matrix
      for (var i = 0; i < length; i++) {
        var currentPair = _neighbours[i].Second();  // The second element of the pair is List<int>
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
  
    // Will rebuild the _neighbours variable into another view
    private List<List<int>> RebuildNeighbours() {
      var result = new List<List<int>>();
      var length = _neighbours.Count;

      for (var i = 0; i < length; i++) {
        result.Add(new List<int>());
        
        foreach (var value in _neighbours[i].Second()) {
          result[i].Add(value);
        }
      }

      return result;
    }
    
    // Will run through the Graph using the neighbours list {recursively}
    private void DeepThroughGraph(int index, List<bool> visited, List<List<int>> neighbours) {
      visited[index] = true;
      this.GraphOutput.Text += (index + 1).ToString() + ' ';

      if (neighbours[index].Count > 0) {
        for (var i = 0; i < neighbours[index].Count; i++) {
          var value = neighbours[index][i] - 1;

          if (!visited[value]) {
            DeepThroughGraph(value, visited, neighbours);
          }
        }
      }
    }  

    // Will create a visiting list for the Graph vertexes and launch the DFS search method
    private void RunThroughGraph() {
      var length = _neighbours.Count;
      var visited = new List<bool>();
      
      for (var i = 0; i < length + 1; i++) {
        visited.Add(false);
      }

      DeepThroughGraph(0, visited, RebuildNeighbours());
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
    private void BuildMatrixGridView(List<List<int>> inputMatrix) {
      var length = inputMatrix.Count;

      matrixView.RowCount = length;
      matrixView.ColumnCount = length;
      
      // Fill the headers of the grid
      for (int i = 0; i < length; i++) {
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
    
    // Entering th count of vertexes
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
          ? new Pair<int, List<int>>(i, LineToNumbers(labelText))
          : new Pair<int, List<int>>(i, new List<int>()));
      }

      _matrix = BuildMatrix();

      BuildMatrixGridView(_matrix);
    }
  
    // Will recursively run through graph and output them into special label
    private void runThroughGraphButton_Click(object sender, EventArgs e) {
      RunThroughGraph();  // Start run!!!
    }
  }
}