using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                listBox1.Items.Add("Record" + i.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String[] arr = { "Excellent", "Good", "Satisfactory", "Unsatisfactory" };

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                listBox1.Items.Add(arr[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(1, "First");
            listBox1.Items.Insert(4, "Fourth");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(new object[] { "Excellent", "Good", "Satisfactory", "Unsatisfactory" });
                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i < 21; i++)
            {
                listBox1.Items.Add("Straw" + i.ToString());
            }
            // Views can be selected as a group of rows or just one SelectionMode.One
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.SetSelected(0, true); // select line one
            listBox1.SetSelected(1, true); // select line two
            listBox1.SetSelected(5, true); // select line three

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = false; // sorts in alphabetical order
            listBox1.Items.Clear();
            for (int i = 1; i < 21; i++)
            {
                listBox1.Items.Add("Straw" + i.ToString());
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.UseTabStops = true;
            for (int i = 1; i < 20; i++)
            {
                listBox1.Items.Add("Option  le mon\t " + i.ToString());
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                MessageBox.Show(listBox1.SelectedItem.ToString(), "Getting the selected String");
                MessageBox.Show(listBox1.Text, "Text");

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                MessageBox.Show(listBox1.Items[i].ToString() + " ");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString() + " ");
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click happened");
        }
    }
}
