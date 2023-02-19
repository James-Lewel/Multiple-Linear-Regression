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
            this.calculateButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uploadXButton
            // 
            this.uploadXButton.Location = new System.Drawing.Point(13, 30);
            this.uploadXButton.Name = "uploadXButton";
            this.uploadXButton.Size = new System.Drawing.Size(181, 23);
            this.uploadXButton.TabIndex = 0;
            this.uploadXButton.Text = "Upload Independent Values";
            this.uploadXButton.UseVisualStyleBackColor = true;
            this.uploadXButton.Click += new System.EventHandler(this.uploadXButton_Click);
            // 
            // uploadYButton
            // 
            this.uploadYButton.Location = new System.Drawing.Point(12, 76);
            this.uploadYButton.Name = "uploadYButton";
            this.uploadYButton.Size = new System.Drawing.Size(181, 23);
            this.uploadYButton.TabIndex = 1;
            this.uploadYButton.Text = "Upload Dependent Values";
            this.uploadYButton.UseVisualStyleBackColor = true;
            this.uploadYButton.Click += new System.EventHandler(this.uploadYButton_Click);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(13, 60);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(61, 13);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "File : Empty";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(10, 102);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(61, 13);
            this.yLabel.TabIndex = 2;
            this.yLabel.Text = "File : Empty";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 200);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // graphButton
            // 
            this.graphButton.Location = new System.Drawing.Point(93, 142);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(75, 23);
            this.graphButton.TabIndex = 3;
            this.graphButton.Text = "Show Graph";
            this.graphButton.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Location = new System.Drawing.Point(12, 142);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(12, 171);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 232);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.uploadYButton);
            this.Controls.Add(this.uploadXButton);
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
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button applyButton;
    }
}

