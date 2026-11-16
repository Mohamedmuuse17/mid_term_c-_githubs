namespace week2
{
    partial class lblsudentid
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblstudentid = new Label();
            lblsudentname = new Label();
            lblstudentcourse = new Label();
            this.txtID = new TextBox();
            this.txtName = new TextBox();
            txtCourse = new TextBox();
            btninsert = new Button();
            SuspendLayout();
            // 
            // lblstudentid
            // 
            lblstudentid.AutoSize = true;
            lblstudentid.Location = new Point(84, 54);
            lblstudentid.Name = "lblstudentid";
            lblstudentid.Size = new Size(90, 15);
            lblstudentid.TabIndex = 0;
            lblstudentid.Text = "enetr student id";
            // 
            // lblsudentname
            // 
            lblsudentname.AutoSize = true;
            lblsudentname.Location = new Point(84, 109);
            lblsudentname.Name = "lblsudentname";
            lblsudentname.Size = new Size(80, 15);
            lblsudentname.TabIndex = 1;
            lblsudentname.Text = "student name";
            // 
            // lblstudentcourse
            // 
            lblstudentcourse.AutoSize = true;
            lblstudentcourse.Location = new Point(84, 150);
            lblstudentcourse.Name = "lblstudentcourse";
            lblstudentcourse.Size = new Size(110, 15);
            lblstudentcourse.TabIndex = 2;
            lblstudentcourse.Text = "enter student coure";
            // 
            // txtID
            // 
            this.txtID.Location = new Point(197, 54);
            this.txtID.Name = "txtID";
            this.txtID.Size = new Size(100, 23);
            this.txtID.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new Point(197, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(100, 23);
            this.txtName.TabIndex = 5;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(197, 150);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(100, 23);
            txtCourse.TabIndex = 6;
            // 
            // btninsert
            // 
            btninsert.Location = new Point(119, 246);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(75, 23);
            btninsert.TabIndex = 7;
            btninsert.Text = "insert";
            btninsert.UseVisualStyleBackColor = true;
            btninsert.Click += btninsert_Click;
            // 
            // lblsudentid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(btninsert);
            Controls.Add(txtCourse);
            Controls.Add(this.txtName);
            Controls.Add(this.txtID);
            Controls.Add(lblstudentcourse);
            Controls.Add(lblsudentname);
            Controls.Add(lblstudentid);
            Name = "lblsudentid";
            Text = "enter student id";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblstudentid;
        private Label lblsudentname;
        private Label lblstudentcourse;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtCourse;
        private Button btninsert;
        private TextBox textBox4;
    }
}
