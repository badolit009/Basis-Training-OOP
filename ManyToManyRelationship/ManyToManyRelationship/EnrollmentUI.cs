using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManyToManyRelationship
{
    public partial class EnrollmentUI : Form
    {
        private List<Enrollment> enrollments;
        public EnrollmentUI(List<Student> students, List<Course> courses, List<Enrollment> enrollments )
        {
            InitializeComponent();
            PopulateStudentComboBox(students);
            PopulateCourseComboBox(courses);
            this.enrollments = enrollments;
            ShowListView();
        }

        private void ShowListView()
        {
            foreach (Enrollment enrollment in enrollments)
            {
                ListViewItem item = new ListViewItem(enrollment.AStudent.ToString());
                item.SubItems.Add(enrollment.CourseTaken.Title);
                item.SubItems.Add(enrollment.EnrolledDate.ToString());
                EnrollListView.Items.Add(item);
            }
        }

        private void PopulateCourseComboBox(List<Course> courses)
        {
            courseComboBox.DisplayMember="Title";
            courseComboBox.DataSource = courses;
            courseComboBox.ValueMember = "Code";
        }

        private void PopulateStudentComboBox(List<Student> students)
        {
            studentComboBox.DisplayMember = "RegNo";
            studentComboBox.DataSource = students;
            studentComboBox.ValueMember = "Name";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Enrollment enrollment = new Enrollment((Student)studentComboBox.SelectedItem,(Course)courseComboBox.SelectedItem,enrollmentDateTimePicker.Value);
            enrollments.Add(enrollment);
            EnrollListView.Items.Clear();
            ShowListView();
        }

    }
}
