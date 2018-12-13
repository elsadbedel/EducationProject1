namespace EduProject
{
    partial class MentorForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajlarimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workMatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gonderilenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMesajYazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toTeacherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentorListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addResourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteResourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showResourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qaynaqlarinLinklerionlineQaynaqlardirsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFilepdfFormatdadirsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasklarinSiyahisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mentor Form";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInfoToolStripMenuItem,
            this.taskToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.mesajlarimToolStripMenuItem,
            this.workMatesToolStripMenuItem,
            this.libraryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personalInfoToolStripMenuItem
            // 
            this.personalInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.personalInfoToolStripMenuItem.Name = "personalInfoToolStripMenuItem";
            this.personalInfoToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.personalInfoToolStripMenuItem.Text = "Personal Info";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTasksToolStripMenuItem});
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.taskToolStripMenuItem.Text = "Task";
            // 
            // showTasksToolStripMenuItem
            // 
            this.showTasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasklarinSiyahisToolStripMenuItem});
            this.showTasksToolStripMenuItem.Name = "showTasksToolStripMenuItem";
            this.showTasksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showTasksToolStripMenuItem.Text = "Show Tasks";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // mesajlarimToolStripMenuItem
            // 
            this.mesajlarimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gonderilenlerToolStripMenuItem,
            this.gelenlerToolStripMenuItem,
            this.yeniMesajYazToolStripMenuItem});
            this.mesajlarimToolStripMenuItem.Name = "mesajlarimToolStripMenuItem";
            this.mesajlarimToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.mesajlarimToolStripMenuItem.Text = "Mesajlarim";
            // 
            // workMatesToolStripMenuItem
            // 
            this.workMatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherListToolStripMenuItem,
            this.mentorListToolStripMenuItem});
            this.workMatesToolStripMenuItem.Name = "workMatesToolStripMenuItem";
            this.workMatesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.workMatesToolStripMenuItem.Text = "Work Mates ";
            // 
            // gonderilenlerToolStripMenuItem
            // 
            this.gonderilenlerToolStripMenuItem.Name = "gonderilenlerToolStripMenuItem";
            this.gonderilenlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gonderilenlerToolStripMenuItem.Text = "Gonderilenler";
            // 
            // gelenlerToolStripMenuItem
            // 
            this.gelenlerToolStripMenuItem.Name = "gelenlerToolStripMenuItem";
            this.gelenlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gelenlerToolStripMenuItem.Text = "Gelenler";
            // 
            // yeniMesajYazToolStripMenuItem
            // 
            this.yeniMesajYazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toTeacherToolStripMenuItem,
            this.toTeacherToolStripMenuItem1,
            this.toStudentToolStripMenuItem});
            this.yeniMesajYazToolStripMenuItem.Name = "yeniMesajYazToolStripMenuItem";
            this.yeniMesajYazToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniMesajYazToolStripMenuItem.Text = "Yeni mesaj yaz";
            // 
            // toTeacherToolStripMenuItem
            // 
            this.toTeacherToolStripMenuItem.Name = "toTeacherToolStripMenuItem";
            this.toTeacherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toTeacherToolStripMenuItem.Text = "To Teacher";
            // 
            // toTeacherToolStripMenuItem1
            // 
            this.toTeacherToolStripMenuItem1.Name = "toTeacherToolStripMenuItem1";
            this.toTeacherToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toTeacherToolStripMenuItem1.Text = "To Mentor";
            this.toTeacherToolStripMenuItem1.Click += new System.EventHandler(this.toTeacherToolStripMenuItem1_Click);
            // 
            // toStudentToolStripMenuItem
            // 
            this.toStudentToolStripMenuItem.Name = "toStudentToolStripMenuItem";
            this.toStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toStudentToolStripMenuItem.Text = "To Student";
            // 
            // teacherListToolStripMenuItem
            // 
            this.teacherListToolStripMenuItem.Name = "teacherListToolStripMenuItem";
            this.teacherListToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.teacherListToolStripMenuItem.Text = "Teacher List Onclick New Form";
            // 
            // mentorListToolStripMenuItem
            // 
            this.mentorListToolStripMenuItem.Name = "mentorListToolStripMenuItem";
            this.mentorListToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.mentorListToolStripMenuItem.Text = "Mentor List Onclick New Form";
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addResourseToolStripMenuItem,
            this.deleteResourseToolStripMenuItem,
            this.showResourcesToolStripMenuItem});
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.libraryToolStripMenuItem.Text = "Library";
            // 
            // addResourseToolStripMenuItem
            // 
            this.addResourseToolStripMenuItem.Name = "addResourseToolStripMenuItem";
            this.addResourseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addResourseToolStripMenuItem.Text = "Add Resourse";
            // 
            // deleteResourseToolStripMenuItem
            // 
            this.deleteResourseToolStripMenuItem.Name = "deleteResourseToolStripMenuItem";
            this.deleteResourseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteResourseToolStripMenuItem.Text = "Delete Resourse";
            // 
            // showResourcesToolStripMenuItem
            // 
            this.showResourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qaynaqlarinLinklerionlineQaynaqlardirsaToolStripMenuItem,
            this.downloadFilepdfFormatdadirsaToolStripMenuItem});
            this.showResourcesToolStripMenuItem.Name = "showResourcesToolStripMenuItem";
            this.showResourcesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showResourcesToolStripMenuItem.Text = "Show Resources";
            // 
            // qaynaqlarinLinklerionlineQaynaqlardirsaToolStripMenuItem
            // 
            this.qaynaqlarinLinklerionlineQaynaqlardirsaToolStripMenuItem.Name = "qaynaqlarinLinklerionlineQaynaqlardirsaToolStripMenuItem";
            this.qaynaqlarinLinklerionlineQaynaqlardirsaToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.qaynaqlarinLinklerionlineQaynaqlardirsaToolStripMenuItem.Text = "Qaynaqlarin linkleri (online qaynaqlardirsa)";
            // 
            // downloadFilepdfFormatdadirsaToolStripMenuItem
            // 
            this.downloadFilepdfFormatdadirsaToolStripMenuItem.Name = "downloadFilepdfFormatdadirsaToolStripMenuItem";
            this.downloadFilepdfFormatdadirsaToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.downloadFilepdfFormatdadirsaToolStripMenuItem.Text = "Download File  (pdf formatdadirsa)";
            // 
            // tasklarinSiyahisToolStripMenuItem
            // 
            this.tasklarinSiyahisToolStripMenuItem.Name = "tasklarinSiyahisToolStripMenuItem";
            this.tasklarinSiyahisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tasklarinSiyahisToolStripMenuItem.Text = "Tasklarin siyahis";
            // 
            // MentorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MentorForm";
            this.Text = "MentorForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesajlarimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gonderilenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMesajYazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toTeacherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem workMatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasklarinSiyahisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentorListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addResourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteResourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showResourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qaynaqlarinLinklerionlineQaynaqlardirsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadFilepdfFormatdadirsaToolStripMenuItem;
    }
}