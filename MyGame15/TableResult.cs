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

namespace MyGame15
{
    public partial class ReSult : Form
    {   
        
        public ReSult()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TableResult_Load(object sender, EventArgs e)
        {
           dataGridView1.Hide();
           dataGridView2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\User\source\repos\MyGame15\MyGame15\bin\Debug\result_time.txt");

            foreach (var str in lines)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                for (int i = 0; i < str.Split('$').Count(); i++)
                    row.Cells[i].Value = str.Split('$')[i];
                dataGridView1.Rows.Add(row);
            }
            
            dataGridView1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\User\source\repos\MyGame15\MyGame15\bin\Debug\result_standart.txt");

            foreach (var str in lines)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView2);
                for (int i = 0; i < str.Split('$').Count(); i++)
                    row.Cells[i].Value = str.Split('$')[i];
                dataGridView2.Rows.Add(row);
            }
            
            dataGridView2.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
