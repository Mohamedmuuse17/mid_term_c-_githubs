namespace week3
{
    public partial class lblname : Form
    {
        public lblname()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            double units = double.Parse(txtUnits.Text);
            double price = double.Parse(txtPrice.Text);

            double bill = units * price;

            lblResult.Text = "Total Bill: " + bill.ToString();

            MessageBox.Show("Customer Name: " + name +
                            "\nTotal Bill: " + bill);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtUnits.Clear();
            txtPrice.Clear();
            lblResult.Text = "";

            txtName.Focus();
        }
    }
    }
}
