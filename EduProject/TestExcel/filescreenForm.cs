using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TestExcel.ModelExcel;

namespace TestExcel
{
    public partial class filescreenForm : Form
    {



        OpenFileDialog dbxChooseFile = new OpenFileDialog();
        TextBox tbxUserName = new TextBox();
        TextBox tbxUserAge = new TextBox();
        PictureBox pbxUserImage = new PictureBox();
        Button btnChooseFile = new Button();
        static string rootDirectory = Directory.GetCurrentDirectory();
        string uploadFolderPath = Path.Combine(rootDirectory, "Uploads");
        EducationProjectEntitiesExcel db = new EducationProjectEntitiesExcel();
        public filescreenForm()
        {
            InitializeComponent();


            Directory.CreateDirectory(uploadFolderPath);

            dbxChooseFile.Title = "Choose Filze";
            dbxChooseFile.InitialDirectory = rootDirectory;



            tbxUserName.Top = 20;
            tbxUserName.Left = 20;


            tbxUserAge.Top = 45;
            tbxUserAge.Left = 20;


            pbxUserImage.Left = 200;
            pbxUserImage.Top = 20;
            pbxUserImage.Width = 400;
            pbxUserImage.Height = 600;
            pbxUserImage.SizeMode = PictureBoxSizeMode.StretchImage;

            btnChooseFile.Text = "Choose File";
            btnChooseFile.AutoSize = true;
            btnChooseFile.Top = 70;
            btnChooseFile.Left = 20;

            btnChooseFile.Click += openFileDialog;
            Controls.Add(tbxUserName);
            Controls.Add(tbxUserAge);
            Controls.Add(pbxUserImage);
            Controls.Add(btnChooseFile);
        }

        private void openFileDialog(object sender, EventArgs e)
        {

            if (dbxChooseFile.ShowDialog() == DialogResult.OK)
            {
                //pbxUserImage.Image = Image.FromFile(dbxChooseFile.FileName);

                string soursePath = dbxChooseFile.FileName;
                string fileName = Path.GetFileName(soursePath);

                string destinationPath = uploadFolderPath;
                File.Copy(soursePath, Path.Combine(destinationPath, fileName), true);
                pbxUserImage.Image = Image.FromFile(Path.Combine(destinationPath, fileName));
                ExcelTable excel = new ExcelTable()
                {
                    BookName = tbxUserName.Text,
                    BookPrice = Convert.ToInt32(tbxUserAge.Text),
                    BookExcel = Path.Combine(@"\Uploads", fileName)

                };

                db.ExcelTables.Add(excel);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Try again");
            }

            //MessageBox.Show(dbxChooseFile.ShowDialog().ToString());

        }
        private void filescreenForm_Load(object sender, EventArgs e)
        {

        }
    }



}
