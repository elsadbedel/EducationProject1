namespace EduProject
{
    partial class TeacherInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherInfo));
            this.cmbxTeacherList = new System.Windows.Forms.ComboBox();
            this.cmbxGroupList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblChooseGroup = new System.Windows.Forms.Label();
            this.lblChooseTeacher = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxTeacherList
            // 
            this.cmbxTeacherList.FormattingEnabled = true;
            this.cmbxTeacherList.Location = new System.Drawing.Point(152, 19);
            this.cmbxTeacherList.Name = "cmbxTeacherList";
            this.cmbxTeacherList.Size = new System.Drawing.Size(121, 21);
            this.cmbxTeacherList.TabIndex = 0;
            this.cmbxTeacherList.SelectedIndexChanged += new System.EventHandler(this.cmbxTeacherList_SelectedIndexChanged);
            // 
            // cmbxGroupList
            // 
            this.cmbxGroupList.FormattingEnabled = true;
            this.cmbxGroupList.Location = new System.Drawing.Point(152, 46);
            this.cmbxGroupList.Name = "cmbxGroupList";
            this.cmbxGroupList.Size = new System.Drawing.Size(121, 21);
            this.cmbxGroupList.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblChooseGroup);
            this.groupBox1.Controls.Add(this.lblChooseTeacher);
            this.groupBox1.Controls.Add(this.cmbxGroupList);
            this.groupBox1.Controls.Add(this.cmbxTeacherList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 83);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Type";
            // 
            // lblChooseGroup
            // 
            this.lblChooseGroup.AutoSize = true;
            this.lblChooseGroup.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChooseGroup.Location = new System.Drawing.Point(32, 46);
            this.lblChooseGroup.Name = "lblChooseGroup";
            this.lblChooseGroup.Size = new System.Drawing.Size(114, 19);
            this.lblChooseGroup.TabIndex = 4;
            this.lblChooseGroup.Text = "Choose Group :";
            // 
            // lblChooseTeacher
            // 
            this.lblChooseTeacher.AutoSize = true;
            this.lblChooseTeacher.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChooseTeacher.Location = new System.Drawing.Point(22, 19);
            this.lblChooseTeacher.Name = "lblChooseTeacher";
            this.lblChooseTeacher.Size = new System.Drawing.Size(124, 19);
            this.lblChooseTeacher.TabIndex = 3;
            this.lblChooseTeacher.Text = "Choose Teacher :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 268);
            this.dataGridView1.TabIndex = 3;
            // 
            // TeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(657, 387);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherInfo";
            this.Text = "TeacherInfo";
            this.Load += new System.EventHandler(this.TeacherInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxTeacherList;
        private System.Windows.Forms.ComboBox cmbxGroupList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblChooseGroup;
        private System.Windows.Forms.Label lblChooseTeacher;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}