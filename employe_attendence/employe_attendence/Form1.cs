using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employe_attendence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Declare variables
            string p_name;
            int p_id;
            int age;

            // Get data from textboxes
            p_name = txtname.Text;
            p_id = int.Parse(txtid.Text);
            age = int.Parse(txtage.Text);

            // Check patient ID
            if (p_id < 0)
            {
                MessageBox.Show("ID must be a non-negative number!");
                return;
            }

            // Check patient age
            if (age < 1)
            {
                MessageBox.Show("Age must be a positive number!");
                return;
            }

            // Check patient name
            if (p_name == "")
            {
                MessageBox.Show("Please enter patient name!");
                return;
            }

            // Check gender selection
            if (rdomale.Checked == false && rdofemale.Checked == false)
            {
                MessageBox.Show("Please select patient gender!");
                return;
            }

            // Declare StreamWriter
            StreamWriter writes;

            // Prepare DialogResult
            DialogResult result;

            // Show SaveFileDialog
            saveFileDialog1.OverwritePrompt = false;
            result = saveFileDialog1.ShowDialog();

            // Check user selection
            if (result == DialogResult.OK)
            {
                // Open file in append mode
                writes = File.AppendText(saveFileDialog1.FileName);

                // Write patient information
                writes.WriteLine("patient id: " + txtid.Text);
                writes.WriteLine("patient name: " + txtname.Text);
                writes.WriteLine("patient age: " + txtage.Text);

                // Check and write gender
                if (rdomale.Checked == true)
                {
                    writes.WriteLine("gender type: male");
                }
                else if (rdofemale.Checked == true)
                {
                    writes.WriteLine("gender type: female");
                }

                // Write separator
                writes.WriteLine("----------------");

                // Close file
                writes.Close();

                MessageBox.Show("Patient information saved successfully!");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Save cancelled!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //declare stream reader
            StreamReader reads;

            //prepare dialog result
            DialogResult result;

            //show openfiledialog
            result = openFileDialog1.ShowDialog();

            //check user selection
            if (result == DialogResult.OK)
            {
                //open selected file
                reads = File.OpenText(openFileDialog1.FileName);

                //declare string variable
                string lines;

                //read file until the end
                while (reads.EndOfStream == false)
                {
                    lines = reads.ReadLine();

                    //display 
                    listBox1.Items.Add(lines);



                }
                //close the file 
                reads.Close();




            }
            else if (result == DialogResult.Cancel)
            {
                //display cancal message
                MessageBox.Show("reading canceled");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtage.Clear();
           
            rdomale.Checked = false;
            rdofemale.Checked = false;
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item first!");
                return;
            }

            if (File.Exists("openFileDialog1.FileName"));
            {
                List<string> lines = File.ReadAllLines(openFileDialog1.FileName).ToList();

                lines.RemoveAt(listBox1.SelectedIndex);

                File.WriteAllLines(openFileDialog1.FileName, lines);

                listBox1.Items.Clear();
                listBox1.Items.AddRange(lines.ToArray());

                MessageBox.Show("Item deleted successfully!");
            }
            
             
            
            }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;

            // Check whether the ListBox contains records
            foreach (var item in listBox1.Items)
            {
                if (item.ToString().StartsWith("patience id:"))
                {
                    count++;
                }
            }

            // Display total patient records
            MessageBox.Show("Total Patient Records: " + count++);
        }
    }
    }
    

