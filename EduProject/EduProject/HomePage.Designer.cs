namespace EduProject
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnHomePageLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbHomePageEmail = new System.Windows.Forms.TextBox();
            this.txtbHomePagePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHomePAgeUserType = new System.Windows.Forms.Label();
            this.cmbxHomePAgeUserType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHomePageLogin
            // 
            this.btnHomePageLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHomePageLogin.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnHomePageLogin.Location = new System.Drawing.Point(435, 269);
            this.btnHomePageLogin.Name = "btnHomePageLogin";
            this.btnHomePageLogin.Size = new System.Drawing.Size(139, 39);
            this.btnHomePageLogin.TabIndex = 1;
            this.btnHomePageLogin.Text = "Login";
            this.btnHomePageLogin.UseVisualStyleBackColor = true;
            this.btnHomePageLogin.Click += new System.EventHandler(this.btnHomePageLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "codeTagram";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(518, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codetagram © 2018";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(365, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email :";
            // 
            // txtbHomePageEmail
            // 
            this.txtbHomePageEmail.Location = new System.Drawing.Point(435, 139);
            this.txtbHomePageEmail.Name = "txtbHomePageEmail";
            this.txtbHomePageEmail.Size = new System.Drawing.Size(139, 20);
            this.txtbHomePageEmail.TabIndex = 6;
            // 
            // txtbHomePagePassword
            // 
            this.txtbHomePagePassword.Location = new System.Drawing.Point(435, 176);
            this.txtbHomePagePassword.Name = "txtbHomePagePassword";
            this.txtbHomePagePassword.Size = new System.Drawing.Size(139, 20);
            this.txtbHomePagePassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(337, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password :";
            // 
            // lblHomePAgeUserType
            // 
            this.lblHomePAgeUserType.AutoSize = true;
            this.lblHomePAgeUserType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHomePAgeUserType.Location = new System.Drawing.Point(340, 214);
            this.lblHomePAgeUserType.Name = "lblHomePAgeUserType";
            this.lblHomePAgeUserType.Size = new System.Drawing.Size(85, 19);
            this.lblHomePAgeUserType.TabIndex = 9;
            this.lblHomePAgeUserType.Text = "UserType :";
            // 
            // cmbxHomePAgeUserType
            // 
            this.cmbxHomePAgeUserType.FormattingEnabled = true;
            this.cmbxHomePAgeUserType.Location = new System.Drawing.Point(435, 216);
            this.cmbxHomePAgeUserType.Name = "cmbxHomePAgeUserType";
            this.cmbxHomePAgeUserType.Size = new System.Drawing.Size(139, 21);
            this.cmbxHomePAgeUserType.TabIndex = 10;
            this.cmbxHomePAgeUserType.SelectedIndexChanged += new System.EventHandler(this.cmbxHomePAgeUserType_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(61, 372);
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(627, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 372);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 64);
            this.panel2.TabIndex = 12;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 372);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbxHomePAgeUserType);
            this.Controls.Add(this.lblHomePAgeUserType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbHomePagePassword);
            this.Controls.Add(this.txtbHomePageEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHomePageLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHomePageLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbHomePageEmail;
        private System.Windows.Forms.TextBox txtbHomePagePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHomePAgeUserType;
        private System.Windows.Forms.ComboBox cmbxHomePAgeUserType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}