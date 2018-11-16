using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;

namespace MyGame15
{
    public partial class FormGame15 : Form
    {
        public int stage = 0;
        private Game game;
        Stopwatch secundomer = new Stopwatch();
        private DateTime expiry;
        private TimeSpan delay = TimeSpan.FromMinutes(1);
        PrivateFontCollection pfc = new PrivateFontCollection();
        ReSult formResult = new ReSult();

        public FormGame15()
        {
            InitializeComponent();
            game = new Game(4);
            pfc.AddFontFile(@"C:\Users\User\source\repos\MyGame15\MyGame15\Fonts\Crysta.ttf");
            //pfc.AddFontFile(@"\Fonts\Predator.ttf");
        }

        private void FormGame15_Load(object sender, EventArgs e)
        {
            Start_Game();
            expiry = DateTime.Now.Add(delay);
            labelTime.Font = new Font(pfc.Families[0], 12);
            Count.Font = new Font(pfc.Families[0], 12);
        }

        private void button0_Click(object sender, EventArgs e)
        {

            byte position = Convert.ToByte(((Button)sender).Tag);
            game.Shift(position);
            stage++;
            this.Count.Text = "Кол-во ходов: " + stage;
            Refresh();

            if (game.Check_numbers())
            {
                secundomer.Stop();
                MessageBox.Show(Data.Value + ", your WIN!!!\n" + "Количество ходов до победы: " + stage + "\n" +
                                "Затраченное время: " + secundomer.Elapsed.Minutes + "мин. " +
                                secundomer.Elapsed.Seconds + "сек.");
                string str = "\\result_standart.txt";

                Properties.Settings.Default.UserID_set++;

                FileInfo fileInfo = new FileInfo(Environment.CurrentDirectory + str);
                if (!fileInfo.Exists)
                {
                    using (StreamWriter text = fileInfo.CreateText())
                    {
                        text.Write(string.Format("{0}${1}${2}${3} ходов",
                            Properties.Settings.Default.UserID_time_settings, Data.Value, (object)String.Format(
                                "{0:00}:{1:00}:{2:000}", secundomer.Elapsed.Minutes,
                                secundomer.Elapsed.Seconds, secundomer.Elapsed.Milliseconds), stage));
                        text.Close();

                    }
                }
                else
                {
                    using (StreamWriter streamWriter = new StreamWriter(Environment.CurrentDirectory + str, true))
                        streamWriter.Write(string.Format("\n{0}${1}${2}${3} ходов", Properties.Settings.Default.UserID_time_settings, Data.Value, (object)String.Format("{0:00}:{1:00}:{2:000}", secundomer.Elapsed.Minutes,
                            secundomer.Elapsed.Seconds, secundomer.Elapsed.Milliseconds), stage));
                }
                Properties.Settings.Default.Save();
                //Properties.Settings.Default.Reset();
                Hide();
                formResult.Show();
            }

        }

        private Button Button_position(byte position)
        {
            switch (position)

            {
                case 0: return button0;
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                case 10: return button10;
                case 11: return button11;
                case 12: return button12;
                case 13: return button13;
                case 14: return button14;
                case 15: return button15;
                default: return null;

            }
        }

        private void New_Game_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start_Game();
        }

        private void Refresh()
        {
            for (int position = 0; position < 16; position++)
            {
                Button_position((byte)position).Text = game.Get_Number(position).ToString();
                Button_position((byte)position).Visible = (game.Get_Number(position) > 0);
            }
        }

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void Start_Game()
        {


            secundomer.Restart();
            game.Start();
            for (int i = 0; i < 3; i++)
            {
                game.Shuffle();
            }

            Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = "Затраченное время: " + String.Format("{0:00}:{1:00}:{2:000}", secundomer.Elapsed.Minutes,
                                 secundomer.Elapsed.Seconds, secundomer.Elapsed.Milliseconds);

        }






    }
}


