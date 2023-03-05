using MathNet.Numerics.LinearRegression;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics;

namespace Linear_Regression
{
    public partial class GraphForm : Form
    {
        System.Windows.Forms.DataVisualization.Charting.Series[] series;

        List<List<string>> independentValues;
        List<List<string>> dependentValues;

        int maxLimit;
        int xCount;
        int yCount;

        double sumOfY;
        double[] sumOfX;

        double[][] xArray1;
        double[,] xArray2;
        double[] yArray;
        double[] intercepts;

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
            series = new System.Windows.Forms.DataVisualization.Charting.Series[independentValues[0].Count];

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

            sumOfY = 0;
            sumOfX = new double[xCount];

            xArray1 = new double[maxLimit][];
            xArray2 = new double[xCount, maxLimit];

            yArray = new double[maxLimit];
        }

        private void drawSeries()
        {
            // Plots values to graph
            for (int i = 0; i < xCount; i++)
            {
                for (int j = 0; j < maxLimit; j++)
                {
                    series[i].Points.AddXY(xArray2[i, j], yArray[j]);
                }
            }
        }

        private void calculateRegression()
        {
            // Transfers list to array
            for (int i = 1; i <= maxLimit; i++)
            {
                xArray1[i - 1] = new double[xCount];
                for (int j = 0; j < xCount; j++)
                {
                    xArray1[i - 1][j] = double.Parse(independentValues[i][j]);
                }
            }

            // Transfers list to array
            for (int i = 0; i < xCount; i++)
            {
                for (int j = 1; j <= maxLimit; j++)
                {
                    xArray2[i, j - 1] = double.Parse(independentValues[j][i]);
                    sumOfX[i] += xArray2[i, j - 1];
                }
            }


            // Transfers list to array
            for (int i = 0; i < yCount; i++)
            {
                for (int j = 1; j <= maxLimit; j++)
                {
                    yArray[j - 1] = double.Parse(dependentValues[j][i]);
                    sumOfY += yArray[j - 1];
                }
            }
        }

        
        private void calculateMLR()
        {
            intercepts = Fit.MultiDim(xArray1, yArray, intercept: true);
        }

        private void calculateLR()
        {
            var M = Matrix<double>.Build;
            var V = Vector<double>.Build;

            List<double> xData = new List<double>();
            List<double> yData = new List<double>();

            foreach(var x in xArray2)
            {
                xData.Add(x);
            }

            foreach(var y in yArray)
            {
                yData.Add(y);
            }

            var X = M.DenseOfColumnVectors(V.Dense(xData.ToArray().Length, 1.0), V.Dense(xData.ToArray()));
            var Y = V.Dense(yData.ToArray());

            intercepts = X.QR().Solve(Y).ToArray();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string[] inputX = inputTextBox.Text.Split(',');

            double predict = 0;

            if (xCount > 1)
            {
                calculateMLR();

                predict = intercepts[0];
                for (int i = 0; i < xCount; i++)
                {
                    predict += intercepts[i + 1] * double.Parse(inputX[i]);
                }
            }
            else
            {
                calculateLR();

                predict = intercepts[0] + (intercepts[1] * double.Parse(inputX[0]));
            }


            MessageBox.Show("Criterion Variable : " + predict);
        }
    }
}
