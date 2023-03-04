namespace Linear_Regression
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uploadXButton = new System.Windows.Forms.Button();
            this.uploadYButton = new System.Windows.Forms.Button();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.graphButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.limitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uploadXButton
            // 
            this.uploadXButton.Location = new System.Drawing.Point(13, 15);
            this.uploadXButton.Margin = new System.Windows.Forms.Padding(4);
            this.uploadXButton.Name = "uploadXButton";
            this.uploadXButton.Size = new System.Drawing.Size(241, 28);
            this.uploadXButton.TabIndex = 0;
            this.uploadXButton.Text = "Upload Independent Values";
            this.uploadXButton.UseVisualStyleBackColor = true;
            this.uploadXButton.Click += new System.EventHandler(this.uploadXButton_Click);
            // 
            // uploadYButton
            // 
            this.uploadYButton.Location = new System.Drawing.Point(13, 60);
            this.uploadYButton.Margin = new System.Windows.Forms.Padding(4);
            this.uploadYButton.Name = "uploadYButton";
            this.uploadYButton.Size = new System.Drawing.Size(241, 28);
            this.uploadYButton.TabIndex = 1;
            this.uploadYButton.Text = "Upload Dependent Values";
            this.uploadYButton.UseVisualStyleBackColor = true;
            this.uploadYButton.Click += new System.EventHandler(this.uploadYButton_Click);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(268, 15);
            this.xLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(76, 16);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "File : Empty";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(268, 60);
            this.yLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(76, 16);
            this.yLabel.TabIndex = 2;
            this.yLabel.Text = "File : Empty";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(13, 172);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 28);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // graphButton
            // 
            this.graphButton.Enabled = false;
            this.graphButton.Location = new System.Drawing.Point(121, 136);
            this.graphButton.Margin = new System.Windows.Forms.Padding(4);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(100, 28);
            this.graphButton.TabIndex = 3;
            this.graphButton.Text = "Show Graph";
            this.graphButton.UseVisualStyleBackColor = true;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(13, 136);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(100, 28);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // limitTextBox
            // 
            this.limitTextBox.Location = new System.Drawing.Point(13, 96);
            this.limitTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.limitTextBox.Name = "limitTextBox";
            this.limitTextBox.Size = new System.Drawing.Size(132, 22);
            this.limitTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max Limit";
            // 
            // dataButton
            // 
            this.dataButton.Enabled = false;
            this.dataButton.Location = new System.Drawing.Point(121, 172);
            this.dataButton.Margin = new System.Windows.Forms.Padding(4);
            this.dataButton.Name = "dataButton";
            this.dataButton.Size = new System.Drawing.Size(100, 28);
            this.dataButton.TabIndex = 3;
            this.dataButton.Text = "Show Data";
            this.dataButton.UseVisualStyleBackColor = true;
            this.dataButton.Click += new System.EventHandler(this.dataButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 253);
            this.Controls.Add(this.limitTextBox);
            this.Controls.Add(this.dataButton);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.uploadYButton);
            this.Controls.Add(this.uploadXButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Regression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadXButton;
        private System.Windows.Forms.Button uploadYButton;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox limitTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dataButton;
    }
}

