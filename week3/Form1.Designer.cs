namespace week3
{
    partial class lblname
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
            lblnumber = new Label();
            label2 = new Label();
            lblonsumed = new Label();
            txtUnits = new TextBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // lblnumber
            // 
            lblnumber.AutoSize = true;
            lblnumber.Location = new Point(59, 71);
            lblnumber.Name = "lblnumber";
            lblnumber.Size = new Size(102, 15);
            lblnumber.TabIndex = 0;
            lblnumber.Text = "customer number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 105);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // lblonsumed
            // 
            lblonsumed.AutoSize = true;
            lblonsumed.Location = new Point(68, 134);
            lblonsumed.Name = "lblonsumed";
            lblonsumed.Size = new Size(92, 15);
            lblonsumed.TabIndex = 2;
            lblonsumed.Text = "units consumed";
            // 
            // txtUnits
            // 
            txtUnits.Location = new Point(214, 63);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(100, 23);
            txtUnits.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(214, 97);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(214, 131);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(146, 214);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblname
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(txtName);
            Controls.Add(txtPrice);
            Controls.Add(txtUnits);
            Controls.Add(lblonsumed);
            Controls.Add(label2);
            Controls.Add(lblnumber);
            Name = "lblname";
            Text = "customer name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnumber;
        private Label label2;
        private Label lblonsumed;
        private TextBox txtUnits;
        private TextBox txtPrice;
        private TextBox txtName;
        private Button btnCalculate;
    }
}
