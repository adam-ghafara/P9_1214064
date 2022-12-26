using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1214064.view
{
    public partial class FstartUp : Form
    {
        public FstartUp()
        {
            InitializeComponent();
        }

        private void appTimer_Tick(object sender, EventArgs e)
        {
            LoginForm logfor = new LoginForm();
            progressBar1.Value += 5;
            if (progressBar1.Value == 100)
            {
                appTimer.Dispose();
                Hide();
                logfor.Show();
            }
        }
    }
}
