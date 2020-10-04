using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphManipulator {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }
    
    // The Pair structure
    private struct Pair<T, T1> {
      private T firstElement;
      private T1 secondElement;

      public Pair(T first, T1 second) {
        this.firstElement = first;
        this.secondElement = second;
      }
      
      // public T First() {return this.firstElement;}

      public T1 Second() {
        return this.secondElement;
      }
    }

    // Convert the string into List of integers
    private static List<int> LineToNumbers(string line) {
      return line.Split(' ').Select(value => Convert.ToInt32(value)).ToList();
    }
    
    // Build matrix from the list of neighbours
    private static List<List<int>> BuildMatrix(List<Pair<int, List<int>>> neighbours) {
      var matrix = new List<List<int>>();  // The result matrix
      var length = neighbours.Count;   // The size of the matrix
      
      // Fill the matrix by zeroes
      for (int i = 0; i < length; i++) {
        matrix.Add(new List<int>());
        
        for (int j = 0; j < length; j++) {
          matrix[i].Add(0);  
        }
      }
      
      // Fill the result matrix
      for (var i = 0; i < length; i++) {
        var currentPair = neighbours[i].Second();  // The second element of the pair is List<int>
        var pairLength = currentPair.Count;   // The length of the current pair
        var pairIndex = 0;
        
        if (pairLength > 0) {
          for (var j = 0; j < length; j++) {
            if (pairIndex < pairLength && currentPair[pairIndex] == j+1) {
              matrix[i][j] = 1;
              pairIndex++;
            }
          }
        }
      }

      return matrix;
    }
    
    // Will create a label with the vortex number
    private static Label CreateLabel(int i) {
      var label = new Label {
        AutoSize = true,
        Font = new Font("Arial", 14, FontStyle.Regular),
        Location = new Point(10, 100 + i * 50),
        Text = Convert.ToString(i + 1),
        TextAlign = ContentAlignment.MiddleCenter
      };
      
      return label;
    }
    
    // Will create an input for the neighbours of the ith vortex
    private static TextBox CreateTextBox(int i) {
      var textBox = new TextBox {
        Name = "neighboursInputBox" + Convert.ToString(i),
        Height = 20,
        Width = 150,
        Font = new Font("Arial", 14, FontStyle.Regular),
        Location = new Point(50, 100 + i * 50),
        TextAlign = HorizontalAlignment.Left
      };

      return textBox;
    }
    
    // Will create a matrix view
    private void DisplayMatrix(List<List<int>> matrix) {
      var length = matrix.Count;

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
            matrixView.Rows[i].Cells[j].Value = matrix[i][j].ToString();
          }
        }
      }
    }
    
    // Enter the count of the rows
    private void button1_Click(object sender, EventArgs e) {
      var count = Convert.ToInt32(countInput.Text);
      
      // Will create 'count' of label+input pairs
      for (var i = 0; i < count; i++) {
        this.Controls.Add(CreateLabel(i));
        this.Controls.Add(CreateTextBox(i));
      }
    }
    
    // Enter the inputted neighbours
    private void button2_Click(object sender, EventArgs e) {
      var count = Convert.ToInt32(countInput.Text);
      var neighboursArray = new List<Pair<int, List<int>>>();
      const string namePrefix = "neighboursInputBox";
      
      // Create List of pairs: rowNumber==vortex - neighbours
      for (int i = 0; i < count; i++) {
        var inputBoxName = namePrefix + Convert.ToString(i);
        var labelText = this.Controls[inputBoxName].Text;
        neighboursArray.Add(new Pair<int, List<int>>(i, LineToNumbers(labelText)));
      }

      var matrix = BuildMatrix(neighboursArray);

      DisplayMatrix(matrix);
    }
  }
}