using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame15
{
   
    public partial class StartForm : Form
    {
        ReSult formResult = new ReSult();

        public StartForm()
        {
            InitializeComponent();
            
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ButtonOk_Click(object sender, EventArgs e)
        {
            
            if (radioButton_standart.Checked)
            {

                if (string.IsNullOrWhiteSpace(this.textBoxName.Text))
                {
                    this.errorProvider1.SetError((Control)this.textBoxName, "Enter name!");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    Data.Value= textBoxName.Text;
                    FormGame15 form = new FormGame15();
                    form.Show();
                    this.Hide();
                }
            }

            if (radioButton_timer2.Checked)
            {

                if (string.IsNullOrWhiteSpace(this.textBoxName.Text))
                {
                    this.errorProvider1.SetError((Control)this.textBoxName, "Enter name!");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    Data.Value = textBoxName.Text;
                    FormGame15_time form = new FormGame15_time();
                    form.Show();
                    this.Hide();
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errorProvider1.Clear();
            }

           
        }

        private void radioButton_standart_CheckedChanged(object sender, EventArgs e)
        {

            label2.Visible = false;
            trackBar1.Visible = false;


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            if (radioButton_timer2.AutoCheck)
            {
                
                if (trackBar1.Value == 0)
                {
                    label2.Text = "1 мин";
                    FormGame15_time.delay = TimeSpan.FromMinutes(1);
                }

                if (trackBar1.Value == 1)
                {
                    label2.Text = "5 мин";
                    FormGame15_time.delay = TimeSpan.FromMinutes(5);
                }

                if (trackBar1.Value == 2)
                {
                    label2.Text = "10 мин";
                    FormGame15_time.delay = TimeSpan.FromMinutes(10);
                }
            }
           
        }

        private void radioButton_timer2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            trackBar1.Visible = true;
            trackBar1.Value = 0;
            if (trackBar1.Value == 0)
            {
                label2.Text = "1 мин";
                FormGame15_time.delay = TimeSpan.FromMinutes(1);
            }
        }

        private void radioButton_table_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            trackBar1.Visible = false;
            formResult.ShowDialog();

        }
    }
    

    static class Data
    {
        public static string Value { get; set; }
        
    }
}
