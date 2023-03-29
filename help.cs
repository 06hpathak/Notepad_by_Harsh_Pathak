using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Notepad_Harsh_Pathak
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void lable_linkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/harsh-pathak-2624041ba/");
        }

        private void label_gmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/?authuser=06hpathak@gmail.com");
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lab_details_Click(object sender, EventArgs e)
        {

        }
    }
}

