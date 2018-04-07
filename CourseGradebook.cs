using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CourseGradebook;

namespace HumanitiesGradebook
{
    public partial class CourseGradebook : Form
    {

        public string CurrentFile { get; set; }

        public CourseGradebook(string CurrentFile)
        {
            InitializeComponent();
            this.CurrentFile = CurrentFile;
            
        }
        
        List<double> Grades = new List<double>();
        List<int> Parameters = new List<int>();

        bool LowFat = false;

        double MainNumerator = 93;
        double MainDenominator = 100;

        public void CourseGradebook_Load(object sender, EventArgs e)
        {

            UpdateParameters();

            try
            {
                using (StreamReader readText = new StreamReader("Data\\" + CurrentFile + ".txt"))
                {
                    string txt = readText.ReadLine();
                    foreach (string s in txt.Split(':'))
                    {
                        if (s.Length > 0)
                        {
                            double locNum = Convert.ToDouble(s.Split('-').ElementAt(0));
                            double locDen = Convert.ToDouble(s.Split('-').ElementAt(1));
                            Grades.Add(locNum);
                            Grades.Add(locDen);
                        }
                    }

                    double o = 0;
                    double t = 0;
                    for (int i = 10; i < Grades.Count + 10; i++)
                    {
                        if (i % 2 == 0)
                        {
                            o = Grades.ElementAt(i - 10);
                        }
                        else if (i % 2 == 1)
                        {
                            t = Grades.ElementAt(i - 10);
                            double Percentage = o / t * 100;

                            lstGrades.Items.Add(o.ToString() + " / " + t.ToString() + "   " + CalculateMark(Percentage));
                        }
                    }

                    if (txt.Length < 1)
                    {
                        Visibility(false);
                    }

                }
                UpdateGrades(chkDropLowest.Checked);
            }
            catch (Exception)
            {
                WriteFile("");


                Visibility(false);
            }
        }

        // TO ADD:
        // Add 'weighted' option with corresponding parameters.

        // TO FIX:
        // Fix Lowest Grade -> find lowest PERCENTAGE, not NUMERATOR

        private void Visibility(bool b)
        {
            lstGrades.Visible = b;
            lblGradePercentage.Visible = b;
            lblTotalGrade.Visible = b;
            btnDelete.Visible = b;
            btnMinGrade.Visible = b;
            btnSettings.Visible = b;
            chkDropLowest.Visible = b;
        }

        // FIX PERCENTAGE

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double num = Convert.ToDouble(txtNumerator.Text);
                double den = Convert.ToDouble(txtDenominator.Text);
                int per = Convert.ToInt32(txtPercentageOfCourse.Text);

                txtNumerator.Text = "";
                txtDenominator.Text = "";

                double Percentage = num / den * 100;

                lstGrades.Items.Add(num.ToString() + " / " + den.ToString() + "   " + CalculateMark(Percentage));

                Grades.Add(num);
                Grades.Add(den);

                string str = ReadFile();
                WriteFile(str + (num.ToString() + "-" + den.ToString() + ":"));
                UpdateGrades(chkDropLowest.Checked);

                Visibility(true);
            }
            catch (Exception)
            {
                MessageBox.Show("Please input numerical values for the grades.");
            }
            txtNumerator.Focus();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = lstGrades.Items.Count - 1; i >= 0; i--)
            {
                if (lstGrades.GetItemCheckState(i).ToString().Equals("Checked"))
                {
                    lstGrades.Items.RemoveAt(i);
                    Grades.RemoveAt(i * 2);
                    Grades.RemoveAt(i * 2);

                }
            }

            string s = "";

            List<string> vals = new List<string>(2);
            vals.Add("-");
            vals.Add(":");
            int j = 0;

            foreach (int i in Grades)
            {
                s += i.ToString() + vals.ElementAt(j).ToString();

                if (j == 0)
                    j = 1;
                else
                    j = 0;
            }

            WriteFile(s);
            UpdateGrades(chkDropLowest.Checked);
        }

        private int FindLowestGrade()
        {
            double lowest = 1000;
            int index = 0;
            int lowestIndex = -1;
            for (int i = 0; i < Grades.Count; i += 2)
            {
                if (Grades[i] < lowest)
                {
                    lowestIndex = index;
                    lowest = Grades[i];
                }
                index++;
            }

            return lowestIndex;
        }

        private string CalculateMark(double p)
        {
            string mark = "Undetermined.";

            if (p > Parameters.ElementAt(0))
                mark = "A";
            else if (p > Parameters.ElementAt(1))
                mark = "A-";
            else if (p > Parameters.ElementAt(2))
                mark = "B+";
            else if (p > Parameters.ElementAt(3))
                mark = "B";
            else if (p > Parameters.ElementAt(4))
                mark = "B-";
            else if (p > Parameters.ElementAt(5))
                mark = "C+";
            else if (p > Parameters.ElementAt(6))
                mark = "C";
            else if (p > Parameters.ElementAt(7))
                mark = "C-";
            else if (p > Parameters.ElementAt(8))
                mark = "D+";
            else if (p > Parameters.ElementAt(9))
                mark = "D";
            else if (p > Parameters.ElementAt(10))
                mark = "D-";
            else if (p > Parameters.ElementAt(11))
                mark = "F";
            else
                mark = "N/A.";

            return mark;
        }

        public void UpdateGrades(bool droppingLowest)
        {
            if (Grades.Count > 0)
            {

                double PointsEarned = 0;
                double TotalPoints = 0;
                double Percentage;

                int lowest = FindLowestGrade();

                for (int i = 2; i < Grades.Count + 2; i++)
                {
                    if (i % 2 == 0)
                    {
                        PointsEarned += Grades.ElementAt(i - 2);
                    }
                    else if (i % 2 == 1)
                    {
                        TotalPoints += Grades.ElementAt(i - 2);
                    }
                }

                if (droppingLowest)
                {
                    PointsEarned -= Grades[lowest * 2];
                    TotalPoints -= Grades[(lowest * 2) + 1];
                }


                Percentage = PointsEarned / TotalPoints;
                Percentage = (Math.Round(Percentage, 2) * 100);

                string mark = CalculateMark(Percentage);


                lblTotalGrade.Text = "Your total points: " + PointsEarned.ToString() + " / " + TotalPoints.ToString();
                lblGradePercentage.Text = "Your grade: " + Percentage.ToString() + "% --> " + mark;

                MainNumerator = PointsEarned;
                MainDenominator = TotalPoints;
            }
            else
            {
                lblTotalGrade.Text = "Your total points: ";
                lblGradePercentage.Text = "Your grade: ";
            }
        }

        public string ReadFile()
        {
            using (StreamReader readText = new StreamReader("Data\\" + CurrentFile + ".txt"))
            {
                return readText.ReadLine();
            }
        }

        public string ReadFile(string fn)
        {
            using (StreamReader readText = new StreamReader("Data\\" + fn))
            {
                return readText.ReadLine();
            }
        }

        public void WriteFile(string s)
        {
            using (StreamWriter writetext = new StreamWriter("Data\\" + CurrentFile + ".txt"))
            {
                writetext.WriteLine(s);
            }
        }

        public void WriteFile(string name, string s)
        {
            using (StreamWriter writetext = new StreamWriter("Data\\" + name + "GradeParameters.txt"))
            {
                writetext.WriteLine(s);
            }
        }

        private void chkDropLowest_CheckedChanged(object sender, EventArgs e)
        {
            if (lstGrades.Items.Count > 1)
                UpdateGrades(chkDropLowest.Checked);
        }

        public void UpdateParameters()
        {
            Parameters.Clear();

            try
            {
                string strParameters = ReadFile(CurrentFile + "GradeParameters.txt");
                foreach (string s in strParameters.Split(':'))
                {
                    if (s.ToString().Length > 0)
                        Parameters.Add(Convert.ToInt32(s));
                }

            }

            catch (Exception)
            {
                Parameters = new List<int> { 93, 89, 86, 82, 79, 76, 72, 69, 66, 62, 59, -1 };

                string par = "";
                

                foreach (int k in Parameters)
                {
                    par += (k.ToString() + ":");
                }
                WriteFile(CurrentFile, par);
            }
        }

        public void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsMenu set = new SettingsMenu(CurrentFile);
            this.Hide();
            set.ShowDialog();
            this.Show();
            UpdateParameters();
            UpdateGrades(chkDropLowest.Checked);

            lstGrades.Items.Clear();

            for (int i = 0; i < Grades.Count; i += 2)
            {
                double Percentage = Grades[i] / Grades[i+1] * 100;
                lstGrades.Items.Add(Grades[i].ToString() + " / " + Grades[i+1].ToString() + "   " + CalculateMark(Percentage));
            }

        }

        private void btnMinGrade_Click(object sender, EventArgs e)
        {
            MinimumGradeCalculator calc = new MinimumGradeCalculator(MainNumerator, MainDenominator);
            this.Hide();
            calc.ShowDialog();
            this.Show();
        }
        
    }
}