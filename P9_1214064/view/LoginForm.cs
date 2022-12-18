using MySql.Data.MySqlClient;
using P9_1214064.controller;
using P9_1214064.model;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string connectionstring = "datasource=127.0.0.1;port=3306;Uid=root;pwd=;database=ulbi;";
        public void logon()
        {
            string query = "SELECT * FROM t_admin WHERE user='" + (tbUsername.Text) + "AND pass='" + (tbPassword.Text);

            // Connecting MySql Database
            MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Login Berhasil", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard dash = new Dashboard();
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah, masukkan kembali dengan benar.", 
                        "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Wrong, Please Try again.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "")
            {
                if (tbPassword.Text != "")
                {
                    logon();
                }
                else
                {

                    MessageBox.Show("Passowrd Harus Di isi", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Username harus di isi", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
