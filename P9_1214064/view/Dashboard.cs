﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace P9_1214064.view
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NPM : 1214064" +
                "\n Nama : Adam Ghafara" +
                "\n Kelas : 2C" +
                "\n Github : https://github.com/adam-ghafara/P9_1214064", "About Me",MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Form dt_mhs = new Form1();
        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt_mhs.Show();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
