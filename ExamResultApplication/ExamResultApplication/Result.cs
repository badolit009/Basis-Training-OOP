using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ExamResultApplication
{
    class Result
    {
        public double Avg { get; private set; }
        private double physics;
        private double chemistry;
        private double math;

        public Result(double phy,double che, double mat)
        {
            if (phy > 100 || che > 100 || mat > 100)
            {
                MessageBox.Show(@"Mark out of range");
            }
            else
            {
                Physics = phy;
                Chemistry = che;
                Math = mat;
            }
        }

        public double Physics
        {
            set
            {
                    physics = value;
            }         
        }

        public double Chemistry
        {
            set
            {
                chemistry = value;
            }
        }

        public double Math
        {
            set
            {
                    math = value; 
            }
        }

        public double Average()
        {
            return (physics + chemistry + math) / 3;
        }

        public string LetterGrade()
        {
            string grade="";
            Avg = Average();

            if(Avg>=80)
            {
                grade= "A+";
            }
            else if (Avg >= 70)
            {
                grade= "B+";
            }
            else if (Avg >= 60)
            {
                grade= "C+";
            }
            else if (Avg >= 50)
            {
                grade= "D+";
            }
            else if (Avg <50)
            {
                grade= "F";
            }
            return grade;
        }
    }
}
