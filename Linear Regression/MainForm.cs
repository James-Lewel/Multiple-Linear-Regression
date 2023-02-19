using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Linear_Regression
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<string> independentValues = new List<string>();
        private List<string> dependentValues = new List<string>();
        private bool xFileExist = false;
        private bool yFileExist = false;

        private void uploadXButton_Click(object sender, EventArgs e)
        {
            // Loads a csv
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Sets properties of dialog
                openFileDialog.Title = "Open Independent Values";
                openFileDialog.Filter = "Files(*.csv)|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Reads and store raw data
                    string[] rawCSV = System.IO.File.ReadAllLines(openFileDialog.FileName);
                    
                    for(int i = 1; i <= 25; i++)
                    {

                    }

                    xLabel.Text = "File : Updated";
                    xFileExist = true;
                }
            }
        }

        private void uploadYButton_Click(object sender, EventArgs e)
        {
            // Loads a csv
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Sets properties of dialog
                openFileDialog.Title = "Open Independent Values";
                openFileDialog.Filter = "Files(*.csv)|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Reads and store raw data
                    string[] rawCSV = System.IO.File.ReadAllLines(openFileDialog.FileName);

                    for (int i = 1; i <= 25; i++)
                    {

                    }

                    yLabel.Text = "File : Updated";
                    yFileExist = true;
                }
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if(xFileExist && yFileExist)
            {
                calculateButton.Enabled = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            xFileExist = false;
            yFileExist = false;

            calculateButton.Enabled = false;

            xLabel.Text = "File : Empty";
            yLabel.Text = "File : Empty";
        }
    }
}
