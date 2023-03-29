
namespace Notepad_Harsh_Pathak
{
    partial class help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(help));
            this.btn_ok = new System.Windows.Forms.Button();
            this.lab_details = new System.Windows.Forms.Label();
            this.lable_linkedin = new System.Windows.Forms.LinkLabel();
            this.label_gmail = new System.Windows.Forms.LinkLabel();
            this.lab_love = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(50, 381);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(315, 36);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lab_details
            // 
            this.lab_details.AutoSize = true;
            this.lab_details.BackColor = System.Drawing.Color.Transparent;
            this.lab_details.Font = new System.Drawing.Font("Reem Kufi", 24F, System.Drawing.FontStyle.Bold);
            this.lab_details.Location = new System.Drawing.Point(3, 9);
            this.lab_details.Name = "lab_details";
            this.lab_details.Size = new System.Drawing.Size(429, 244);
            this.lab_details.TabIndex = 2;
            this.lab_details.Text = "                     Thank You!\r\n     For Using My Notepad.\r\nDirected by:- Harsh " +
    "Pathak\r\n                     Contact me :-\r\n";
            this.lab_details.Click += new System.EventHandler(this.lab_details_Click);
            // 
            // lable_linkedin
            // 
            this.lable_linkedin.AutoSize = true;
            this.lable_linkedin.BackColor = System.Drawing.Color.Transparent;
            this.lable_linkedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_linkedin.LinkColor = System.Drawing.Color.SteelBlue;
            this.lable_linkedin.Location = new System.Drawing.Point(34, 274);
            this.lable_linkedin.Name = "lable_linkedin";
            this.lable_linkedin.Size = new System.Drawing.Size(117, 31);
            this.lable_linkedin.TabIndex = 3;
            this.lable_linkedin.TabStop = true;
            this.lable_linkedin.Text = "LinkedIn";
            this.lable_linkedin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lable_linkedin_LinkClicked);
            // 
            // label_gmail
            // 
            this.label_gmail.AutoSize = true;
            this.label_gmail.BackColor = System.Drawing.Color.Transparent;
            this.label_gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gmail.LinkColor = System.Drawing.Color.Red;
            this.label_gmail.Location = new System.Drawing.Point(281, 274);
            this.label_gmail.Name = "label_gmail";
            this.label_gmail.Size = new System.Drawing.Size(84, 31);
            this.label_gmail.TabIndex = 4;
            this.label_gmail.TabStop = true;
            this.label_gmail.Text = "Gmail";
            this.label_gmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_gmail_LinkClicked);
            // 
            // lab_love
            // 
            this.lab_love.AutoSize = true;
            this.lab_love.BackColor = System.Drawing.Color.Transparent;
            this.lab_love.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_love.Location = new System.Drawing.Point(85, 328);
            this.lab_love.Name = "lab_love";
            this.lab_love.Size = new System.Drawing.Size(247, 33);
            this.lab_love.TabIndex = 5;
            this.lab_love.Text = "Made With Love!";
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 422);
            this.Controls.Add(this.lab_love);
            this.Controls.Add(this.label_gmail);
            this.Controls.Add(this.lable_linkedin);
            this.Controls.Add(this.lab_details);
            this.Controls.Add(this.btn_ok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "help";
            this.Text = "Help_Harsh Pathak\'s Notepad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lab_details;
        private System.Windows.Forms.LinkLabel lable_linkedin;
        private System.Windows.Forms.LinkLabel label_gmail;
        private System.Windows.Forms.Label lab_love;
    }
}