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
    public partial class RegitrationForm : Form
    {
        public RegitrationForm()
        {
            InitializeComponent();
        }

        private void RegitrationForm_Load(object sender, EventArgs e)
        {
            cmbxRegistrationChooseUserType.Items.Insert(0, "Choose User Type");
            cmbxRegistrationChooseUserType.SelectedIndex = 0;
        }
    }
}
