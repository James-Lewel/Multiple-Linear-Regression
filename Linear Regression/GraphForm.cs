using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Linear_Regression
{
    public partial class GraphForm : Form
    {
        Series[] series;

        List<List<string>> independentValues;
        List<List<string>> dependentValues;
        
        int maxLimit;
        int xCount;
        int yCount;

        double[,] xValues;
        double[] yValues; 

        double[] sumOfX;
        double[] sumOfXSquared;
        double[] sumOfXY;

        double a;
        double[] b;

        public GraphForm(List<List<string>> independentValues, List<List<string>> dependentValues, int maxLimit)
        {
            InitializeComponent();

            this.independentValues = independentValues;
            this.dependentValues = dependentValues;
            this.maxLimit = maxLimit;

            initSeries();
            initValues();

            calculateRegression();

            drawSeries();
        }

        private void initSeries()
        {
            // Clears chart
            chart.Series.Clear();

            Random random = new Random();
            series = new Series[independentValues[0].Count];

            // Adds and initialize series
            for (int i = 0; i < independentValues[0].Count; i++)
            {
                series[i] = chart.Series.Add(independentValues[0][i] + " + " + dependentValues[0][0]);
                series[i].Name = independentValues[0][i] + " + " + dependentValues[0][0];
                series[i].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                series[i].ChartType = SeriesChartType.Point;
            }
        }

        private void initValues()
        {
            xCount = independentValues[0].Count;
            yCount = dependentValues[0].Count;

            xValues = new double[xCount, maxLimit];
            yValues = new double[maxLimit];

            sumOfX = new double[xCount];
            sumOfXSquared = new double[xCount];
            sumOfXY = new double[xCount];

            a = 0;
            b = new double[xCount];
        }

        private void drawSeries()
        {
            // Plots values to graph
            for (int i = 0; i < xCount; i++)
            {
                for (int j = 0; j < maxLimit; j++)
                {
                    series[i].Points.AddXY(xValues[i, j], yValues[j]);
                }
            }
        }

        private void calculateRegression()
        {

            // Transfers list to array
            for (int i = 0; i < xCount; i++)
            {
                for (int j = 1; j <= maxLimit; j++)
                {
                    xValues[i, j - 1] = double.Parse(independentValues[j][i]);
                }
            }

            // Transfers list to array
            for (int i = 0; i < yCount; i++)
            {
                for (int j = 1; j <= maxLimit; j++)
                {
                    yValues[j - 1] = double.Parse(dependentValues[j][i]);
                }
            }

            // Calculates the sum of x, x^2 and xy
            for (int i = 0; i < xCount; i++)
            {
                for (int j = 0; j < maxLimit; j++)
                {
                    sumOfX[i] += xValues[i, j];
                    sumOfXSquared[i] += Math.Pow(xValues[i, j], 2);
                    sumOfXY[i] += xValues[i, j] * yValues[j];
                }
            }
        }
     }
}
