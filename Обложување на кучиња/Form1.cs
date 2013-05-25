using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Обложување_на_кучиња
{
    public partial class Form1 : Form
    {
        int brojac = 0;
        int wins1 = 0;
        int wins2 = 0;
        int wins3 = 0;
        int wins4 = 0;
        int wins5 = 0;
        int wins6 = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = Convert.ToString(2.5);
            label2.Text = Convert.ToString(6.7);
            label3.Text = Convert.ToString(4.1);
            label4.Text = Convert.ToString(9.8);
            label5.Text = Convert.ToString(5.5);
            label6.Text = Convert.ToString(3.6);
            textBox1.Focus();
            textBox1.Select();
        }
        private void newRace()
        {
            Random r1 = new Random();
            Random r2 = new Random();
            Random r3 = new Random();
            Random r4 = new Random();
            Random r5 = new Random();
            Random r6 = new Random();
            string p1 = string.Format("{0:0.#}",r1.NextDouble() * (7.4 - 2.3) + 2.3);
            string p2 = string.Format("{0:0.#}",r2.NextDouble() * (4.2 - 2.8) + 2.8);
            string p3 = string.Format("{0:0.#}",r3.NextDouble() * (3.9 - 2.9) + 2.9);
            string p4 = string.Format("{0:0.#}",r4.NextDouble() * (8.1 - 2.5) + 2.5);
            string p5 = string.Format("{0:0.#}",r5.NextDouble() * (9.5 - 2.1) + 2.1);
            string p6 = string.Format("{0:0.#}",r6.NextDouble() * (6.8 - 2.6) + 2.6);
            label1.Text = p1;
            label2.Text = p2;
            label3.Text = p3;
            label4.Text = p4;
            label5.Text = p5;
            label6.Text = p6;
            axWindowsMediaPlayer1.URL = null;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox3.Visible = false;
            textBox1.Focus();
            textBox1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (brojac == 0)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\3.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label1.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins3++;
                brojac++;
            }
            else if (brojac == 1)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\2.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label1.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins2++;
                brojac++;
            }
            else if (brojac == 2)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\5.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label1.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins5++;
                brojac++;
            }
            else if (brojac == 3)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\1.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label1.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(pom);
                wins1++;
                brojac = 0;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (brojac == 0)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\4.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label2.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins4++;
                brojac++;
            }
            else if (brojac == 1)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\1.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label2.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins1++;
                brojac++;
            }
            else if (brojac == 2)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\6.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label2.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins6++;
                brojac++;
            }
            else if (brojac == 3)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\2.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label2.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(pom);
                wins2++;
                brojac = 0;
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            newRace();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (brojac == 0)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\5.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label4.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins5++;
                brojac++;
            }
            else if (brojac == 1)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\1.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label4.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins1++;
                brojac++;
            }
            else if (brojac == 2)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\6.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label4.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins6++;
                brojac++;
            }
            else if (brojac == 3)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\4.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label4.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(pom);
                wins4++;
                brojac=0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            textBox3.Visible=true;
            if (axWindowsMediaPlayer1.URL == (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\1.flv"))
            {
                MessageBox.Show("#1 wins!!");
            }
            else if (axWindowsMediaPlayer1.URL == (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\2.flv"))
            {
                MessageBox.Show("#2 wins!!");
            }
            else if (axWindowsMediaPlayer1.URL == (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\3.flv"))
            {
                MessageBox.Show("#3 wins!!");
            }
            else if (axWindowsMediaPlayer1.URL == (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\4.flv"))
            {
                MessageBox.Show("#4 wins!!");
            }
            else if (axWindowsMediaPlayer1.URL == (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\5.flv"))
            {
                MessageBox.Show("#5 wins!!");
            }
            else if (axWindowsMediaPlayer1.URL == (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\6.flv"))
            {
                MessageBox.Show("#6 wins!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (brojac == 0)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\1.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label3.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins1++;
                brojac++;
            }
            else if (brojac == 1)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\6.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label3.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins6++;
                brojac++;
            }
            else if (brojac == 2)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\5.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label3.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins5++;
                brojac++;
            }
            else if (brojac == 3)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\3.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label3.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(pom);
                wins3++;
                brojac = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (brojac == 0)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\4.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label5.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins4++;
                brojac++;
            }
            else if (brojac == 1)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\2.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label5.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins2++;
                brojac++;
            }
            else if (brojac == 2)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\3.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label5.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins3++;
                brojac++;
            }
            else if (brojac == 3)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\5.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label5.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(pom);
                wins5++;
                brojac = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (brojac == 0)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\1.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label6.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins1++;
                brojac++;
            }
            else if (brojac == 1)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\3.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label6.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins3++;
                brojac++;
            }
            else if (brojac == 2)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\2.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label6.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(0);
                wins2++;
                brojac++;
            }
            else if (brojac == 3)
            {
                axWindowsMediaPlayer1.URL = (@"C:\Users\User\Documents\Visual Studio 2012\Projects\Обложување на кучиња\6.flv");
                double pom = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(label6.Text));
                textBox2.Text = Convert.ToString(pom);
                textBox3.Text = Convert.ToString(pom);
                wins6++;
                brojac = 0;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {

                errorProvider1.SetError(textBox1, "Enter your bet please");
                
                e.Cancel=true;
               
                   
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void stattisticsForEveryDogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics stat = new Statistics(wins1,wins2,wins3,wins4,wins5,wins6);
            stat.Show();
        }

       

        private void newRaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newRace();
        }

       

        
        
    }
}
