﻿﻿﻿namespace Weighted_Graph_GUI {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }

      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.unweightedGraphButton = new System.Windows.Forms.Button();
      this.weightedGraphButton = new System.Windows.Forms.Button();
      this.sidePanel = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.vertexCountInput = new System.Windows.Forms.TextBox();
      this.unweightedGraphPanel = new System.Windows.Forms.Panel();
      this.calculateException = new System.Windows.Forms.Label();
      this.submitException = new System.Windows.Forms.Label();
      this.countException = new System.Windows.Forms.Label();
      this.acceptedLabel = new System.Windows.Forms.Label();
      this.outputShortestWay = new System.Windows.Forms.Label();
      this.calculateButton = new System.Windows.Forms.Button();
      this.to = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.@from = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.runThroughGraphButton = new System.Windows.Forms.Button();
      this.outputBfs = new System.Windows.Forms.Label();
      this.outputDfs = new System.Windows.Forms.Label();
      this.submitNeighboursButton = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.submitVertexCountButton = new System.Windows.Forms.Button();
      this.weightedGraphPanel = new System.Windows.Forms.Panel();
      this.waysWeightOutput = new System.Windows.Forms.TextBox();
      this.weightTable = new System.Windows.Forms.Label();
      this.neighboursTable = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.weightedInputException = new System.Windows.Forms.Label();
      this.weightedNeighboursSubmitButton = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.weightedCountSubmitButton = new System.Windows.Forms.Button();
      this.weightedCountInput = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.sidePanel.SuspendLayout();
      this.unweightedGraphPanel.SuspendLayout();
      this.weightedGraphPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // unweightedGraphButton
      // 
      this.unweightedGraphButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (50)))), ((int) (((byte) (50)))), ((int) (((byte) (50)))));
      this.unweightedGraphButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.unweightedGraphButton.FlatAppearance.BorderSize = 0;
      this.unweightedGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.unweightedGraphButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.unweightedGraphButton.ForeColor = System.Drawing.Color.White;
      this.unweightedGraphButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.unweightedGraphButton.Location = new System.Drawing.Point(3, 3);
      this.unweightedGraphButton.Name = "unweightedGraphButton";
      this.unweightedGraphButton.Size = new System.Drawing.Size(244, 60);
      this.unweightedGraphButton.TabIndex = 0;
      this.unweightedGraphButton.Text = "Unweighted Graph";
      this.unweightedGraphButton.UseVisualStyleBackColor = false;
      this.unweightedGraphButton.Click += new System.EventHandler(this.unweightedGraphButton_Click);
      // 
      // weightedGraphButton
      // 
      this.weightedGraphButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (50)))), ((int) (((byte) (50)))), ((int) (((byte) (50)))));
      this.weightedGraphButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.weightedGraphButton.FlatAppearance.BorderSize = 0;
      this.weightedGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.weightedGraphButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.weightedGraphButton.ForeColor = System.Drawing.Color.White;
      this.weightedGraphButton.Location = new System.Drawing.Point(3, 69);
      this.weightedGraphButton.Name = "weightedGraphButton";
      this.weightedGraphButton.Size = new System.Drawing.Size(244, 60);
      this.weightedGraphButton.TabIndex = 1;
      this.weightedGraphButton.Text = "Weighted Graph";
      this.weightedGraphButton.UseVisualStyleBackColor = false;
      this.weightedGraphButton.Click += new System.EventHandler(this.weightedGraphButton_Click);
      // 
      // sidePanel
      // 
      this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (28)))), ((int) (((byte) (28)))), ((int) (((byte) (28)))));
      this.sidePanel.Controls.Add(this.weightedGraphButton);
      this.sidePanel.Controls.Add(this.unweightedGraphButton);
      this.sidePanel.Location = new System.Drawing.Point(12, 12);
      this.sidePanel.Name = "sidePanel";
      this.sidePanel.Size = new System.Drawing.Size(250, 929);
      this.sidePanel.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(3, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(277, 40);
      this.label1.TabIndex = 0;
      this.label1.Text = "Enter count of vertexes:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // vertexCountInput
      // 
      this.vertexCountInput.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
      this.vertexCountInput.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.vertexCountInput.Location = new System.Drawing.Point(286, 13);
      this.vertexCountInput.Multiline = true;
      this.vertexCountInput.Name = "vertexCountInput";
      this.vertexCountInput.Size = new System.Drawing.Size(52, 40);
      this.vertexCountInput.TabIndex = 1;
      // 
      // unweightedGraphPanel
      // 
      this.unweightedGraphPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (35)))), ((int) (((byte) (35)))), ((int) (((byte) (35)))));
      this.unweightedGraphPanel.Controls.Add(this.calculateException);
      this.unweightedGraphPanel.Controls.Add(this.submitException);
      this.unweightedGraphPanel.Controls.Add(this.countException);
      this.unweightedGraphPanel.Controls.Add(this.acceptedLabel);
      this.unweightedGraphPanel.Controls.Add(this.outputShortestWay);
      this.unweightedGraphPanel.Controls.Add(this.calculateButton);
      this.unweightedGraphPanel.Controls.Add(this.to);
      this.unweightedGraphPanel.Controls.Add(this.label4);
      this.unweightedGraphPanel.Controls.Add(this.@from);
      this.unweightedGraphPanel.Controls.Add(this.label3);
      this.unweightedGraphPanel.Controls.Add(this.runThroughGraphButton);
      this.unweightedGraphPanel.Controls.Add(this.outputBfs);
      this.unweightedGraphPanel.Controls.Add(this.outputDfs);
      this.unweightedGraphPanel.Controls.Add(this.submitNeighboursButton);
      this.unweightedGraphPanel.Controls.Add(this.label2);
      this.unweightedGraphPanel.Controls.Add(this.submitVertexCountButton);
      this.unweightedGraphPanel.Controls.Add(this.vertexCountInput);
      this.unweightedGraphPanel.Controls.Add(this.label1);
      this.unweightedGraphPanel.Location = new System.Drawing.Point(268, 12);
      this.unweightedGraphPanel.Name = "unweightedGraphPanel";
      this.unweightedGraphPanel.Size = new System.Drawing.Size(1202, 929);
      this.unweightedGraphPanel.TabIndex = 1;
      // 
      // calculateException
      // 
      this.calculateException.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.calculateException.ForeColor = System.Drawing.Color.Red;
      this.calculateException.Location = new System.Drawing.Point(542, 337);
      this.calculateException.Name = "calculateException";
      this.calculateException.Size = new System.Drawing.Size(168, 40);
      this.calculateException.TabIndex = 17;
      this.calculateException.Text = "Invalid Input!";
      this.calculateException.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // submitException
      // 
      this.submitException.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.submitException.ForeColor = System.Drawing.Color.Red;
      this.submitException.Location = new System.Drawing.Point(648, 68);
      this.submitException.Name = "submitException";
      this.submitException.Size = new System.Drawing.Size(168, 40);
      this.submitException.TabIndex = 16;
      this.submitException.Text = "Invalid Input!";
      this.submitException.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // countException
      // 
      this.countException.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.countException.ForeColor = System.Drawing.Color.Red;
      this.countException.Location = new System.Drawing.Point(500, 13);
      this.countException.Name = "countException";
      this.countException.Size = new System.Drawing.Size(168, 40);
      this.countException.TabIndex = 15;
      this.countException.Text = "Invalid Input!";
      this.countException.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // acceptedLabel
      // 
      this.acceptedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.acceptedLabel.ForeColor = System.Drawing.Color.White;
      this.acceptedLabel.Location = new System.Drawing.Point(648, 69);
      this.acceptedLabel.Name = "acceptedLabel";
      this.acceptedLabel.Size = new System.Drawing.Size(164, 40);
      this.acceptedLabel.TabIndex = 14;
      this.acceptedLabel.Text = "Submitted!";
      this.acceptedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // outputShortestWay
      // 
      this.outputShortestWay.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.outputShortestWay.ForeColor = System.Drawing.Color.White;
      this.outputShortestWay.Location = new System.Drawing.Point(286, 337);
      this.outputShortestWay.Name = "outputShortestWay";
      this.outputShortestWay.Size = new System.Drawing.Size(900, 40);
      this.outputShortestWay.TabIndex = 13;
      this.outputShortestWay.Text = "The shortest way is: ";
      this.outputShortestWay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // calculateButton
      // 
      this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (50)))), ((int) (((byte) (50)))), ((int) (((byte) (50)))));
      this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.calculateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.calculateButton.ForeColor = System.Drawing.Color.White;
      this.calculateButton.Location = new System.Drawing.Point(818, 294);
      this.calculateButton.Name = "calculateButton";
      this.calculateButton.Size = new System.Drawing.Size(118, 40);
      this.calculateButton.TabIndex = 12;
      this.calculateButton.Text = "Calculate";
      this.calculateButton.UseVisualStyleBackColor = false;
      this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
      // 
      // to
      // 
      this.to.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
      this.to.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.to.Location = new System.Drawing.Point(760, 294);
      this.to.Multiline = true;
      this.to.Name = "to";
      this.to.Size = new System.Drawing.Size(52, 40);
      this.to.TabIndex = 11;
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label4.ForeColor = System.Drawing.Color.White;
      this.label4.Location = new System.Drawing.Point(716, 288);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(38, 40);
      this.label4.TabIndex = 10;
      this.label4.Text = "to";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // from
      // 
      this.@from.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
      this.@from.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.@from.Location = new System.Drawing.Point(658, 294);
      this.@from.Multiline = true;
      this.@from.Name = "from";
      this.@from.Size = new System.Drawing.Size(52, 40);
      this.@from.TabIndex = 9;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(286, 294);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(366, 40);
      this.label3.TabIndex = 8;
      this.label3.Text = "Calculate the shortest way from";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // runThroughGraphButton
      // 
      this.runThroughGraphButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (50)))), ((int) (((byte) (50)))), ((int) (((byte) (50)))));
      this.runThroughGraphButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.runThroughGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.runThroughGraphButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.runThroughGraphButton.ForeColor = System.Drawing.Color.White;
      this.runThroughGraphButton.Location = new System.Drawing.Point(286, 241);
      this.runThroughGraphButton.Name = "runThroughGraphButton";
      this.runThroughGraphButton.Size = new System.Drawing.Size(250, 40);
      this.runThroughGraphButton.TabIndex = 7;
      this.runThroughGraphButton.Text = "Run Through Graph";
      this.runThroughGraphButton.UseVisualStyleBackColor = false;
      this.runThroughGraphButton.Click += new System.EventHandler(this.runThroughGraphButton_Click);
      // 
      // outputBfs
      // 
      this.outputBfs.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.outputBfs.ForeColor = System.Drawing.Color.White;
      this.outputBfs.Location = new System.Drawing.Point(286, 198);
      this.outputBfs.Name = "outputBfs";
      this.outputBfs.Size = new System.Drawing.Size(600, 40);
      this.outputBfs.TabIndex = 6;
      this.outputBfs.Text = "BFS Output: ";
      this.outputBfs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // outputDfs
      // 
      this.outputDfs.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.outputDfs.ForeColor = System.Drawing.Color.White;
      this.outputDfs.Location = new System.Drawing.Point(286, 158);
      this.outputDfs.Name = "outputDfs";
      this.outputDfs.Size = new System.Drawing.Size(600, 40);
      this.outputDfs.TabIndex = 5;
      this.outputDfs.Text = "DFS Output: ";
      this.outputDfs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // submitNeighboursButton
      // 
      this.submitNeighboursButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (50)))), ((int) (((byte) (50)))), ((int) (((byte) (50)))));
      this.submitNeighboursButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.submitNeighboursButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.submitNeighboursButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.submitNeighboursButton.ForeColor = System.Drawing.Color.White;
      this.submitNeighboursButton.Location = new System.Drawing.Point(392, 69);
      this.submitNeighboursButton.Name = "submitNeighboursButton";
      this.submitNeighboursButton.Size = new System.Drawing.Size(250, 40);
      this.submitNeighboursButton.TabIndex = 4;
      this.submitNeighboursButton.Text = "Submit Neighbours";
      this.submitNeighboursButton.UseVisualStyleBackColor = false;
      this.submitNeighboursButton.Click += new System.EventHandler(this.submitNeighboursButton_Click);
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(3, 69);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(383, 40);
      this.label2.TabIndex = 3;
      this.label2.Text = "Enter neighbours for each vertex:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // submitVertexCountButton
      // 
      this.submitVertexCountButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (50)))), ((int) (((byte) (50)))), ((int) (((byte) (50)))));
      this.submitVertexCountButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.submitVertexCountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.submitVertexCountButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.submitVertexCountButton.ForeColor = System.Drawing.Color.White;
      this.submitVertexCountButton.Location = new System.Drawing.Point(344, 13);
      this.submitVertexCountButton.Name = "submitVertexCountButton";
      this.submitVertexCountButton.Size = new System.Drawing.Size(150, 40);
      this.submitVertexCountButton.TabIndex = 2;
      this.submitVertexCountButton.Text = "Commit";
      this.submitVertexCountButton.UseVisualStyleBackColor = false;
      this.submitVertexCountButton.Click += new System.EventHandler(this.submitVertexCountButton_Click);
      // 
      // weightedGraphPanel
      // 
      this.weightedGraphPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (35)))), ((int) (((byte) (35)))), ((int) (((byte) (35)))));
      this.weightedGraphPanel.Controls.Add(this.waysWeightOutput);
      this.weightedGraphPanel.Controls.Add(this.weightTable);
      this.weightedGraphPanel.Controls.Add(this.neighboursTable);
      this.weightedGraphPanel.Controls.Add(this.label5);
      this.weightedGraphPanel.Controls.Add(this.weightedInputException);
      this.weightedGraphPanel.Controls.Add(this.weightedNeighboursSubmitButton);
      this.weightedGraphPanel.Controls.Add(this.label7);
      this.weightedGraphPanel.Controls.Add(this.weightedCountSubmitButton);
      this.weightedGraphPanel.Controls.Add(this.weightedCountInput);
      this.weightedGraphPanel.Controls.Add(this.label8);
      this.weightedGraphPanel.Location = new System.Drawing.Point(268, 9);
      this.weightedGraphPanel.Name = "weightedGraphPanel";
      this.weightedGraphPanel.Size = new System.Drawing.Size(1202, 929);
      this.weightedGraphPanel.TabIndex = 2;
      // 
      // waysWeightOutput
      // 
      this.waysWeightOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.waysWeightOutput.Location = new System.Drawing.Point(286, 161);
      this.waysWeightOutput.Multiline = true;
      this.waysWeightOutput.Name = "waysWeightOutput";
      this.waysWeightOutput.Size = new System.Drawing.Size(400, 550);
      this.waysWeightOutput.TabIndex = 35;
      this.waysWeightOutput.Text = "Vertex        Distance From Source";
      // 
      // weightTable
      // 
      this.weightTable.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.weightTable.ForeColor = System.Drawing.Color.White;
      this.weightTable.Location = new System.Drawing.Point(150, 112);
      this.weightTable.Name = "weightTable";
      this.weightTable.Size = new System.Drawing.Size(70, 40);
      this.weightTable.TabIndex = 34;
      this.weightTable.Text = "Weight";
      this.weightTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // neighboursTable
      // 
      this.neighboursTable.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.neighboursTable.ForeColor = System.Drawing.Color.White;
      this.neighboursTable.Location = new System.Drawing.Point(40, 112);
      this.neighboursTable.Name = "neighboursTable";
      this.neighboursTable.Size = new System.Drawing.Size(102, 40);
      this.neighboursTable.TabIndex = 33;
      this.neighboursTable.Text = "Neighbours";
      this.neighboursTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.Location = new System.Drawing.Point(286, 112);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(900, 40);
      this.label5.TabIndex = 32;
      this.label5.Text = "The shortest way is: ";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // weightedInputException
      // 
      this.weightedInputException.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.weightedInputException.ForeColor = System.Drawing.Color.Red;
      this.weightedInputException.Location = new System.Drawing.Point(500, 16);
      this.weightedInputException.Name = "weightedInputException";
      this.weightedInputException.Size = new System.Drawing.Size(168, 40);
      this.weightedInputException.TabIndex = 22;
      this.weightedInputException.Text = "Invalid Input!";
      this.weightedInputException.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // weightedNeighboursSubmitButton
      // 
      this.weightedNeighboursSubmitButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (50)))), ((int) (((byte) (50)))), ((int) (((byte) (50)))));
      this.weightedNeighboursSubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.weightedNeighboursSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.weightedNeighboursSubmitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.weightedNeighboursSubmitButton.ForeColor = System.Drawing.Color.White;
      this.weightedNeighboursSubmitButton.Location = new System.Drawing.Point(392, 72);
      this.weightedNeighboursSubmitButton.Name = "weightedNeighboursSubmitButton";
      this.weightedNeighboursSubmitButton.Size = new System.Drawing.Size(250, 40);
      this.weightedNeighboursSubmitButton.TabIndex = 21;
      this.weightedNeighboursSubmitButton.Text = "Submit Neighbours";
      this.weightedNeighboursSubmitButton.UseVisualStyleBackColor = false;
      this.weightedNeighboursSubmitButton.Click += new System.EventHandler(this.weightedNeighboursSubmitButton_Click);
      // 
      // label7
      // 
      this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label7.ForeColor = System.Drawing.Color.White;
      this.label7.Location = new System.Drawing.Point(3, 72);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(383, 40);
      this.label7.TabIndex = 20;
      this.label7.Text = "Enter neighbours for each vertex:";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // weightedCountSubmitButton
      // 
      this.weightedCountSubmitButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (50)))), ((int) (((byte) (50)))), ((int) (((byte) (50)))));
      this.weightedCountSubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.weightedCountSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.weightedCountSubmitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.weightedCountSubmitButton.ForeColor = System.Drawing.Color.White;
      this.weightedCountSubmitButton.Location = new System.Drawing.Point(344, 16);
      this.weightedCountSubmitButton.Name = "weightedCountSubmitButton";
      this.weightedCountSubmitButton.Size = new System.Drawing.Size(150, 40);
      this.weightedCountSubmitButton.TabIndex = 19;
      this.weightedCountSubmitButton.Text = "Commit";
      this.weightedCountSubmitButton.UseVisualStyleBackColor = false;
      this.weightedCountSubmitButton.Click += new System.EventHandler(this.weightedCountSubmitButton_Click);
      // 
      // weightedCountInput
      // 
      this.weightedCountInput.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
      this.weightedCountInput.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.weightedCountInput.Location = new System.Drawing.Point(286, 16);
      this.weightedCountInput.Multiline = true;
      this.weightedCountInput.Name = "weightedCountInput";
      this.weightedCountInput.Size = new System.Drawing.Size(52, 40);
      this.weightedCountInput.TabIndex = 18;
      // 
      // label8
      // 
      this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label8.ForeColor = System.Drawing.Color.White;
      this.label8.Location = new System.Drawing.Point(3, 16);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(277, 40);
      this.label8.TabIndex = 17;
      this.label8.Text = "Enter count of vertexes:";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (28)))), ((int) (((byte) (28)))), ((int) (((byte) (28)))));
      this.ClientSize = new System.Drawing.Size(1482, 953);
      this.Controls.Add(this.weightedGraphPanel);
      this.Controls.Add(this.unweightedGraphPanel);
      this.Controls.Add(this.sidePanel);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Graph Manipulator Beta";
      this.sidePanel.ResumeLayout(false);
      this.unweightedGraphPanel.ResumeLayout(false);
      this.unweightedGraphPanel.PerformLayout();
      this.weightedGraphPanel.ResumeLayout(false);
      this.weightedGraphPanel.PerformLayout();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label acceptedLabel;
    private System.Windows.Forms.Button calculateButton;
    private System.Windows.Forms.Label calculateException;
    private System.Windows.Forms.Label countException;
    private System.Windows.Forms.TextBox @from;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label neighboursTable;
    private System.Windows.Forms.Label outputBfs;
    private System.Windows.Forms.Label outputDfs;
    private System.Windows.Forms.Label outputShortestWay;
    private System.Windows.Forms.Button runThroughGraphButton;
    private System.Windows.Forms.Panel sidePanel;
    private System.Windows.Forms.Label submitException;
    private System.Windows.Forms.Button submitNeighboursButton;
    private System.Windows.Forms.Button submitVertexCountButton;
    private System.Windows.Forms.TextBox to;
    private System.Windows.Forms.Button unweightedGraphButton;
    private System.Windows.Forms.Panel unweightedGraphPanel;
    private System.Windows.Forms.TextBox vertexCountInput;
    private System.Windows.Forms.TextBox waysWeightOutput;
    private System.Windows.Forms.TextBox weightedCountInput;
    private System.Windows.Forms.Button weightedCountSubmitButton;
    private System.Windows.Forms.Button weightedGraphButton;
    private System.Windows.Forms.Panel weightedGraphPanel;
    private System.Windows.Forms.Label weightedInputException;
    private System.Windows.Forms.Button weightedNeighboursSubmitButton;
    private System.Windows.Forms.Label weightTable;

    #endregion
  }
}