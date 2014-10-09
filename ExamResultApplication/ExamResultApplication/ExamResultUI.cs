using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamResultApplication
{
    public partial class ExamResultUI : Form
    {
        public ExamResultUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Result aResult = new Result(Convert.ToDouble(physicsTextBox.Text),
                                        Convert.ToDouble(chemistryTextBox.Text),
                                        Convert.ToDouble(mathTextBox.Text));

            physicsTextBox.Text = string.Empty;
            chemistryTextBox.Text = string.Empty;
            mathTextBox.Text = string.Empty;

            if (aResult.Average() != 0)
            {
                averageTextBox.Text = aResult.Average().ToString();
                letterGradeTextBox.Text = aResult.LetterGrade();
            }
        }
        
    }
}
