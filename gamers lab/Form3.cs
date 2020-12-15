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
    public partial class Form3 : Form
    {

        public void Wait(int ms)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
                Application.DoEvents();

        }
        Random random = new Random();

        public int firstClick = 0;
        public int ifGreen = 0;
        public DateTime time;

        public Form3()
        {
            InitializeComponent();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (firstClick == 0)
            {
                firstClick = 1;
                button1.Text = "";
                button1.BackColor = Color.Red;
                Wait(random.Next(1000, 10001));
                if (firstClick == 0)
                {
                    button1.BackColor = Color.Red;
                    return;
                }
                ifGreen = 1;
                button1.BackColor = Color.Green;
                time = DateTime.Now;
                return;
            }
            if (firstClick == 1)
            {
                if(ifGreen == 1)
                {
                    button1.Text = (DateTime.Now - time).TotalMilliseconds.ToString() + "ms";
                }
                if (ifGreen == 0)
                {
                    button1.Text = "Dont click before it is green";
                }
                firstClick = 0;
                ifGreen = 0;
            }
        }
    }
}
