﻿using System;
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
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnHomePageRegistration_Click(object sender, EventArgs e)
        {
            var formRegistration = new RegitrationForm();
            formRegistration.Show();
        }
    }
}
