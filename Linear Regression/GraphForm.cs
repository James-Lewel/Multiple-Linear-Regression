using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Linear_Regression
{
    public partial class GraphForm : Form
    {
        public GraphForm(List<List<string>> independentValues, List<List<string>> dependentValues, int limit)
        {
            InitializeComponent();

            Random random = new Random();

            chart.Series.Clear();
            Series [] series = new Series[independentValues[0].Count];

            // Adds and initialize series
            for(int i = 0; i < independentValues[0].Count; i++)
            {
                series[i] = chart.Series.Add(independentValues[0][i] + " + " + dependentValues[0][0]);
                series[i].Name = independentValues[0][i] + " + " + dependentValues[0][0];
                series[i].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                series[i].ChartType = SeriesChartType.Point;
            }

            // Plots values to graph
            for (int i = 1; i < limit; i++)
            {
                for (int j = 0; j < independentValues[0].Count; j++)
                    series[j].Points.AddXY(double.Parse(independentValues[i][j]), double.Parse(dependentValues[i][0]));
            }
        }
     }
}
