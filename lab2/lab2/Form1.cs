using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                // Looking for Button controls 
                if (Convert.ToString(this.Controls[i].GetType().Name) == "Button")
                {
                    MessageBox.Show(this,
                      Convert.ToString(this.Controls[i].Name),
                      "What buttons are there?");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with a string and different buttons", "Title String", MessageBoxButtons.OKCancel);
            MessageBox.Show("Dialog box with a line and different buttons", "Title line", MessageBoxButtons.AbortRetryIgnore);
            MessageBox.Show("Dialog box with a line and different buttons", "Title line", MessageBoxButtons.OK);
            // MessageBoxButtons determines which buttons will be located on a dialog box
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with a line");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with a line", "Line Title");
            // the first parameter specifies the dialog box text, 2 specif. the title text
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with a line and different buttons", "Title bar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            MessageBox.Show("Dialog box with a line and different buttons", "Title bar", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            // MessageBoxIcon defines the dialog box icon, the data is in the Enum enumeration type

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Save data", "Attention", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes) {
                MessageBox.Show("Data Saved");
            } else if(result == DialogResult.No)
            {
                MessageBox.Show("Data Not Saved");
            } else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Saving data canceled by user");
            }
        }
    }
}
