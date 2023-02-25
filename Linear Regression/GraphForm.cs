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

        Matrix<double> x;
        Vector<double> y;
        Vector<double> b;
        double b0;
        double a;

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
                //calculateMLR();
            }
            else
            {
                //calculateLR();
            }
        }

        private void calculateMLR()
        {
            x = Matrix<double>.Build.DenseOfArray(xArray1);
            y = Vector<double>.Build.DenseOfArray(yArray);
            b = (x.Transpose() * x).Inverse() * x.Transpose() * y;

            b0 = (sumOfY / maxLimit);

            for(int i = 0; i < xCount; i++)
            {
                b0 += b[i] * (sumOfX[i] / maxLimit);
                //MessageBox.Show("B" + i + " = " + b[i]);
            }
        }

        private void calculateLR()
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string[] inputX = inputTextBox.Text.Split(',');
            double predictor = 227.5331948;

            // Add values here
            string[] inputCoefficient = textBox1.Text.Split(',');

            for (int i = 0; i < xCount; i++)
            {
                predictor += double.Parse(inputCoefficient[i]) * double.Parse(inputX[i]);
            }

            MessageBox.Show("Calories burned should be : " + predictor);
        }
    }
}
