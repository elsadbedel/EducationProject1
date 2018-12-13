using EduProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduProject
{
    public partial class HomePage : Form
    {
        EducationProjectEntities2 db = new EducationProjectEntities2();

        public HomePage()
        {
            InitializeComponent();
        }

        private void btnHomePageRegistration_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

            cmbxHomePAgeUserType.Items.Clear();

            if (cmbxHomePAgeUserType.Text == "")
            {
                cmbxHomePAgeUserType.Text = "Choose User Type";
            }

            foreach (var item in db.UserTypes)
            {
                cmbxHomePAgeUserType.Items.Add(item.UserTypeName);
            }
        }

        private void btnHomePageLogin_Click(object sender, EventArgs e)
        {
            switch (cmbxHomePAgeUserType.SelectedItem.ToString())
            {
                case "Teacher":
                    //LocalStorage.homePage = this;
                    TeacherForm teacher = new TeacherForm();
                    teacher.Show();
                    //this.Hide();
                    break;
                case "Mentor":
                    var form3 = new MentorForm();
                    form3.Show();
                    break;
                case "Student":
                    var form4 = new StudentForm();
                    form4.Show();
                    break;
                case "Admin":
                    var form1 = new RegistrationForm();
                    form1.Show();
                    break;
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbxHomePAgeUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
