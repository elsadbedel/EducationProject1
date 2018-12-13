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
using System.IO;

namespace EduProject
{
    public partial class TeacherForm : Form
    {
        EducationProjectEntities2 db = new EducationProjectEntities2(); //Database//

        OpenFileDialog OpenFile = new OpenFileDialog();
        static string rootDirectory = Directory.GetCurrentDirectory();
        string uploadFolderPath = Path.Combine(rootDirectory, "Uploads");


        public TeacherForm()
        {
            InitializeComponent();
            //Upload ----------- Upload//
            Directory.CreateDirectory(uploadFolderPath);
            OpenFile.Title = "Choose File";
            OpenFile.InitialDirectory = rootDirectory;

        }

        private void Teacher_Load(object sender, EventArgs e)
        {
           
            ClearPanel();
        }

        private void BtnGoBack(Panel _btn)
        {
            Button btn = new Button() { Text="X"};
            btn.Top = 5;
            btn.Left = 5;
            btn.Height = 15;
            btn.Width = 15;
            btn.FlatStyle = FlatStyle.System;
            btn.Click += btnClick;
            _btn.Controls.Add(btn);
            
        }

        private void btnClick(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
        }

        private void ClearPanel()
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
            AddPanelForShow(PanelPersonalInfo);
            BtnGoBack(PanelPersonalInfo);
        }

        private void btnLibraryUpload_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                string soursePath = OpenFile.FileName;
                string fileName = Path.GetFileName(soursePath);
                string destinationPath = uploadFolderPath;

                File.Copy(soursePath, Path.Combine(destinationPath, fileName), true);

                string name = Path.GetFileName(fileName);
                string path = OpenFile.FileName;

                txtbLibraryItemName.Text = name;
                txtbLibraryItemUrl.Text = Path.Combine("Uploads", name);

            }
            else
            {
                MessageBox.Show("Try again");
            }


        }

        private void addResourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPanelForShow(panelLibrary);
            BtnGoBack(panelLibrary);
        }

        private void AddPanelForShow(Panel _panel)
        {
            MainPanel.Controls.Add(_panel);
        }

        private void panelLibrary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLibraryAdd_Click(object sender, EventArgs e)
        {
            if (txtbLibraryItemName.Text == "" || txtbLibraryItemUrl.Text == "" || txtbItemType.Text == "")
            {
                MessageBox.Show("Lütfen Bütün Xanaları Doldurun");
            }
            else
            {
                string message = "Sorğuların Doğruluğundan Eminsiniz?";
                string caption = "Sehv Bas verdi";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    // Message//
                    Library library = new Library()
                    {
                        LibraryItemName = txtbLibraryItemName.Text,
                        LibraryItemUrl = txtbLibraryItemUrl.Text,
                        LibraryItemType = txtbItemType.Text

                    };
                    db.Libraries.Add(library);
                    db.SaveChanges();
                    dgwLibrary.DataSource = db.Libraries.ToList();
                    MessageBox.Show("Resurs Ugurla Elave Edildi");
                }

            }

        }
    }
}
