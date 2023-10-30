using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab12
{
    public partial class Form1 : Form
       
    {
        private BindingSource bindingSource = new BindingSource();
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Ivanov", "Peter", 12);
            dataGridView1.Rows.Add("Abdylbaev", "Ruslan", 12);
            dataGridView1.Rows.Add("Ruslanova", "Zarina", 12);
            dataGridView1.Rows.Add("Igorov", "Peter", 12);
            dataGridView1.Rows.Add("Ivanov", "Sergey", 12);

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            int viNomRow = 0;
            dataGridView1.Rows[viNomRow].DefaultCellStyle.BackColor = Color.White;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[0, i].FormattedValue.ToString().Trim().ToLower().Contains(toolStripTextBox1.Text.Trim().ToLower()))
                {
                    int enviNomRow = i;
                    dataGridView1.Rows[enviNomRow].DefaultCellStyle.BackColor = Color.Aqua;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataColumn c = table.Columns.Add("Key", typeof(String));
            c.AutoIncrement = true;
            c.AutoIncrementSeed = 1;
            c.AutoIncrementStep = 1;
            table.Columns.Add("Product", typeof(String));
            table.Columns.Add("Amount", typeof(Int32));
            table.Columns.Add("Price", typeof(Int32));
            table.Columns.Add("Sum", typeof(String), "Amount * Price");
            table.Columns.Add("Taxes", typeof(String), "Amount * Price * 0.18");
            table.PrimaryKey = new DataColumn[] { table.Columns[0] };
            bindingSource.DataSource = table;
            dataGridView2.DataSource = bindingSource;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DataRow row = table.NewRow();
            row[1] = "Milk";
            row["Amount"] = 10;
            row["Price"] = 16;
            table.Rows.Add(row);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if(table.Rows.Count == 0)
            {
                return;
            }
            table.Rows[0].Delete();
        }
    }
}
