using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Check Box 1");
            }if(checkBox2.Checked)
            {
                MessageBox.Show("Check Box 2");
            }if(checkBox3.Checked)
            {
                MessageBox.Show("Check Box 3");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.CheckState.ToString() + checkBox2.CheckState.ToString() + checkBox3.CheckState.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) MessageBox.Show("Button 1");
            if (radioButton2.Checked) MessageBox.Show("Button 2");
            if (radioButton3.Checked) MessageBox.Show("Button 3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked) MessageBox.Show("Button 4");
            if (radioButton5.Checked) MessageBox.Show("Button 5");
            if (radioButton6.Checked) MessageBox.Show("Button 6");
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Cheched Changed");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
