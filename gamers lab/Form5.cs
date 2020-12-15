using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamers_lab
{
    public partial class Form5 : Form
    {
        public int X;
        public int Y;
        public int X1;
        public int Y1;
        Random random = new Random();
        bool firstClick = true;
        DateTime firstTime;
        bool sndTime;
        int numberOfTargets = 0;
        int numberOfTargetsGood = 0;
        int text;
        int text1;
        public void Wait(int ms)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
                Application.DoEvents();

        }
        public Form5()
        {
            InitializeComponent();
            panel2.Visible = false;
            button4.Visible = false;
            panel3.Visible = true;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            X = random.Next(0, panel1.Width - 50);
            Y = random.Next(0, panel1.Height - 50);
            X1 = random.Next(0, panel1.Width - 50);
            Y1 = random.Next(0, panel1.Height - 50);
            

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (firstClick == false)
            {
                firstClick = true;
                if ((DateTime.Now - firstTime).TotalMilliseconds < int.Parse(textBox1.Text))
                {
                    numberOfTargets += 1;
                    numberOfTargetsGood += 1;

                    sndTime = true;
                    X = random.Next(0, panel1.Width - 50);
                    Y = random.Next(0, panel1.Height - 50);
                    X1 = random.Next(0, panel1.Width - 50);
                    Y1 = random.Next(0, panel1.Height - 50);
                    pictureBox1.Location = new Point(X, Y);
                    pictureBox2.Location = new Point(X1, Y1);

                }
                if (numberOfTargets == text)
                {
                    panel1.Visible = false;
                    panel2.Visible = true;
                    button4.Visible = true;
                    button4.Text = "You did it with " + numberOfTargetsGood + "/" + numberOfTargets + " right!";

                }
                sndTime = false;
                while (sndTime == false)
                {
                    Wait(text1);
                    if (sndTime == false)
                    {
                        firstClick = true;
                        X = random.Next(0, panel1.Width - 50);
                        Y = random.Next(0, panel1.Height - 50);
                        X1 = random.Next(0, panel1.Width - 50);
                        Y1 = random.Next(0, panel1.Height - 50);
                        pictureBox1.Location = new Point(X, Y);
                        pictureBox2.Location = new Point(X1, Y1);
                        numberOfTargets++;
                    }
                    if (numberOfTargets == text)
                    {
                        panel1.Visible = false;
                        panel2.Visible = true;
                        button4.Visible = true;
                        button4.Text = "You did it with " + numberOfTargetsGood + "/" + numberOfTargets + " right!";
                    }
                }
                return;
            }
            if (firstClick == true)
            {
                firstClick = false;
                firstTime = DateTime.Now;
                Wait(text1);
                if (sndTime == false)
                {
                    firstClick = true;
                    X = random.Next(0, panel1.Width - 50);
                    Y = random.Next(0, panel1.Height - 50);
                    X1 = random.Next(0, panel1.Width - 50);
                    Y1 = random.Next(0, panel1.Height - 50);
                    pictureBox1.Location = new Point(X, Y);
                    pictureBox2.Location = new Point(X1, Y1);
                    numberOfTargets++;
                }
                if (numberOfTargets == text)
                {
                    panel1.Visible = false;
                    panel2.Visible = true;
                    button4.Visible = true;
                    button4.Text = "You did it with " + numberOfTargetsGood + "/" + numberOfTargets + " right!";
                }
                return;

            }


        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (firstClick == false)
            {
                firstClick = true;
                if ((DateTime.Now - firstTime).TotalMilliseconds < int.Parse(textBox1.Text))
                {
                    numberOfTargets += 1;
                    numberOfTargetsGood += 1;

                    sndTime = true;
                    X = random.Next(0, panel1.Width - 50);
                    Y = random.Next(0, panel1.Height - 50);
                    X1 = random.Next(0, panel1.Width - 50);
                    Y1 = random.Next(0, panel1.Height - 50);
                    pictureBox1.Location = new Point(X, Y);
                    pictureBox2.Location = new Point(X1, Y1); 

                }
                if (numberOfTargets == text)
                {
                    panel1.Visible = false;
                    panel2.Visible = true;
                    button4.Visible = true;
                    button4.Text = "You did it with " + numberOfTargetsGood + "/" + numberOfTargets + " right!";

                }
                sndTime = false;
                while (sndTime == false)
                {
                    Wait(text1);
                    if (sndTime == false)
                    {
                        firstClick = true;
                        X = random.Next(0, panel1.Width - 50);
                        Y = random.Next(0, panel1.Height - 50);
                        X1 = random.Next(0, panel1.Width - 50);
                        Y1 = random.Next(0, panel1.Height - 50);
                        pictureBox1.Location = new Point(X, Y);
                        pictureBox2.Location = new Point(X1, Y1);
                        numberOfTargets++;
                    }
                    if (numberOfTargets == text)
                    {
                        panel1.Visible = false;
                        panel2.Visible = true;
                        button4.Visible = true;
                        button4.Text = "You did it with " + numberOfTargetsGood + "/" + numberOfTargets + " right!";
                    }
                }
                return;
            }
            if (firstClick == true)
            {
                firstClick = false;
                firstTime = DateTime.Now;
                Wait(text1);
                if (sndTime == false)
                {
                    firstClick = true;
                    X = random.Next(0, panel1.Width - 50);
                    Y = random.Next(0, panel1.Height - 50);
                    X1 = random.Next(0, panel1.Width - 50);
                    Y1 = random.Next(0, panel1.Height - 50);
                    pictureBox1.Location = new Point(X, Y);
                    pictureBox2.Location = new Point(X1, Y1);
                    numberOfTargets++;
                }
                if (numberOfTargets == text)
                {
                    panel1.Visible = false;
                    panel2.Visible = true;
                    button4.Visible = true;
                    button4.Text = "You did it with " + numberOfTargetsGood + "/" + numberOfTargets + " right!";
                }
                return;

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                panel3.Visible = false;
                text = int.Parse(textBox2.Text);
                text1 = int.Parse(textBox1.Text);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel1.Visible = true;
            panel2.Visible = false;
            numberOfTargets = 0;
            numberOfTargetsGood = 0;
        }
    }
}
