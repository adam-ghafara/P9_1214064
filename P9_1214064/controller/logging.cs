using P9_1214064.model;
using P9_1214064.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1214064.controller
{
    class logging
    {
        connection log = new connection();
        Dashboard dash = new Dashboard();
        //public void Login(logsys logging)
        //{
        //    try
        //    {
        //        log.OpenConnection();
        //        log.ExecuteQuery("SELECT * FROM t_admin WHERE user='" + (logging.User) + "AND pass='" + (logging.Pass));
        //        if (log)
        //        {
        //            MessageBox.Show("Login Berhasil", "Informasi",
        //                MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            logscreen.Close();
        //            dash.Show();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Username atau Password salah, masukkan kembali dengan benar.","Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        }
        //        log.CloseConnection();
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //}
        
    }
}
