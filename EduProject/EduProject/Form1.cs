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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TeacherInfo();
            form.ShowDialog();
        }

        
    }
}
