namespace ch1
{
    partial class Form1
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
            lblid = new Label();
            lblname = new Label();
            lbluniversity = new Label();
            txtid = new TextBox();
            txtname = new TextBox();
            txtuniversity = new TextBox();
            btncalculate = new Button();
            SuspendLayout();
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(72, 58);
            lblid.Name = "lblid";
            lblid.Size = new Size(47, 15);
            lblid.TabIndex = 0;
            lblid.Text = "enter id";
            lblid.Click += lbltitle_Click;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(72, 108);
            lblname.Name = "lblname";
            lblname.Size = new Size(70, 15);
            lblname.TabIndex = 1;
            lblname.Text = " enter name";
            // 
            // lbluniversity
            // 
            lbluniversity.AutoSize = true;
            lbluniversity.Location = new Point(72, 151);
            lbluniversity.Name = "lbluniversity";
            lbluniversity.Size = new Size(88, 15);
            lbluniversity.TabIndex = 2;
            lbluniversity.Text = "enter university";
            // 
            // txtid
            // 
            txtid.Location = new Point(213, 50);
            txtid.Name = "txtid";
            txtid.Size = new Size(100, 23);
            txtid.TabIndex = 3;
            // 
            // txtname
            // 
            txtname.Location = new Point(213, 100);
            txtname.Name = "txtname";
            txtname.Size = new Size(100, 23);
            txtname.TabIndex = 4;
            // 
            // txtuniversity
            // 
            txtuniversity.Location = new Point(213, 148);
            txtuniversity.Name = "txtuniversity";
            txtuniversity.Size = new Size(100, 23);
            txtuniversity.TabIndex = 5;
            txtuniversity.TextChanged += textBox3_TextChanged;
            // 
            // btncalculate
            // 
            btncalculate.Location = new Point(166, 270);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(75, 23);
            btncalculate.TabIndex = 6;
            btncalculate.Text = "calculate";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btncalculate);
            Controls.Add(txtuniversity);
            Controls.Add(txtname);
            Controls.Add(txtid);
            Controls.Add(lbluniversity);
            Controls.Add(lblname);
            Controls.Add(lblid);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblid;
        private Label lblname;
        private Label lbluniversity;
        private TextBox txtid;
        private TextBox txtname;
        private TextBox txtuniversity;
        private Button btncalculate;
    }
}
