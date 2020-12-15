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
    public partial class Form7 : Form
    {
        Random random = new Random();
        public void createimg(string name)
        {
            var picture = new PictureBox
            {
                Name = "pictureBox" + name,
                Size = new Size(50, 50),
                Location = new Point(random.Next(0, panel1.Width - 25), random.Next(0, panel1.Height - 25)),
                Image = Image.FromFile(Application.ExecutablePath.Replace("gamers lab.exe", "th (32) (1).jpg")),

            };
            this.Controls.Add(picture);
        }

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            int numberOfImgs = 0;
            while (10 > numberOfImgs)
            {
                numberOfImgs++;
                createimg(numberOfImgs.ToString());


            }
        }
    }
}
