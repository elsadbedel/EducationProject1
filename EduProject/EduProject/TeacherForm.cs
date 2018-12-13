using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EduProject.Model;

namespace EduProject
{
    public partial class TeacherForm : Form
    {
        EducationProject01Entities db = new EducationProject01Entities();
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
        }

        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var taskForm = new TaskForm();
            taskForm.Show();
        }

        private void TeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //LocalStorage.homePage.Close();
        }


        private void btnRegistrationFullControl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yep");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtPicture.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher()
            {

            };
            foreach (var item in db.Teachers.ToList())
            {
                item.TeacherPhoto = txtPicture.Text;

                if (item.TeacherName == "Samir")
                {
                    item.TeacherPhoto = txtPicture.Text;
                    MessageBox.Show("Saved");
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("fail");
                }
            }

        }

        private void editButunMelumatlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(SecondPanel);
        }

        private void btnLibraryUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            
            if (openFile.ShowDialog()==DialogResult.OK)
            {
                openFile.ShowDialog();
                string path = openFile.FileName;

                txtbLibraryItemUrl.Text = path;
            }
        }

        private void addResourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(panelLibrary);
        }
    }
}
