﻿namespace GraphManipulator {
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
      this.countInput = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.submitVertexCount = new System.Windows.Forms.Button();
      this.submitVertexCoord = new System.Windows.Forms.Button();
      this.matrixView = new System.Windows.Forms.DataGridView();
      this.outputLabel = new System.Windows.Forms.Label();
      this.GraphOutput = new System.Windows.Forms.Label();
      this.runThrougGraphButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize) (this.matrixView)).BeginInit();
      this.SuspendLayout();
      // 
      // countInput
      // 
      this.countInput.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.countInput.Location = new System.Drawing.Point(377, 15);
      this.countInput.Name = "countInput";
      this.countInput.Size = new System.Drawing.Size(165, 39);
      this.countInput.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(359, 37);
      this.label1.TabIndex = 1;
      this.label1.Text = "Enter a count of vertexes: ";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label2.Location = new System.Drawing.Point(12, 81);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(359, 41);
      this.label2.TabIndex = 2;
      this.label2.Text = "Fill the neighbours via space:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // submitVertexCount
      // 
      this.submitVertexCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.submitVertexCount.Location = new System.Drawing.Point(561, 17);
      this.submitVertexCount.Name = "submitVertexCount";
      this.submitVertexCount.Size = new System.Drawing.Size(148, 39);
      this.submitVertexCount.TabIndex = 5;
      this.submitVertexCount.Text = "Enter";
      this.submitVertexCount.UseVisualStyleBackColor = true;
      this.submitVertexCount.Click += new System.EventHandler(this.submitVertexCountButton_Click);
      // 
      // submitVertexCoord
      // 
      this.submitVertexCoord.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.submitVertexCoord.Location = new System.Drawing.Point(377, 85);
      this.submitVertexCoord.Name = "submitVertexCoord";
      this.submitVertexCoord.Size = new System.Drawing.Size(148, 39);
      this.submitVertexCoord.TabIndex = 6;
      this.submitVertexCoord.Text = "Enter";
      this.submitVertexCoord.UseVisualStyleBackColor = true;
      this.submitVertexCoord.Click += new System.EventHandler(this.submitVertexCoordButton_Click);
      // 
      // matrixView
      // 
      this.matrixView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.matrixView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.matrixView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.matrixView.GridColor = System.Drawing.SystemColors.ActiveBorder;
      this.matrixView.Location = new System.Drawing.Point(377, 167);
      this.matrixView.Name = "matrixView";
      this.matrixView.RowTemplate.Height = 27;
      this.matrixView.Size = new System.Drawing.Size(600, 400);
      this.matrixView.TabIndex = 7;
      // 
      // outputLabel
      // 
      this.outputLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.outputLabel.Location = new System.Drawing.Point(377, 127);
      this.outputLabel.Name = "outputLabel";
      this.outputLabel.Size = new System.Drawing.Size(208, 37);
      this.outputLabel.TabIndex = 8;
      this.outputLabel.Text = "The result matrix:";
      this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // GraphOutput
      // 
      this.GraphOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.GraphOutput.Location = new System.Drawing.Point(377, 615);
      this.GraphOutput.Name = "GraphOutput";
      this.GraphOutput.Size = new System.Drawing.Size(600, 40);
      this.GraphOutput.TabIndex = 9;
      this.GraphOutput.Text = "Output(DFS): ";
      this.GraphOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // runThrougGraphButton
      // 
      this.runThrougGraphButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.runThrougGraphButton.Location = new System.Drawing.Point(377, 573);
      this.runThrougGraphButton.Name = "runThrougGraphButton";
      this.runThrougGraphButton.Size = new System.Drawing.Size(208, 39);
      this.runThrougGraphButton.TabIndex = 10;
      this.runThrougGraphButton.Text = "Run Through Graph";
      this.runThrougGraphButton.UseVisualStyleBackColor = true;
      this.runThrougGraphButton.Click += new System.EventHandler(this.runThroughGraphButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.AutoScroll = true;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.ClientSize = new System.Drawing.Size(1902, 1033);
      this.Controls.Add(this.runThrougGraphButton);
      this.Controls.Add(this.GraphOutput);
      this.Controls.Add(this.outputLabel);
      this.Controls.Add(this.matrixView);
      this.Controls.Add(this.submitVertexCoord);
      this.Controls.Add(this.submitVertexCount);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.countInput);
      this.Name = "Form1";
      this.Text = "GraphManipulator";
      ((System.ComponentModel.ISupportInitialize) (this.matrixView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.TextBox countInput;
    private System.Windows.Forms.Label GraphOutput;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView matrixView;
    private System.Windows.Forms.Label outputLabel;
    private System.Windows.Forms.Button runThrougGraphButton;
    private System.Windows.Forms.Button submitVertexCoord;
    private System.Windows.Forms.Button submitVertexCount;

    #endregion
  }
}