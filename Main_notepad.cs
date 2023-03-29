using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace Notepad_Harsh_Pathak
{
    public partial class form_notepad : Form
    {
        public form_notepad()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_main.Clear();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

            OpenFileDialog op = new OpenFileDialog();

            op.Title = "Open";
            op.Filter = "Text Document (*.txt)|*.txt|All Files(*.*)|*.*";
            if(op.ShowDialog()==DialogResult.OK)
            {
                rtxt_main.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
                this.Text = op.FileName;
            }

               
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog op = new SaveFileDialog();
            op.Title = "Save";
            op.Filter = " Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if(op.ShowDialog() == DialogResult.OK)
            {
                rtxt_main.SaveFile(op.Filter, RichTextBoxStreamType.PlainText);
                this.Text = op.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_main.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_main.Redo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_main.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_main.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_main.Cut();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_main.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_main.Text = System.DateTime.Now.ToString();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog op = new FontDialog();
            if(op.ShowDialog()==DialogResult.OK)
            {
                rtxt_main.Font = op.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog OP = new ColorDialog();
            if(OP.ShowDialog ()== DialogResult.OK)
            {
                rtxt_main.ForeColor = OP.Color;
            }
        }

        private void darkMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_main.BackColor = Color.Black;
            rtxt_main.ForeColor = Color.White;

        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxt_main.BackColor = Color.White;
            rtxt_main.ForeColor = Color.Black;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog op = new SaveFileDialog();
            op.Title = "Save As";
            op.Filter = " Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                rtxt_main.SaveFile(op.Filter, RichTextBoxStreamType.PlainText);
                this.Text = op.FileName;
            }

        }

        private void form_notepad_Load(object sender, EventArgs e)
        {

        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help f2 = new help();
            f2.ShowDialog();
        }
    }
}
