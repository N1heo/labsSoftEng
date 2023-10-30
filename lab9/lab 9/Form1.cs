using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_9
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0)
            {
                return;
            }
            
            ListViewItem item = listView1.SelectedItems[0];

            Form2 form2 = new Form2();

            form2.FirstName = item.Text;
            form2.LastName = item.SubItems[1].Text;
            form2.Age = Convert.ToInt32(item.SubItems[2].Text);

            if(form2.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            item.Text = form2.FirstName;
            item.SubItems[1].Text = form2.LastName;
            item.SubItems[2].Text = form2.Age.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); 
            if(form2.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string name = form2.FirstName;
            string lastName = form2.LastName;
            int age = Convert.ToInt32(form2.Age);
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(lastName);
            item.SubItems.Add(age.ToString());
            listView1.Items.Add(item);
        }
    }
}
