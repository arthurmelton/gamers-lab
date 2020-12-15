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
    public partial class Form6 : Form
    {

        public void Wait(int ms)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
                Application.DoEvents();

        }

        int cps = 0;

        public Form6()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cps += 1;
            button1.Text = Convert.ToString(cps);
            
        }

        public void minus()
        {
            cps -= 1;
            button1.Text = Convert.ToString(cps);
        }
    }
}
