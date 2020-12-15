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
    public partial class Form4 : Form
    {
        public int X;
        public int Y;
        Random random = new Random();
        public float time;
        public int speedx;
        public int speedy;
        public Form4()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            if (ch == 13 && textBox1.Text != "")
            {
                button1.Visible = false;
                textBox1.Visible = false;
                X = random.Next(0, panel1.Width - 50);
                Y = random.Next(0, panel1.Height - 50);
                pictureBox1.Location = new Point(X, Y);
                pictureBox1.Visible = true;
                X = random.Next(0, panel1.Width - 50);
                Y = random.Next(0, panel1.Height - 50);
                X = pictureBox1.Location.X - X;
                Y = pictureBox1.Location.Y - Y;
                time = random.Next(10000, 20001) / int.Parse(textBox1.Text);
            }
        }

        public void Timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
