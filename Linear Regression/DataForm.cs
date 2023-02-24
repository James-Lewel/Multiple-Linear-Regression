using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Linear_Regression
{
    public partial class DataForm : Form
    {
        public DataForm(int limit, List<List<string>> values)
        {
            InitializeComponent();

            // Clears tables
            DataTable dataTable = new DataTable();

            dataTable.Clear();
            dataGridView.DataSource = null;

            // Add columns
            for (int i = 0; i < values[0].Count; i++)
            {
                dataTable.Columns.Add(values[0][i]);
            }

            // Add rows
            for (int i = 1; i < limit; i++)
            {
                DataRow dataRow = dataTable.NewRow();

                for(int j = 0; j < values[0].Count; j++)
                    dataRow[values[0][j]] = values[i][j];

                dataTable.Rows.Add(dataRow);
            }

            dataGridView.DataSource = dataTable;
        }

        private void DataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
