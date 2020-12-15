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
    public partial class Form2 : Form
    {

        public int numberOfTimesHit = 0;
        public int X;
        public int Y;
        Random random = new Random();
        DateTime time;
        public Form2()
        {
            
            InitializeComponent();
            X = random.Next(0, panel1.Width - 50);
            Y = random.Next(0, panel1.Height - 50);
            pictureBox1.Location = new Point(X, Y);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(numberOfTimesHit == 0)
            {
                time = DateTime.Now;
            }
            X = random.Next(0, panel1.Width - 50);
            Y = random.Next(0, panel1.Height - 50);
            pictureBox1.Location = new Point(X, Y);
            numberOfTimesHit += 1;
            if(numberOfTimesHit == int.Parse(textBox1.Text))
            {
                numberOfTimesHit = 0;
                button1.Text = "It took you " + Math.Round(((DateTime.Now - time).TotalMilliseconds / 1000), 3) + "secs to hit " + int.Parse(textBox1.Text) + " targets! That is an average of " + Math.Round((Math.Round(((DateTime.Now - time).TotalMilliseconds / 1000), 3) / int.Parse(textBox1.Text)), 3) + "secs per target!";
                button1.Visible = true;
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            button1.Visible = false;
            panel3.Visible = true;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            if (ch == 13 && textBox1.Text != "" && textBox1.Text != "1")
            {
                panel3.Visible = false;
            }
        }
    }
}
