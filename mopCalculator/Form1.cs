using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mopCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = txtBoxInput.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Моля, въведете поне едно число в текстовото поле.");
                return;
            }

            List<double> numbers = input.Split(' ').Select(double.Parse).ToList();

            if (numbers.Count == 0)
            {
                MessageBox.Show("Моля, въведете поне едно число.");
                return;
            }

            double mode = numbers.GroupBy(n => n).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
            double average = numbers.Average();
            double median = CalculateMedian(numbers);


            if (!checkMode.Checked && !checkAverage.Checked && !checkMedian.Checked)
            {
                MessageBox.Show("Моля, изберете поне един Check Box.");
                return;
            }

            DisplayChart(mode, average, median);
        }

        private double CalculateMedian(List<double> numbers)
        {
            int count = numbers.Count;
            var sortedNumbers = numbers.OrderBy(n => n).ToList();

            if (count % 2 == 0)
            {
                int middleIndex = count / 2;
                return (sortedNumbers[middleIndex - 1] + sortedNumbers[middleIndex]) / 2.0;
            }
            else
            {
                return sortedNumbers[count / 2];
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxInput.Clear();
            TestChart.Series.Clear();
        }

        private void DisplayChart(double mode, double average, double median)
        {
            TestChart.Series.Clear();

            if (checkMode.Checked)
            {
                TestChart.Series.Add("Mode").Points.AddY(mode);
            }

            if (checkAverage.Checked)
            {
                TestChart.Series.Add("Average").Points.AddY(average);
            }

            if (checkMedian.Checked)
            {
                TestChart.Series.Add("Median").Points.AddY(median);
            }
        }
    }
}
