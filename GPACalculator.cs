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
    public partial class GPACalculator : Form
    {
        public GPACalculator()
        {
            InitializeComponent();
        }

        int coursesAdded = 0;

        List<int> gradePoints = new List<int>();
        List<string> gradeMarks = new List<string>();
        List<Course> courses = new List<Course>();

        string main = "main";
        string creditHoursTxt = "creditHoursTxt";

        int[] sizes = { 127, 222, 309, 390, 474, 557, 639, 725, 816 };

        Label[] classes;


        string[] marks = { "F", "D-", "D", "D+", "C-", "C", "C+", "B-", "B", "B+", "A-", "A" };

        private string ReadFile(string file)
        {
            using (StreamReader readText = new StreamReader("Data\\" + file + ".txt"))
            {
                return readText.ReadLine();
            }
        }

        private void WriteFile(string s, string file)
        {
            using (StreamWriter writetext = new StreamWriter("Data\\" + file + ".txt"))
            {
                writetext.WriteLine(s);
            }
        }


        private void GPACalculator_Load(object sender, EventArgs e)
        {
            txtGrade.SelectedIndex = 0;

            this.Height = sizes[coursesAdded];

            classes = new Label[8] {lblClass1, lblClass2, lblClass3, lblClass4,
            lblClass5, lblClass6, lblClass7, lblClass8};
            Label[] grades = new Label[8] {lblGrades1, lblGrades2, lblGrades3, lblGrades4,
            lblGrades5, lblGrades6, lblGrades7, lblGrades8};
            TrackBar[] bars = new TrackBar[8] {barClass1, barClass2, barClass3, barClass4,
            barClass5, barClass6, barClass7, barClass8};
            Button[] deleteButtons = new Button[8] {btnDeleteClass1, btnDeleteClass2, btnDeleteClass3, btnDeleteClass4,
            btnDeleteClass5, btnDeleteClass6, btnDeleteClass7, btnDeleteClass8};

            string[] s = ReadFile(main).Split(':');
            int count = 0;

            try
            {
                string chFile = ReadFile(creditHoursTxt);
                string[] CHs = chFile.Split(':');

                foreach (string ch in CHs)
                {
                    gradePoints.Add(Convert.ToInt32(ch));
                    count++;
                }
            }
            catch (Exception)
            {
                WriteFile("", creditHoursTxt);
            }

            if (count < 1)
            {
                WriteFile("", creditHoursTxt);
            }
            
            foreach (string str in s)
            {
                if (str.Length > 0)
                {
                    Course c = new Course(str, "A", 3);

                    AddCourse(c);
                }
            }
        }

        private void UpdateGPA()
        {
            double[] points = {0.0, 0.0, 1.0, 1.3, 1.7, 2.0, 2.3, 2.7, 3.0,
                3.3, 3.7, 4.0};

            double totalGPAs = 0;
            int totalGradePoints = 0;
            for (int i = 0; i < gradePoints.Count; i++)
            {
                totalGradePoints += gradePoints[i];
                for (int j = 0; j < marks.Length; j++)
                {
                    if (marks[j].Equals(gradeMarks[i]))
                    {
                        totalGPAs += (points[j] * gradePoints[i]);
                    }
                }
            }

            double overallGPA = Math.Round((totalGPAs / Convert.ToDouble(totalGradePoints)), 2);
            if (coursesAdded == 0)
                lblTotalGPA.Text = "No GPA.";
            else
                lblTotalGPA.Text = "Your GPA: " + overallGPA.ToString();

        }

        private void AddCourse(Course c)
        {
            classes = new Label[8] {lblClass1, lblClass2, lblClass3, lblClass4,
            lblClass5, lblClass6, lblClass7, lblClass8};
            Label[] grades = new Label[8] {lblGrades1, lblGrades2, lblGrades3, lblGrades4,
            lblGrades5, lblGrades6, lblGrades7, lblGrades8};
            TrackBar[] bars = new TrackBar[8] {barClass1, barClass2, barClass3, barClass4,
            barClass5, barClass6, barClass7, barClass8};
            Button[] deleteButtons = new Button[8] {btnDeleteClass1, btnDeleteClass2, btnDeleteClass3, btnDeleteClass4,
            btnDeleteClass5, btnDeleteClass6, btnDeleteClass7, btnDeleteClass8};

            classes[coursesAdded].Visible = true;
            classes[coursesAdded].Text = "Class: " + c.Name + "           Credit Hours: " + c.CreditHours.ToString();


            grades[coursesAdded].Visible = true;
            bars[coursesAdded].Visible = true;
            deleteButtons[coursesAdded].Visible = true;

            courses.Add(c);


            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i].Equals(c.GPA))
                {
                    bars[coursesAdded].Value = i;
                }
            }

            gradePoints.Add(c.CreditHours);
            gradeMarks.Add(c.GPA);

            coursesAdded++;
            UpdateGPA();

            this.Height = sizes[coursesAdded];

            string[] CHs = ReadFile(creditHoursTxt).Split(':');
            string output = "";

            foreach (string ch in CHs)
            {
                if (ch.Length > 0)
                    output += ":" + ch;
            }

            output += ":" + c.CreditHours.ToString();

            WriteFile(output, creditHoursTxt);

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (coursesAdded < 8)
            {
                classes = new Label[8] {lblClass1, lblClass2, lblClass3, lblClass4,
            lblClass5, lblClass6, lblClass7, lblClass8};
                Label[] grades = new Label[8] {lblGrades1, lblGrades2, lblGrades3, lblGrades4,
            lblGrades5, lblGrades6, lblGrades7, lblGrades8};
                TrackBar[] bars = new TrackBar[8] {barClass1, barClass2, barClass3, barClass4,
            barClass5, barClass6, barClass7, barClass8};
                Button[] deleteButtons = new Button[8] {btnDeleteClass1, btnDeleteClass2, btnDeleteClass3, btnDeleteClass4,
            btnDeleteClass5, btnDeleteClass6, btnDeleteClass7, btnDeleteClass8};

//                try
//                {
                    string name = txtCourseName.Text;
                    string GPA = Convert.ToString(txtGrade.SelectedItem);
                    int creditHours = Convert.ToInt32(txtCreditHours.Text);


                    Course course = new CourseGradebook.Course(name, GPA, creditHours);

                    AddCourse(course);

                    txtGrade.SelectedIndex = 0;
                    txtCourseName.Text = "";
                    txtCourseName.Focus();
                    txtCreditHours.Text = "";
                    this.Height = sizes[coursesAdded];

                    WriteFile((ReadFile(main) + ":" + name), main);




//                }
//                catch (Exception)
//                {
//                    MessageBox.Show("Please enter a valid course.wewe");
//                }
            }
            else
                MessageBox.Show("Maximum of 8 courses.");

        }

        private void barClass1_Scroll(object sender, EventArgs e)
        {
            gradeMarks[0] = marks[barClass1.Value];
            UpdateGPA();
        }

        private void barClass2_Scroll(object sender, EventArgs e)
        {
            gradeMarks[1] = marks[barClass2.Value];
            UpdateGPA();
        }

        private void barClass3_Scroll(object sender, EventArgs e)
        {
            gradeMarks[2] = marks[barClass3.Value];
            UpdateGPA();
        }

        private void barClass4_Scroll(object sender, EventArgs e)
        {
            gradeMarks[3] = marks[barClass4.Value];
            UpdateGPA();
        }

        private void barClass5_Scroll(object sender, EventArgs e)
        {
            gradeMarks[4] = marks[barClass5.Value];
            UpdateGPA();
        }

        private void barClass6_Scroll(object sender, EventArgs e)
        {
            gradeMarks[5] = marks[barClass6.Value];
            UpdateGPA();
        }

        private void barClass7_Scroll(object sender, EventArgs e)
        {
            gradeMarks[6] = marks[barClass7.Value];
            UpdateGPA();
        }

        private void barClass8_Scroll(object sender, EventArgs e)
        {
            gradeMarks[7] = marks[barClass8.Value];
            UpdateGPA();
        }

        private void EraseInList(int n)
        {
            classes = new Label[8] {lblClass1, lblClass2, lblClass3, lblClass4,
            lblClass5, lblClass6, lblClass7, lblClass8};
            Label[] grades = new Label[8] {lblGrades1, lblGrades2, lblGrades3, lblGrades4,
            lblGrades5, lblGrades6, lblGrades7, lblGrades8};
            TrackBar[] bars = new TrackBar[8] {barClass1, barClass2, barClass3, barClass4,
            barClass5, barClass6, barClass7, barClass8};
            Button[] deleteButtons = new Button[8] {btnDeleteClass1, btnDeleteClass2, btnDeleteClass3, btnDeleteClass4,
            btnDeleteClass5, btnDeleteClass6, btnDeleteClass7, btnDeleteClass8};

            List<int> locP = new List<int>();
            List<string> locM = new List<string>();

            string[] CHs = ReadFile(creditHoursTxt).Split(':');
            string output = "";

            for (int i = 0; i < courses.Count; i++)
            {
                if (i != n)
                {
                    output += ":" + courses[i].CreditHours;
                }
            }

            WriteFile(output, creditHoursTxt);

            string[] mainStrings = ReadFile(main).Split(':');
            string newString = "";

            foreach (string s in mainStrings)
            {
                if (!(s.Equals(courses[n].Name)))
                {
                    newString += ":" + s;
                }
            }

            WriteFile(newString, main);

            for (int i = 0; i < gradeMarks.Count; i++)
            {
                if (!(i == n))
                {
                    locP.Add(gradePoints[i]);
                    locM.Add(gradeMarks[i]);
                }
            }
            
            coursesAdded--;

            grades[coursesAdded].Visible = false;
            bars[coursesAdded].Visible = false;
            deleteButtons[coursesAdded].Visible = false;
            classes[coursesAdded].Visible = false;

            courses.RemoveAt(n);

            gradePoints = locP;
            gradeMarks = locM;

            for (int i = 0; i < coursesAdded; i++)
            {
                classes[i].Text = "Class: " + courses[i].Name + "           Credit Hours: " + courses[i].CreditHours.ToString();

                for (int j = 0; j < marks.Length; j++)
                {
                    if (marks[j].Equals(gradeMarks[i]))
                    {
                        bars[i].Value = j;
                    }
                }

            }

            

            UpdateGPA();
            this.Height = sizes[coursesAdded];

        }


        private void btnDeleteClass1_Click(object sender, EventArgs e)
        {
            EraseInList(0);
        }

        private void btnDeleteClass2_Click(object sender, EventArgs e)
        {
            EraseInList(1);
        }

        private void btnDeleteClass3_Click(object sender, EventArgs e)
        {
            EraseInList(2);
        }

        private void btnDeleteClass4_Click(object sender, EventArgs e)
        {
            EraseInList(3);
        }

        private void btnDeleteClass5_Click(object sender, EventArgs e)
        {
            EraseInList(4);
        }

        private void btnDeleteClass6_Click(object sender, EventArgs e)
        {
            EraseInList(5);
        }

        private void btnDeleteClass7_Click(object sender, EventArgs e)
        {
            EraseInList(6);
        }

        private void btnDeleteClass8_Click(object sender, EventArgs e)
        {
            EraseInList(7);
        }

        private int ChangeCreditHours(int c)
        {
            int i = (courses[c].CreditHours + 1);
            if (i > 4)
                i = 1;
            gradePoints[c] = i;
            courses[c].CreditHours = i;
            classes[c].Text = "Class: " + courses[c].Name + "           Credit Hours: " + courses[c].CreditHours.ToString();

            string[] CHs = ReadFile(creditHoursTxt).Split(':');
            string output = "";

            for (int k = 0; k < coursesAdded; k++)
            {
                if (k == c)
                    output += ":" + i.ToString();
                else
                    output += ":" + CHs[k];
            }

            WriteFile(output, creditHoursTxt);

            UpdateGPA();
            return i;
        }

        private void lblClass1_Click(object sender, EventArgs e)
        {
            ChangeCreditHours(0);
        }

        private void lblClass2_Click(object sender, EventArgs e)
        {
            ChangeCreditHours(1);
        }

        private void lblClass3_Click(object sender, EventArgs e)
        {
            ChangeCreditHours(2);
        }

        private void lblClass4_Click(object sender, EventArgs e)
        {
            ChangeCreditHours(3);
        }

        private void lblClass5_Click(object sender, EventArgs e)
        {
            ChangeCreditHours(4);
        }

        private void lblClass6_Click(object sender, EventArgs e)
        {
            ChangeCreditHours(5);
        }

        private void lblClass7_Click(object sender, EventArgs e)
        {
            ChangeCreditHours(6);
        }

        private void lblClass8_Click(object sender, EventArgs e)
        {
            ChangeCreditHours(7);
        }
    }
}