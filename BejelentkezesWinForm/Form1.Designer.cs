
namespace BejelentkezesWinForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üdvözöljük az oldalunkon!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ha még nem regisztrált: ";
            this.label2.Visible = false;
            // 
            // RegLink
            // 
            this.RegLink.AutoSize = true;
            this.RegLink.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegLink.LinkColor = System.Drawing.Color.Aqua;
            this.RegLink.Location = new System.Drawing.Point(303, 159);
            this.RegLink.Name = "RegLink";
            this.RegLink.Size = new System.Drawing.Size(135, 26);
            this.RegLink.TabIndex = 2;
            this.RegLink.TabStop = true;
            this.RegLink.Text = "Regisztráció";
            this.RegLink.Visible = false;
            this.RegLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegLink_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ha már regisztrált:";
            this.label3.Visible = false;
            // 
            // LoginLink
            // 
            this.LoginLink.AutoSize = true;
            this.LoginLink.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLink.LinkColor = System.Drawing.Color.Aqua;
            this.LoginLink.Location = new System.Drawing.Point(303, 216);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(80, 26);
            this.LoginLink.TabIndex = 4;
            this.LoginLink.TabStop = true;
            this.LoginLink.Text = "Belépés";
            this.LoginLink.Visible = false;
            this.LoginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel RegLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LoginLink;
    }
}

