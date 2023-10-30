using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
            for(int i = 0; i < 20; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] arr = { "C", "E", "B", "A", "E" };
            comboBox1.Sorted = true;
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                comboBox1.Items.Add(arr[i]);

            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            string[] arr;
            arr = new string[] { "Conor", "Khabib", "Jose Aldo", "Alex Pereira" };
            comboBox1.DataSource = arr;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                MessageBox.Show(comboBox2.SelectedItem.ToString());
            }
            else MessageBox.Show("Error, nothing was selected");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex != -1) {
                MessageBox.Show(comboBox2.SelectedIndex.ToString());
            }
            else
            {
                MessageBox.Show("Error nothing was selected", "Error",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                
            }
        } 
        private void button7_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Remove(comboBox2.SelectedItem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Remove("First line");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked on the ComboBox", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You selected an item", "Warning");
            if(comboBox4.SelectedIndex != -1) { MessageBox.Show(comboBox4.SelectedItem.ToString()); }
            else MessageBox.Show("Nothing was seleceted", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        private void comboBox5_TextChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex != -1) { MessageBox.Show(comboBox5.SelectedText); }
            else MessageBox.Show("Nothing was seleceted", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }  
    }
}
