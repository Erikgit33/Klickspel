using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security;
using System.Timers;
using System.Xml.Schema;

namespace Klickspel
{
    public partial class Form1 : Form
    {
        int boxClicks = 0;

        int timeleft = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            boxClicks = boxClicks + 1;
            if (boxClicks == 15)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                timeleft = 0;
                textBox1.Text = ("You won, good job!");
                MessageBox.Show("You win!");
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                button1.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            boxClicks = boxClicks + 1;
            if (boxClicks == 15)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                timeleft = 0;
                textBox1.Text = ("You won, good job!");
                MessageBox.Show("You win!");
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                button1.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            boxClicks = boxClicks + 1;
            if (boxClicks == 15)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                timeleft = 0;
                textBox1.Text = ("You won, good job!");
                MessageBox.Show("You win!");
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                button1.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//Easy
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox1.BackColor = Color.Green;
            pictureBox2.BackColor = Color.Green;
            pictureBox3.BackColor = Color.Green;
            timeleft = 12;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//Normal
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox1.BackColor = Color.Orange;
            pictureBox2.BackColor = Color.Orange;
            pictureBox3.BackColor = Color.Orange;
            timeleft = 8;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)//Hard
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox1.BackColor = Color.Red;
            pictureBox2.BackColor = Color.Red;
            pictureBox3.BackColor = Color.Red;
            timeleft = 3;
        }

        private void button1_Click(object sender, EventArgs e)//Start
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            if (radioButton1.Checked == true)
            {
                if (timer1.Enabled == false)//Easy
                {
                    timer1.Start();
                    timer2.Start();
                    timer3.Start();
                    timer4.Interval = 13000;
                    timer4.Start();
                    timer5.Start();
                    button1.Visible = false;
                    textBox1.Text = timeleft.ToString();
                }
                else
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();
                    timer5.Stop();
                }

            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    if (timer1.Enabled == false)//Normal
                    {
                        timer1.Start();
                        timer2.Start();
                        timer3.Start();
                        timer4.Interval = 9000;
                        timer4.Start();
                        timer5.Start();
                        button1.Visible = false;
                        textBox1.Text = timeleft.ToString();
                    }
                    else
                    {
                        timer1.Stop();
                        timer2.Stop();
                        timer3.Stop();
                        timer4.Stop();
                        timer5.Stop();
                    }
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        if (timer1.Enabled == false)//Hard
                        {
                            timer1.Start();
                            timer2.Start();
                            timer3.Start();
                            timer4.Interval = 4000;
                            timer4.Start();
                            timer5.Start();
                            button1.Visible = false;
                            textBox1.Text = timeleft.ToString();
                        }
                        else
                        {
                            timer1.Stop();
                            timer2.Stop();
                            timer3.Stop();
                            timer4.Stop();
                            timer5.Stop();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Choose difficulty!");
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
        }

        private void timer4_Tick(object sender, EventArgs e)//"You lose" timer
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            MessageBox.Show("You lose!");
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            button1.Visible = true;
            if (radioButton1.Checked == true)
            {
                timeleft = 12;
            }
            else if (radioButton2.Checked == true)
            {
                timeleft = 8;
            }
            else timeleft = 3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)//Countdown timer
        {
            timeleft = timeleft - 1;
            textBox1.Text = timeleft.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

