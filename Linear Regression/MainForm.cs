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

        private List<List<string>> independentValues = new List<List<string>>();
        private List<List<string>> dependentValues = new List<List<string>>();
        private int maxLimit;
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
                    string[] tempCSV = rawCSV[0].Split(',');
                    bool[] includeCSV = new bool[tempCSV.Length];

                    for (int i = 0; i < tempCSV.Length; i++)
                    {
                        IncludeForm includeForm = new IncludeForm(tempCSV[i]);
                        includeForm.ShowDialog();

                        if(includeForm.DialogResult == DialogResult.Yes)
                            includeCSV[i] = true;
                        else
                            includeCSV[i] = false;
                    }

                    for (int i = 0; i < rawCSV.Length; i++)
                    {
                        // Adds sublist
                        independentValues.Add(new List<string>());

                        tempCSV = rawCSV[i].Split(',');

                        for (int j = 0; j < tempCSV.Length; j++)
                        {
                            if (includeCSV[j] == false) 
                                continue;

                            independentValues[i].Add(tempCSV[j]);
                        }
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
                    string[] tempCSV = rawCSV[0].Split(',');
                    bool[] includeCSV = new bool[tempCSV.Length];

                    for (int i = 0; i < tempCSV.Length; i++)
                    {
                        IncludeForm includeForm = new IncludeForm(tempCSV[i]);
                        includeForm.ShowDialog();

                        if (includeForm.DialogResult == DialogResult.Yes)
                            includeCSV[i] = true;
                        else
                            includeCSV[i] = false;
                    }

                    for (int i = 0; i < rawCSV.Length; i++)
                    {
                        // Adds sublist
                        dependentValues.Add(new List<string>());

                        tempCSV = rawCSV[i].Split(',');

                        for (int j = 0; j < tempCSV.Length; j++)
                        {
                            if (includeCSV[j] == false)
                                continue;

                            dependentValues[i].Add(tempCSV[j]);
                        }
                    }

                    yLabel.Text = "File : Updated";
                    yFileExist = true;
                }
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(limitTextBox.Text))
            {
                maxLimit = independentValues.Count;
            }
            else
            {
                maxLimit = int.Parse(limitTextBox.Text);
            }

            if(xFileExist && yFileExist)
            {
                calculateButton.Enabled = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            independentValues.Clear();
            dependentValues.Clear();

            xFileExist = false;
            yFileExist = false;

            calculateButton.Enabled = false;

            xLabel.Text = "File : Empty";
            yLabel.Text = "File : Empty";
        }
    }
}
