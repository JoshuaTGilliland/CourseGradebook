using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradebook
{
    public partial class MinimumGradeCalculator : Form
    {
        public double Numerator { get; set; }
        public double Denominator { get; set; }

        public MinimumGradeCalculator(double num, double den)
        {
            InitializeComponent();
            this.Numerator = num;
            this.Denominator = den;
        }

        private void MinimumGradeCalculator_Load(object sender, EventArgs e)
        {
            double Percentage = Math.Round((Numerator / Denominator), 2) * 100;

            lblCurrentPercentage.Text += Percentage.ToString() + "%";
            lblCurrentTotalPoints.Text += Numerator.ToString() + " / " + Denominator.ToString();

        }

        // TO DO: Solve math issue.

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double LowestFinalGradeDesired = Convert.ToDouble(txtLowestFinalGradeDesired.Text) / 100;
                double PointsInNextAssignment = Convert.ToDouble(txtPointsInNextAssignment.Text) + Denominator;
                
                double Total = PointsInNextAssignment * LowestFinalGradeDesired;

                Total -= Numerator;

                Total = Math.Round((Total / Convert.ToDouble(txtPointsInNextAssignment.Text)), 2) * 100;



                txtAnswer.Text = "You must get at least a " + Total.ToString() + "% on your next assignment to achieve a " + LowestFinalGradeDesired.ToString() + ".";
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter applicable values into text areas.");

            }
        }

        private void btnDetailedReport_Click(object sender, EventArgs e)
        {
            try
            {
                double LowestFinalGradeDesired = Convert.ToDouble(txtLowestFinalGradeDesired.Text) / 100;
                double PointsInNextAssignment = Convert.ToDouble(txtPointsInNextAssignment.Text) + Denominator;

                List<double> vals = new List<double>();
                
                for (double i = 0; i < 1.01; i += 0.05)
                    vals.Add(i);

                string printedOutcome = "% on that assignment  --> total grade\n\n";

                double outcome;
                

                foreach (double d in vals)
                {
                    double Total = d * Convert.ToDouble(txtPointsInNextAssignment.Text) + Numerator;
                    outcome = Math.Round((Total / PointsInNextAssignment), 2) * 100;
                    printedOutcome += (Math.Round(d, 2)*100).ToString() + "%   -->   " + outcome.ToString() + "%\n";
                }

                MessageBox.Show(printedOutcome);


            }
            catch (Exception)
            {
                MessageBox.Show("Please enter applicable values into text areas.");
            }
        }
    }
}
