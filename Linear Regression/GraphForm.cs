using MathNet.Numerics.LinearRegression;
using MathNet.Numerics.LinearAlgebra;
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

        double sumOfY;
        double[] sumOfX;

        double[,] xArray1;
        double[,] xArray2;
        double[] yArray;

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

            sumOfY = 0;
            sumOfX = new double[xCount];

            xArray1 = new double[maxLimit, xCount];
            xArray2 = new double[xCount, maxLimit];
            yArray = new double[maxLimit];

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
                    series[i].Points.AddXY(xArray2[i, j], yArray[j]);
                }
            }
        }

        private void calculateRegression()
        {
            // Transfers list to array
            for (int i = 1; i <= maxLimit; i++)
            {
                for (int j = 0; j < xCount; j++)
                {
                    xArray1[i - 1, j] = double.Parse(independentValues[i][j]);
                    //sumOfX[i] += xValues[i, j - 1];
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

            /*// Calculates the sum of x^2 and xy
            for (int i = 0; i < xCount; i++)
            {
                for (int j = 0; j < maxLimit; j++)
                {
                    sumOfXSquared[i] += Math.Pow(xValues[i, j], 2);
                    sumOfXY[i] += xValues[i, j] * yValues[j];
                }
            }*/

            if (xCount > 0)
            {
                calculateMLR();
            }
            else
            {
                calculateLR();
            }
        }

        private void calculateMLR()
        {
            Matrix<double> x = Matrix<double>.Build.DenseOfArray(xArray1);
            Vector<double> y = Vector<double>.Build.DenseOfArray(yArray);
            Vector<double> b = (x.Transpose() * x).Inverse() * x.Transpose() * y;

            double b0 = (sumOfY / maxLimit) - (b[0] * sumOfX[0] / maxLimit) - (b[1] * sumOfX[1] / maxLimit) - (b[2] * sumOfX[2] / maxLimit);
            MessageBox.Show("Coeffecient = " + sumOfY + "\nB1 = " + b[0] + "\nB2 = " + b[1] + "\nB3 = " + b[2]);
        }

        private void calculateLR()
        {

        }
    }
}
