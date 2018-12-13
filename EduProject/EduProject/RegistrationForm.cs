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
    public partial class RegistrationForm : Form
    {
        EducationProjectEntities2 db = new EducationProjectEntities2();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegitrationForm_Load(object sender, EventArgs e)
        {
            if (cmbxRegistrationChooseUserType.Text == "")
            {
                cmbxRegistrationChooseUserType.Text = "Choose User Type";
            }
            foreach (var item in db.UserTypes.ToList())
            {
                cmbxRegistrationChooseUserType.Items.Add(item.UserTypeName);
            }

        }

        private void cmbxRegistrationChooseUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrationFullControl_Click(object sender, EventArgs e)
        {
            var form = new AdminFullControl();
            form.Show();

        }

        private void btnRegistrationBack_Click(object sender, EventArgs e)
        {
            var form = new HomePage();
            form.Show();

        }
    }
}
