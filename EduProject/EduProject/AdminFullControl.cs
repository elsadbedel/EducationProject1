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
    public partial class AdminFullControl : Form
    {
        public AdminFullControl()
        {
            InitializeComponent();
        }

        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TeacherInfo();
            form.ShowDialog();
        }

        private void teacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
