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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = { "excellent", "good", "satisfactory", "unsatisfactory" };
            checkedListBox1.Items.Clear();
            for(int i = 0; i < arr.Length; i++) { checkedListBox1.Items.Add(arr[i]); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(int i in checkedListBox1.CheckedIndices) { MessageBox.Show(i + 1 + "." + checkedListBox1.Items[i].ToString()); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (int i in checkedListBox1.CheckedIndices) { MessageBox.Show(i + 1 + "." + checkedListBox1.Items[i].ToString() +" is "+ checkedListBox1.GetItemCheckState(i)); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach(int i in checkedListBox1.CheckedIndices) { checkedListBox1.Items.RemoveAt(i); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = checkedListBox1.Items.IndexOf("Afganistan");
            if (checkedListBox1.GetItemCheckState(index) == CheckState.Checked)
            {
                MessageBox.Show("Afganistan is checked");
            }
            else
            {
                MessageBox.Show("Afganistan is not checked");
            }
        }
    }
}
