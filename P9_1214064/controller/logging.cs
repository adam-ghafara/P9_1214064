using MySql.Data.MySqlClient;
using P9_1214064.model;
using P9_1214064.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace P9_1214064.controller
{
    class logging
    {
        connection log = new connection();
        public bool Login(string User, string Pass)
        {
            try
            {
                log.OpenConnection();
                MySqlDataReader reader = log.reader("SELECT * FROM t_admin WHERE user='" +
                    (User) + "' AND pass='" + (Pass) + "'");
                if (reader.Read())
                {
                    log.CloseConnection();
                    return true;
                }
                else
                {
                    log.CloseConnection();
                    return false;
                }
            }
                    catch (Exception e)
                {
                log.CloseConnection();
                MessageBox.Show(e.Message, "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
        }
        
    }
}
