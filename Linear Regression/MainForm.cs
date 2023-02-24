using System;
using System.Collections.Generic;
using System.Threading;
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

                    // List of included data
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
                        independentValues.Add(new List<string>());

                        tempCSV = rawCSV[i].Split(',');

                        for (int j = 0; j < tempCSV.Length; j++)
                        {
                            // Skips data
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

                    // List of included data
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
                            // Skips data
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
            if (string.IsNullOrEmpty(limitTextBox.Text))
                maxLimit = independentValues.Count;
            else
                maxLimit = int.Parse(limitTextBox.Text);

            if (independentValues.Count > 0 && dependentValues.Count > 0)
                dataButton.Enabled = true;

            uploadXButton.Enabled = false;
            uploadYButton.Enabled = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Clear values
            independentValues.Clear();
            dependentValues.Clear();
            limitTextBox.Clear();

            xFileExist = false;
            yFileExist = false;

            // Resets buttons
            uploadXButton.Enabled = true;
            uploadYButton.Enabled = true;

            dataButton.Enabled = false;

            // Resets labels
            xLabel.Text = "File : Empty";
            yLabel.Text = "File : Empty";
        }

        private void dataButton_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                DataForm independentDataForm = new DataForm(maxLimit, independentValues);
                independentDataForm.Text = "Independent Values";
                independentDataForm.ShowDialog();

                DataForm dependentDataForm = new DataForm(maxLimit, dependentValues);
                dependentDataForm.Text = "Dependent Values";
                dependentDataForm.ShowDialog();
            }).Start();
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            GraphForm graphForm = new GraphForm(independentValues, dependentValues, maxLimit);
            graphForm.ShowDialog();
        }
    }
}
