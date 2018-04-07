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

// Created by Joshua Gilliland
// Icon from icons8.com
// Version 1.1.3
// joshuatgilliland@gmail.com

namespace HumanitiesGradebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            this.CurrentFile = "";
            this.Visible = true;
        }

        public string CurrentFile { get; set; }
        string Version = "1.1.3";
        List<string> Files = new List<string>();


        private void btnGo_Click(object sender, EventArgs e)
        {
            if (lstCourses.SelectedItem != null)
            {
                CurrentFile = lstCourses.SelectedItem.ToString();

                CourseGradebook form = new CourseGradebook(CurrentFile);
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Please add a new course first.");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNewCourse.Text.Length > 0)
            {
                string newCourse = txtNewCourse.Text;
                txtNewCourse.Text = "";
                string s = ReadFile();
                WriteFile(s + ":" + newCourse);
                lstCourses.Items.Add(newCourse);

                if (lstCourses.Items.Count == 1)
                {
                    lstCourses.SelectedIndex = 0;
                }

                lblShowCourses.Visible = true;
                lstCourses.Visible = true;
                btnGo.Visible = true;

            }
        }

        private void LoadCourses(List<string> files)
        {
            try
            {
                lstCourses.Items.Clear();
                string file = ReadFile();

                if (file.Split(':').Length > 0)
                {

                    lstCourses.Visible = true;
                    btnGo.Visible = true;
                    lblShowCourses.Visible = true;
                }

                foreach (string s in file.Split(':'))
                {
                    if (s.Length > 0)
                    {
                        files.Add(s);
                        lstCourses.Items.Add(s);
                    }
                }

            }
            catch (Exception)
            {
                WriteFile("");
            }

            if (lstCourses.Items.Count < 1)
            {
                lblShowCourses.Visible = false;
                lstCourses.Visible = false;
                btnGo.Visible = false;
            }

        }

        public void Form1_Load(object sender, EventArgs e)
        {

            System.IO.Directory.CreateDirectory("Data\\");

            LoadCourses(Files);
            
        }
        
        private string ReadFile()
        {
            using (StreamReader readText = new StreamReader("Data\\main.txt"))
            {
                return readText.ReadLine();
            }
        }

        private void WriteFile(string s)
        {
            using (StreamWriter writetext = new StreamWriter("Data\\main.txt"))
            {
                writetext.WriteLine(s);
            }
        }
        

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Joshua Gilliland\nIcon from icons8.com (Creative Commons)\njoshuatgilliland@gmail.com\n\nVersion " + Version);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsMenu set = new SettingsMenu("Default");
            this.Hide();
            set.ShowDialog();
            this.Show();
        }

        private void btnGPACalculator_Click(object sender, EventArgs e)
        {
            GPACalculator gpa = new GPACalculator();
            this.Hide();
            gpa.ShowDialog();
            LoadCourses(Files);
            this.Show();
        }
    }
}

// 9-10:8-10:5-10