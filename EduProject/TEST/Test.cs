using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
         

        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var btn = new Button();

            btn.Text = "Add Task";
            panel1.Controls.Add(btn);
        }

        private void deleteTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var btn1 = new Button();
            panel1.Controls.Clear();
            btn1.Text = "Add Task";
            int a = 5;
            if (a==5)
            {
                for (int i = 0; i < 1; i++)
                {
                    panel1.Controls.Add(btn1);
                    Thread.Sleep(1000);
                    a = 4;
                }
            }
            
            if (a==4)
            {
                for (int i = 0; i < 1; i++)
                {
                    panel1.Controls.Clear();
                    Thread.Sleep(3000);
                    a = 5;
                }
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void sariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }
    }
}
