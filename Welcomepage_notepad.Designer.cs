
namespace Notepad_Harsh_Pathak
{
    partial class form_welcome_notepad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_welcome_notepad));
            this.lab_intro = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.link_Continue = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_intro
            // 
            this.lab_intro.AutoSize = true;
            this.lab_intro.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_intro.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lab_intro.Location = new System.Drawing.Point(29, 9);
            this.lab_intro.Name = "lab_intro";
            this.lab_intro.Size = new System.Drawing.Size(720, 81);
            this.lab_intro.TabIndex = 1;
            this.lab_intro.Text = "Harsh Pathak\'s Notepad";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picture_box
            // 
            this.picture_box.Image = global::Notepad_Harsh_Pathak.Properties.Resources.images1;
            this.picture_box.Location = new System.Drawing.Point(63, 107);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(303, 224);
            this.picture_box.TabIndex = 4;
            this.picture_box.TabStop = false;
            this.picture_box.Click += new System.EventHandler(this.picture_box_Click);
            // 
            // link_Continue
            // 
            this.link_Continue.AutoSize = true;
            this.link_Continue.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Continue.LinkColor = System.Drawing.Color.MediumSeaGreen;
            this.link_Continue.Location = new System.Drawing.Point(432, 174);
            this.link_Continue.Name = "link_Continue";
            this.link_Continue.Size = new System.Drawing.Size(337, 46);
            this.link_Continue.TabIndex = 5;
            this.link_Continue.TabStop = true;
            this.link_Continue.Text = "Continue to notepad →\r\n";
            this.link_Continue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Continue_LinkClicked);
            // 
            // form_welcome_notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.link_Continue);
            this.Controls.Add(this.picture_box);
            this.Controls.Add(this.lab_intro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_welcome_notepad";
            this.Text = "Welcome to Harsh Pathak\'s Notepad";
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_intro;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picture_box;
        private System.Windows.Forms.LinkLabel link_Continue;
    }
}