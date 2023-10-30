using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab13
{
    public partial class Form1 : Form
    {
        int index = 0;
        int[] sum = { 2, 1, 1, 1, 2 };
        string[] s = {"C#this?", "What is an int?", "What is the foreach operator responsible for?",
        "How does the conditional statement work?", "How does an int differ from a short data type?"};
        string[,] value = { { "Program for editing text", "Programming language", "DBMS", "This is the name of the procces" },
        {"Data type", "Programming language", " loop operator "," condition operator "},
        {"This operator is a loop that is specially created for a collection "," Programming language "," Data type responsible for integers "," This operator is erroneous "},
        {"One of branches", "is excecuted in a loop", "cc", "cc" },
        {"Program4", "By the size of allocated memory", "cc", "cc" }
        };
        int temp = 0;
        int result = 0;

        void Loaddata(int i)
        {
            if (index >= s.Length) return;
            else
            {
                groupBox1.Text = s[index];
                radioButton1.Text = value[index, 0];
                radioButton2.Text = value[index, 1];
                radioButton3.Text = value[index, 2];
                radioButton4.Text = value[index, 3];
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loaddata(index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Enabled= false;
            Loaddata(index);
            button1.Enabled = true;
            if(index == s.Length)
            {
                button3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(index >= s.Length) return;
            if(radioButton1.Checked == true) { temp = 1; }
            if(radioButton2.Checked == true) { temp = 2; }
            if(radioButton3.Checked == true) { temp = 3; }
            if(radioButton4.Checked == true) { temp = 4; }
            if (sum[index] == temp) result += 1;
            index++;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You got " + result.ToString() + "points", "Title");
            Text = "You got" + result.ToString() + "points";
        }
    }
}
