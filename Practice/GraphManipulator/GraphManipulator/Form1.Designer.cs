﻿﻿namespace GraphManipulator {
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
      this.unweightedGraphPanel = new System.Windows.Forms.Panel();
      this.getDebugInfo = new System.Windows.Forms.Button();
      this.debugOutput = new System.Windows.Forms.TextBox();
      this.calculateWay = new System.Windows.Forms.Button();
      this.graphOutputWay = new System.Windows.Forms.Label();
      this.inputToLabel = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.inputFromLabel = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.GraphOutputBFS = new System.Windows.Forms.Label();
      this.runThrougGraph = new System.Windows.Forms.Button();
      this.GraphOutputDFS = new System.Windows.Forms.Label();
      this.outputLabel = new System.Windows.Forms.Label();
      this.matrixView = new System.Windows.Forms.DataGridView();
      this.submitVertexCoord = new System.Windows.Forms.Button();
      this.submitVertexCount = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.countInput = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.weightedGraphControl = new System.Windows.Forms.Button();
      this.unweightedGraphControl = new System.Windows.Forms.Button();
      this.countInput_1 = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.submitVertexCount_1 = new System.Windows.Forms.Button();
      this.submitNeighbours_1 = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.startPointEnetr = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.shortestWayLabel = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.weightedGraphPanel = new System.Windows.Forms.Panel();
      this.pairPrint = new System.Windows.Forms.TextBox();
      this.unweightedGraphPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.matrixView)).BeginInit();
      this.panel2.SuspendLayout();
      this.weightedGraphPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // unweightedGraphPanel
      // 
      this.unweightedGraphPanel.Controls.Add(this.getDebugInfo);
      this.unweightedGraphPanel.Controls.Add(this.debugOutput);
      this.unweightedGraphPanel.Controls.Add(this.calculateWay);
      this.unweightedGraphPanel.Controls.Add(this.graphOutputWay);
      this.unweightedGraphPanel.Controls.Add(this.inputToLabel);
      this.unweightedGraphPanel.Controls.Add(this.label4);
      this.unweightedGraphPanel.Controls.Add(this.inputFromLabel);
      this.unweightedGraphPanel.Controls.Add(this.label3);
      this.unweightedGraphPanel.Controls.Add(this.GraphOutputBFS);
      this.unweightedGraphPanel.Controls.Add(this.runThrougGraph);
      this.unweightedGraphPanel.Controls.Add(this.GraphOutputDFS);
      this.unweightedGraphPanel.Controls.Add(this.outputLabel);
      this.unweightedGraphPanel.Controls.Add(this.matrixView);
      this.unweightedGraphPanel.Controls.Add(this.submitVertexCoord);
      this.unweightedGraphPanel.Controls.Add(this.submitVertexCount);
      this.unweightedGraphPanel.Controls.Add(this.label2);
      this.unweightedGraphPanel.Controls.Add(this.label1);
      this.unweightedGraphPanel.Controls.Add(this.countInput);
      this.unweightedGraphPanel.Location = new System.Drawing.Point(293, 12);
      this.unweightedGraphPanel.Name = "unweightedGraphPanel";
      this.unweightedGraphPanel.Size = new System.Drawing.Size(1312, 796);
      this.unweightedGraphPanel.TabIndex = 0;
      // 
      // getDebugInfo
      // 
      this.getDebugInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.getDebugInfo.Location = new System.Drawing.Point(983, 114);
      this.getDebugInfo.Name = "getDebugInfo";
      this.getDebugInfo.Size = new System.Drawing.Size(139, 44);
      this.getDebugInfo.TabIndex = 37;
      this.getDebugInfo.Text = "Get Debug Info";
      this.getDebugInfo.UseVisualStyleBackColor = true;
      // 
      // debugOutput
      // 
      this.debugOutput.Location = new System.Drawing.Point(983, 164);
      this.debugOutput.Multiline = true;
      this.debugOutput.Name = "debugOutput";
      this.debugOutput.ReadOnly = true;
      this.debugOutput.Size = new System.Drawing.Size(306, 400);
      this.debugOutput.TabIndex = 36;
      this.debugOutput.WordWrap = false;
      // 
      // calculateWay
      // 
      this.calculateWay.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.calculateWay.Location = new System.Drawing.Point(878, 692);
      this.calculateWay.Name = "calculateWay";
      this.calculateWay.Size = new System.Drawing.Size(139, 44);
      this.calculateWay.TabIndex = 35;
      this.calculateWay.Text = "Calculate";
      this.calculateWay.UseVisualStyleBackColor = true;
      this.calculateWay.Click += new System.EventHandler(this.calculateWay_Click);
      // 
      // graphOutputWay
      // 
      this.graphOutputWay.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.graphOutputWay.Location = new System.Drawing.Point(377, 737);
      this.graphOutputWay.Name = "graphOutputWay";
      this.graphOutputWay.Size = new System.Drawing.Size(600, 40);
      this.graphOutputWay.TabIndex = 34;
      this.graphOutputWay.Text = "The shortest way: ";
      this.graphOutputWay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // inputToLabel
      // 
      this.inputToLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.inputToLabel.Location = new System.Drawing.Point(827, 695);
      this.inputToLabel.Name = "inputToLabel";
      this.inputToLabel.Size = new System.Drawing.Size(45, 39);
      this.inputToLabel.TabIndex = 33;
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label4.Location = new System.Drawing.Point(781, 692);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 40);
      this.label4.TabIndex = 32;
      this.label4.Text = "to";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // inputFromLabel
      // 
      this.inputFromLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.inputFromLabel.Location = new System.Drawing.Point(730, 695);
      this.inputFromLabel.Name = "inputFromLabel";
      this.inputFromLabel.Size = new System.Drawing.Size(45, 39);
      this.inputFromLabel.TabIndex = 31;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label3.Location = new System.Drawing.Point(377, 692);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(347, 40);
      this.label3.TabIndex = 30;
      this.label3.Text = "Calculate the fastest way from";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // GraphOutputBFS
      // 
      this.GraphOutputBFS.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.GraphOutputBFS.Location = new System.Drawing.Point(377, 652);
      this.GraphOutputBFS.Name = "GraphOutputBFS";
      this.GraphOutputBFS.Size = new System.Drawing.Size(600, 40);
      this.GraphOutputBFS.TabIndex = 29;
      this.GraphOutputBFS.Text = "Output(BFS): ";
      this.GraphOutputBFS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // runThrougGraph
      // 
      this.runThrougGraph.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.runThrougGraph.Location = new System.Drawing.Point(377, 570);
      this.runThrougGraph.Name = "runThrougGraph";
      this.runThrougGraph.Size = new System.Drawing.Size(208, 39);
      this.runThrougGraph.TabIndex = 28;
      this.runThrougGraph.Text = "Run Through Graph";
      this.runThrougGraph.UseVisualStyleBackColor = true;
      this.runThrougGraph.Click += new System.EventHandler(this.runThroughGraph_Click);
      // 
      // GraphOutputDFS
      // 
      this.GraphOutputDFS.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.GraphOutputDFS.Location = new System.Drawing.Point(377, 612);
      this.GraphOutputDFS.Name = "GraphOutputDFS";
      this.GraphOutputDFS.Size = new System.Drawing.Size(600, 40);
      this.GraphOutputDFS.TabIndex = 27;
      this.GraphOutputDFS.Text = "Output(DFS): ";
      this.GraphOutputDFS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // outputLabel
      // 
      this.outputLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.outputLabel.Location = new System.Drawing.Point(377, 124);
      this.outputLabel.Name = "outputLabel";
      this.outputLabel.Size = new System.Drawing.Size(208, 37);
      this.outputLabel.TabIndex = 26;
      this.outputLabel.Text = "The result matrix:";
      this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // matrixView
      // 
      this.matrixView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.matrixView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.matrixView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.matrixView.GridColor = System.Drawing.SystemColors.ActiveBorder;
      this.matrixView.Location = new System.Drawing.Point(377, 164);
      this.matrixView.Name = "matrixView";
      this.matrixView.RowTemplate.Height = 27;
      this.matrixView.Size = new System.Drawing.Size(600, 400);
      this.matrixView.TabIndex = 25;
      // 
      // submitVertexCoord
      // 
      this.submitVertexCoord.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.submitVertexCoord.Location = new System.Drawing.Point(377, 82);
      this.submitVertexCoord.Name = "submitVertexCoord";
      this.submitVertexCoord.Size = new System.Drawing.Size(208, 39);
      this.submitVertexCoord.TabIndex = 24;
      this.submitVertexCoord.Text = "Submit Neighbours";
      this.submitVertexCoord.UseVisualStyleBackColor = true;
      this.submitVertexCoord.Click += new System.EventHandler(this.submitVertexCoord_Click);
      // 
      // submitVertexCount
      // 
      this.submitVertexCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.submitVertexCount.Location = new System.Drawing.Point(561, 14);
      this.submitVertexCount.Name = "submitVertexCount";
      this.submitVertexCount.Size = new System.Drawing.Size(148, 39);
      this.submitVertexCount.TabIndex = 23;
      this.submitVertexCount.Text = "Enter Count";
      this.submitVertexCount.UseVisualStyleBackColor = true;
      this.submitVertexCount.Click += new System.EventHandler(this.submitVertexCount_Click);
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label2.Location = new System.Drawing.Point(12, 78);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(359, 41);
      this.label2.TabIndex = 22;
      this.label2.Text = "Fill the neighbours via space:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.label1.Location = new System.Drawing.Point(12, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(359, 37);
      this.label1.TabIndex = 21;
      this.label1.Text = "Enter a count of vertexes: ";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // countInput
      // 
      this.countInput.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.countInput.Location = new System.Drawing.Point(377, 12);
      this.countInput.Name = "countInput";
      this.countInput.Size = new System.Drawing.Size(165, 39);
      this.countInput.TabIndex = 20;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.weightedGraphControl);
      this.panel2.Controls.Add(this.unweightedGraphControl);
      this.panel2.Location = new System.Drawing.Point(12, 12);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(275, 796);
      this.panel2.TabIndex = 1;
      // 
      // weightedGraphControl
      // 
      this.weightedGraphControl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.weightedGraphControl.Location = new System.Drawing.Point(3, 79);
      this.weightedGraphControl.Name = "weightedGraphControl";
      this.weightedGraphControl.Size = new System.Drawing.Size(269, 70);
      this.weightedGraphControl.TabIndex = 39;
      this.weightedGraphControl.Text = "Weighted Graph";
      this.weightedGraphControl.UseVisualStyleBackColor = true;
      this.weightedGraphControl.Click += new System.EventHandler(this.weightedGraphControl_Click);
      // 
      // unweightedGraphControl
      // 
      this.unweightedGraphControl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.unweightedGraphControl.Location = new System.Drawing.Point(3, 3);
      this.unweightedGraphControl.Name = "unweightedGraphControl";
      this.unweightedGraphControl.Size = new System.Drawing.Size(269, 70);
      this.unweightedGraphControl.TabIndex = 38;
      this.unweightedGraphControl.Text = "Unweighted Graph";
      this.unweightedGraphControl.UseVisualStyleBackColor = true;
      this.unweightedGraphControl.Click += new System.EventHandler(this.unweightedGraphControl_Click);
      // 
      // countInput_1
      // 
      this.countInput_1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.countInput_1.Location = new System.Drawing.Point(383, 16);
      this.countInput_1.Name = "countInput_1";
      this.countInput_1.Size = new System.Drawing.Size(165, 39);
      this.countInput_1.TabIndex = 38;
      // 
      // label12
      // 
      this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.label12.Location = new System.Drawing.Point(18, 16);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(359, 37);
      this.label12.TabIndex = 39;
      this.label12.Text = "Enter a count of vertexes: ";
      this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label11
      // 
      this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label11.Location = new System.Drawing.Point(18, 82);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(359, 41);
      this.label11.TabIndex = 40;
      this.label11.Text = "Fill the neighbours via space:";
      this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // submitVertexCount_1
      // 
      this.submitVertexCount_1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.submitVertexCount_1.Location = new System.Drawing.Point(567, 18);
      this.submitVertexCount_1.Name = "submitVertexCount_1";
      this.submitVertexCount_1.Size = new System.Drawing.Size(148, 39);
      this.submitVertexCount_1.TabIndex = 41;
      this.submitVertexCount_1.Text = "Enter Count";
      this.submitVertexCount_1.UseVisualStyleBackColor = true;
      this.submitVertexCount_1.Click += new System.EventHandler(this.submitVertexCount_1_Click);
      // 
      // submitNeighbours_1
      // 
      this.submitNeighbours_1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.submitNeighbours_1.Location = new System.Drawing.Point(383, 86);
      this.submitNeighbours_1.Name = "submitNeighbours_1";
      this.submitNeighbours_1.Size = new System.Drawing.Size(208, 39);
      this.submitNeighbours_1.TabIndex = 42;
      this.submitNeighbours_1.Text = "Submit Neighbours";
      this.submitNeighbours_1.UseVisualStyleBackColor = true;
      this.submitNeighbours_1.Click += new System.EventHandler(this.submitNeighbours_1_Click);
      // 
      // label7
      // 
      this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label7.Location = new System.Drawing.Point(474, 151);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(347, 40);
      this.label7.TabIndex = 48;
      this.label7.Text = "Calculate the fastest way from";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // startPointEnetr
      // 
      this.startPointEnetr.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.startPointEnetr.Location = new System.Drawing.Point(827, 154);
      this.startPointEnetr.Name = "startPointEnetr";
      this.startPointEnetr.Size = new System.Drawing.Size(45, 39);
      this.startPointEnetr.TabIndex = 49;
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label6.Location = new System.Drawing.Point(878, 151);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(236, 40);
      this.label6.TabIndex = 50;
      this.label6.Text = "to all other vertexes";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // shortestWayLabel
      // 
      this.shortestWayLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.shortestWayLabel.Location = new System.Drawing.Point(474, 238);
      this.shortestWayLabel.Name = "shortestWayLabel";
      this.shortestWayLabel.Size = new System.Drawing.Size(600, 40);
      this.shortestWayLabel.TabIndex = 52;
      this.shortestWayLabel.Text = "The shortest ways: ";
      this.shortestWayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.button2.Location = new System.Drawing.Point(474, 194);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(139, 41);
      this.button2.TabIndex = 53;
      this.button2.Text = "Calculate";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // weightedGraphPanel
      // 
      this.weightedGraphPanel.Controls.Add(this.pairPrint);
      this.weightedGraphPanel.Controls.Add(this.button2);
      this.weightedGraphPanel.Controls.Add(this.shortestWayLabel);
      this.weightedGraphPanel.Controls.Add(this.label6);
      this.weightedGraphPanel.Controls.Add(this.startPointEnetr);
      this.weightedGraphPanel.Controls.Add(this.label7);
      this.weightedGraphPanel.Controls.Add(this.submitNeighbours_1);
      this.weightedGraphPanel.Controls.Add(this.submitVertexCount_1);
      this.weightedGraphPanel.Controls.Add(this.label11);
      this.weightedGraphPanel.Controls.Add(this.label12);
      this.weightedGraphPanel.Controls.Add(this.countInput_1);
      this.weightedGraphPanel.Location = new System.Drawing.Point(293, 12);
      this.weightedGraphPanel.Name = "weightedGraphPanel";
      this.weightedGraphPanel.Size = new System.Drawing.Size(1312, 796);
      this.weightedGraphPanel.TabIndex = 38;
      // 
      // pairPrint
      // 
      this.pairPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.pairPrint.Location = new System.Drawing.Point(474, 281);
      this.pairPrint.Multiline = true;
      this.pairPrint.Name = "pairPrint";
      this.pairPrint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.pairPrint.Size = new System.Drawing.Size(640, 411);
      this.pairPrint.TabIndex = 54;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.AutoScroll = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.ClientSize = new System.Drawing.Size(1902, 953);
      this.Controls.Add(this.weightedGraphPanel);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.unweightedGraphPanel);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "GraphManipulator";
      this.unweightedGraphPanel.ResumeLayout(false);
      this.unweightedGraphPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize) (this.matrixView)).EndInit();
      this.panel2.ResumeLayout(false);
      this.weightedGraphPanel.ResumeLayout(false);
      this.weightedGraphPanel.PerformLayout();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button calculateWay;
    private System.Windows.Forms.TextBox countInput;
    private System.Windows.Forms.TextBox countInput_1;
    private System.Windows.Forms.TextBox debugOutput;
    private System.Windows.Forms.Button getDebugInfo;
    private System.Windows.Forms.Label GraphOutputBFS;
    private System.Windows.Forms.Label GraphOutputDFS;
    private System.Windows.Forms.Label graphOutputWay;
    private System.Windows.Forms.TextBox inputFromLabel;
    private System.Windows.Forms.TextBox inputToLabel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.DataGridView matrixView;
    private System.Windows.Forms.Label outputLabel;
    private System.Windows.Forms.TextBox pairPrint;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button runThrougGraph;
    private System.Windows.Forms.Label shortestWayLabel;
    private System.Windows.Forms.TextBox startPointEnetr;
    private System.Windows.Forms.Button submitNeighbours_1;
    private System.Windows.Forms.Button submitVertexCoord;
    private System.Windows.Forms.Button submitVertexCount;
    private System.Windows.Forms.Button submitVertexCount_1;
    private System.Windows.Forms.Button unweightedGraphControl;
    private System.Windows.Forms.Panel unweightedGraphPanel;
    private System.Windows.Forms.Button weightedGraphControl;
    private System.Windows.Forms.Panel weightedGraphPanel;

    #endregion
  }
}