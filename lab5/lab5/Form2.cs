using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int viNom = 0;
            // Single-line text
            richTextBox1.Text += "Text" + (viNom).ToString();
            viNom++;
            // First way to add multi-line text
            richTextBox1.Text += "String" + (viNom).ToString() + "\r\n";
            viNom++;
            richTextBox1.Text += "String" + (viNom).ToString() + "\r\n";
            // Second way to add multi-line text
            richTextBox1.AppendText("String" + viNom + "\r\n");
            viNom++;
            richTextBox1.AppendText("String" + viNom + "\r\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.SelectionBullet = false;
            richTextBox1.BulletIndent = 5;
            richTextBox1.SelectionFont = new Font("Arial", 16);
            richTextBox1.SelectedText = "Below is a list\n";
            // Add list items
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectedText = "Apple\n";
            // ... Add more items
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionFont = new Font("Verdana", 10);
            richTextBox1.SelectedText = "The list is over\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "My site http://CSharp.kg";
        }

        private void richTextBox2_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            MessageBox.Show("Clicked on links");
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
