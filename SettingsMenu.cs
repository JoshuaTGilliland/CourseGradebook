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

namespace CourseGradebook
{
    public partial class SettingsMenu : Form
    {

        public string FileName { get; set; }

        public SettingsMenu()
        {
            InitializeComponent();
        }

        public SettingsMenu(string name)
        {
            InitializeComponent();
            this.FileName = name;
            this.Text = FileName + " Settings";
        }

        List<int> defaultGrades = new List<int> {93, 89, 86, 82, 79, 76, 72, 69, 66, 62, 59, -1};

        public string ReadFile()
        {
            using (StreamReader readText = new StreamReader("Data\\" + FileName + "GradeParameters.txt"))
            {
                return readText.ReadLine();
            }
        }

        public void WriteFile(string s)
        {
            using (StreamWriter writetext = new StreamWriter("Data\\" + FileName + "GradeParameters.txt"))
            {
                writetext.WriteLine(s);
            }
        }

        private void SettingsMenu_Load_1(object sender, EventArgs e)
        {
            List<TextBox> txts = new List<TextBox> { txtA1, txtAm1, txtBp1, txtB1, txtBm1,
                txtCp1, txtC1, txtCm1, txtDp1, txtD1, txtDm1, txtF1 };
            try
            {
                string file = ReadFile();
                int j = 0;

                foreach (string s in file.Split(':'))
                {
                if (s.Length > 0)
                {
                    txts.ElementAt(j).Text = (Convert.ToInt32(s) + 1).ToString();
                    j++;
                }
                }

                txtF2.Text = ((Convert.ToDouble(file.Split(':')[10])) + 0.9).ToString();
        }

            catch (Exception)
            {
                string s = "";
                
                int j = 0;
                foreach (int i in defaultGrades)
                {
                    txts.ElementAt(j).Text = (i + 1).ToString();
                    s += i.ToString() + ":";
                    txtF2.Text = (Convert.ToDouble(defaultGrades[10] + 1) - 0.1).ToString();
                    j++;
                }

                WriteFile(s);

          }
       }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string NewParameter = "";
            List<string> txts = new List<string> { txtA1.Text, txtAm1.Text, txtBp1.Text, txtB1.Text, txtBm1.Text,
                txtCp1.Text, txtC1.Text, txtCm1.Text, txtDp1.Text, txtD1.Text, txtDm1.Text, txtF1.Text };

            bool Done = false;

            foreach (string s in txts)
            {
                try
                {
                    NewParameter += (Convert.ToInt32(s) - 1) + ":";
                    Done = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter numbers only.");
                }
            }

            if (Done)
            {
                WriteFile(NewParameter);
                MessageBox.Show("New grade paramters saved!");
            }

        }
        
        private void txtAm1_TextChanged(object sender, EventArgs e)
        {
            if (txtAm1.Text.Length > 1)
            {
                txtBp2.Text = (Convert.ToDouble(txtAm1.Text) - 0.1).ToString();
            }
            else
                txtBp2.Text = "";
        }

        private void txtBp1_TextChanged(object sender, EventArgs e)
        {
            if (txtBp1.Text.Length > 1)
            {
                txtB2.Text = (Convert.ToDouble(txtBp1.Text) - 0.1).ToString();
            }
            else
                txtB2.Text = "";
        }

        private void txtB1_TextChanged(object sender, EventArgs e)
        {
            if (txtB1.Text.Length > 1)
            {
                txtBm2.Text = (Convert.ToDouble(txtB1.Text) - 0.1).ToString();
            }
            else
                txtBm2.Text = "";
        }

        private void txtBm1_TextChanged(object sender, EventArgs e)
        {
            if (txtBm1.Text.Length > 1)
            {
                txtCp2.Text = (Convert.ToDouble(txtBm1.Text) - 0.1).ToString();
            }
            else
                txtCp2.Text = "";
        }

        private void txtCp1_TextChanged(object sender, EventArgs e)
        {
            if (txtCp1.Text.Length > 1)
            {
                txtC2.Text = (Convert.ToDouble(txtCp1.Text) - 0.1).ToString();
            }
            else
                txtC2.Text = "";
        }

        private void txtC1_TextChanged(object sender, EventArgs e)
        {
            if (txtC1.Text.Length > 1)
            {
                txtCm2.Text = (Convert.ToDouble(txtC1.Text) - 0.1).ToString();
            }
            else
                txtCm2.Text = "";
        }

        private void txtCm1_TextChanged(object sender, EventArgs e)
        {
            if (txtCm1.Text.Length > 1)
            {
                txtDp2.Text = (Convert.ToDouble(txtCm1.Text) - 0.1).ToString();
            }
            else
                txtDp2.Text = "";
        }

        private void txtDp1_TextChanged(object sender, EventArgs e)
        {
            if (txtDp1.Text.Length > 1)
            {
                txtD2.Text = (Convert.ToDouble(txtDp1.Text) - 0.1).ToString();
            }
            else
                txtD2.Text = "";
        }

        private void txtD1_TextChanged(object sender, EventArgs e)
        {
            if (txtD1.Text.Length > 1)
            {
                txtDm2.Text = (Convert.ToDouble(txtD1.Text) - 0.1).ToString();
            }
            else
                txtDm2.Text = "";
        }

        private void txtDm1_TextChanged(object sender, EventArgs e)
        {
            if (txtDm1.Text.Length > 1)
            {
                txtF2.Text = (Convert.ToDouble(txtDm1.Text) - 0.1).ToString();
            }
            else
                txtF2.Text = "";
        }

        private void txtA1_TextChanged(object sender, EventArgs e)
        {
            if (txtA1.Text.Length > 1)
            {
                txtAm2.Text = (Convert.ToDouble(txtA1.Text) - 0.1).ToString();
            }
            else
                txtAm2.Text = "";
        }
    }
}


/*
 * Default Grade Parameters:
 * 
 * A: 94-100
 * A-: 90 - 93.9
 * B+: 87-89.9
 * B: 83-86.9
 * B-: 80-82.9
 * C+: 77-79.9
 * C: 73-76.9
 * C-: 70-72.9
 * D+: 67-69.9
 * D: 63-66.9
 * D-: 60-61.9
 * F: 0-59.9
 * 
 */
