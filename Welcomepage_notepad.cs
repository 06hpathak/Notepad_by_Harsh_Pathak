using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_Harsh_Pathak
{
    public partial class form_welcome_notepad : Form
    {
        public form_welcome_notepad()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void picture_box_Click(object sender, EventArgs e)
        {

        }

        private void btn_open_Click(object sender, EventArgs e)
        {

        }

        private void link_Continue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_notepad f2 = new form_notepad();
            this.Hide();
            f2.ShowDialog();
        }
    }
}
