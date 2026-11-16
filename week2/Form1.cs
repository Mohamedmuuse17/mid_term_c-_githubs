using System.Xml.Linq;

namespace week2
{
    public partial class lblsudentid : Form
    {
        public lblsudentid()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            private void btnShow_Click(object sender, EventArgs e)
        {
            string studentName;
            string studentID;
            string course;

            studentName = txtName.Text;
            studentID = txtID.Text;
            course = txtCourse.Text;

            MessageBox.Show(
                "Student Name: " + studentName +
                "\nStudent ID: " + studentID +
                "\nCourse: " + course,
                "Student Information"
            );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtID.Clear();
            txtCourse.Clear();

            txtName.Focus();
        }
    }
    }
}
