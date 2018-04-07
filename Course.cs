using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradebook
{
    class Course
    {
        public string _name;
        public string _gpa;
        public int _creditHours;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string GPA
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public int CreditHours
        {
            get { return _creditHours; }
            set { _creditHours = value; }
        }

        public Course(string n, string gpa, int ch)
        {
            Name = n;
            GPA = gpa;
            CreditHours = ch;
        }

        public string OutputInformation()
        { 
            return Name + ":" + GPA + ":" + CreditHours.ToString() + ":";

        }

    }
}
