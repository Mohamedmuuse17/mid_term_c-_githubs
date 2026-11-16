namespace ch1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            using System;
            using System.Windows.Forms;
            using System.Drawing;

namespace CH1
    {
        public partial class Form1 : Form
        {
            TextBox txtID = new TextBox();
            TextBox txtName = new TextBox();
            TextBox txtUniversity = new TextBox();

            Button btnCalculate = new Button();

            public Form1()
            {
                InitializeComponent();

                this.Text = "Student Information";
                this.Size = new Size(850, 550);
                this.StartPosition = FormStartPosition.CenterScreen;

                // ID Label
                Label lblID = new Label();
                lblID.Text = "Enter ID";
                lblID.Location = new Point(100, 80);
                lblID.AutoSize = true;
                this.Controls.Add(lblID);

                txtID.Location = new Point(250, 75);
                txtID.Width = 150;
                this.Controls.Add(txtID);

                // Name Label
                Label lblName = new Label();
                lblName.Text = "Enter Name";
                lblName.Location = new Point(100, 135);
                lblName.AutoSize = true;
                this.Controls.Add(lblName);

                txtName.Location = new Point(250, 130);
                txtName.Width = 150;
                this.Controls.Add(txtName);

                // University Label
                Label lblUniversity = new Label();
                lblUniversity.Text = "Enter University";
                lblUniversity.Location = new Point(100, 190);
                lblUniversity.AutoSize = true;
                this.Controls.Add(lblUniversity);

                txtUniversity.Location = new Point(250, 185);
                txtUniversity.Width = 150;
                this.Controls.Add(txtUniversity);

                // Calculate Button
                btnCalculate.Text = "Calculate";
                btnCalculate.Location = new Point(230, 270);
                btnCalculate.Size = new Size(100, 35);

                btnCalculate.Click += BtnCalculate_Click;

                this.Controls.Add(btnCalculate);
            }

            private void BtnCalculate_Click(object sender, EventArgs e)
            {
                if (txtID.Text == "" ||
                    txtName.Text == "" ||
                    txtUniversity.Text == "")
                {
                    MessageBox.Show("Please fill all fields!");
                    return;
                }

                MessageBox.Show(
                    "Student ID: " + txtID.Text +
                    "\nName: " + txtName.Text +
                    "\nUniversity: " + txtUniversity.Text,
                    "Student Information"
                );
            }
        }
    }

}

        