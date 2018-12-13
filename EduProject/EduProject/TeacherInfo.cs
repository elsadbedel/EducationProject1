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

    public partial class TeacherInfo : Form
    {
        EducationProjectEntities2 db = new EducationProjectEntities2();
        public TeacherInfo()
        {
            InitializeComponent();
        }



        private void TeacherInfo_Load(object sender, EventArgs e)
        {
            ListTeachers();
        }

        public void ListTeachers()
        {
            foreach (var item in db.Teachers.ToList())
            {
                cmbxTeacherList.Items.Add(item.TeacherName.ToString());
            }
        }

        private void cmbxTeacherList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
