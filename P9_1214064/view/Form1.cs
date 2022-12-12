using P9_1214064.controller;
using P9_1214064.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P9_1214064
{
    public partial class Form1 : Form
    {
        connection koneksi = new connection();
        m_mahasiswa m_mhs = new m_mahasiswa();
        string id;

        public Form1()
        {
            InitializeComponent();
        }
        public void ShowConnect()
        {
            // Query DB
            dtvMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");

            // Mengubah Nama Kolom Tabel
            dtvMahasiswa.Columns[0].HeaderText = "NPM";
            dtvMahasiswa.Columns[1].HeaderText = "Nama";
            dtvMahasiswa.Columns[2].HeaderText = "Angkatan";
            dtvMahasiswa.Columns[3].HeaderText = "Alamat";
            dtvMahasiswa.Columns[4].HeaderText = "Email";
            dtvMahasiswa.Columns[5].HeaderText = "No HP";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowConnect();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (tbNpm.Text == "" || tbNama.Text == "" || cbAngkatan.SelectedIndex == -1 || rtbAlamat.Text == "" || tbEmail.Text == "" || tbNohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                mahasiswa mhs = new mahasiswa();
                m_mhs.Npm = tbNpm.Text;
                m_mhs.Nama = tbNama.Text;
                m_mhs.Angkatan = cbAngkatan.Text;
                m_mhs.Alamat = rtbAlamat.Text;
                m_mhs.Email = tbEmail.Text;
                m_mhs.Nohp = tbNohp.Text;

                mhs.Insert(m_mhs);

                tbNpm.Text = "";
                tbNama.Text = "";
                cbAngkatan.SelectedIndex = -1;
                rtbAlamat.Text = "";
                tbEmail.Text = "";
                tbNohp.Text = "";

                ShowConnect();

            }
        }

        private void dtvMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dtvMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNpm.Text = dtvMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNama.Text = dtvMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbAngkatan.Text = dtvMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            rtbAlamat.Text = dtvMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbEmail.Text = dtvMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbNohp.Text = dtvMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void btUbah_Click(object sender, EventArgs e)
        {
            if (tbNpm.Text == "" || tbNama.Text == "" || cbAngkatan.SelectedIndex == -1 || rtbAlamat.Text == "" || tbEmail.Text == "" || tbNohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                mahasiswa mhs = new mahasiswa();
                m_mhs.Npm = tbNpm.Text;
                m_mhs.Nama = tbNama.Text;
                m_mhs.Angkatan = cbAngkatan.Text;
                m_mhs.Alamat = rtbAlamat.Text;
                m_mhs.Email = tbEmail.Text;
                m_mhs.Nohp = tbNohp.Text;

                mhs.Update(m_mhs, id);

                tbNpm.Text = "";
                tbNama.Text = "";
                cbAngkatan.SelectedIndex = -1;
                rtbAlamat.Text = "";
                tbEmail.Text = "";
                tbNohp.Text = "";

                ShowConnect();

            }
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            tbNpm.Text = "";
            tbNama.Text = "";
            cbAngkatan.SelectedIndex = -1;
            rtbAlamat.Text = "";
            tbEmail.Text = "";
            tbNohp.Text = "";

            ShowConnect();
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            mahasiswa mhs = new mahasiswa();

            mhs.Delete(m_mhs, id);

            tbNpm.Text = "";
            tbNama.Text = "";
            cbAngkatan.SelectedIndex = -1;
            rtbAlamat.Text = "";
            tbEmail.Text = "";
            tbNohp.Text = "";

            ShowConnect();
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            dtvMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa WHERE npm LIKE '%' '" + tbFind.Text + "' '%' OR nama LIKE '%' '" + tbFind.Text + "' '%'");
        }
    }
}
