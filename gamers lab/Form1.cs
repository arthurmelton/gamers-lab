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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form2());
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
                pictureBox2.Visible = false;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            pictureBox2.Visible = true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form2());
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
                pictureBox2.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form3());
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form4());
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form5());
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form6());
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form7());
        }
    }
}
