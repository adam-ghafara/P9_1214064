﻿using MySql.Data.MySqlClient;
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
    public partial class FormNilai : Form
    {
        connection koneksi = new connection();
        m_nilai penilai = new m_nilai();
        string id_nilai;
        public FormNilai()
        {
            InitializeComponent();
        }

        public void ShowConnect()
        {
            // Query DB
            dtvNilai.DataSource = koneksi.ShowData("SELECT " + "id_nilai, matkul, kategori, t_nilai.npm, nama, nilai "
                    + "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");

            // Mengubah Nama Kolom Tabel
            dtvNilai.Columns[0].HeaderText = "ID";
            dtvNilai.Columns[1].HeaderText = "Mata Kuliah";
            dtvNilai.Columns[2].HeaderText = "Kategori";
            dtvNilai.Columns[3].HeaderText = "NPM";
            dtvNilai.Columns[4].HeaderText = "Nama";
            dtvNilai.Columns[5].HeaderText = "Nilai";

        }

        public void GetDataMhs()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_mahasiswa");
            while (reader.Read())
            {
                tbSiswa.Text = reader.GetString("npm");
            }
            koneksi.CloseConnection();
        }
        private void FormNilai_Load(object sender, EventArgs e)
        {
            ShowConnect();
            GetDataMhs();
        }

        private void dtvNilai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_nilai = dtvNilai.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbMatkul.Text = dtvNilai.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbCategory.Text = dtvNilai.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbNPM.Text = dtvNilai.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbNilai.Text = dtvNilai.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (cbMatkul.SelectedIndex == -1 || cbCategory.SelectedIndex == -1 || cbNPM.SelectedIndex == -1 || tbNilai.Text == "" )
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                daftarnilai nilai = new daftarnilai();
                penilai.Matkul = cbMatkul.Text;
                penilai.Kategori = cbCategory.Text;
                penilai.Npm = cbNPM.Text;
                penilai.Nilai = tbNilai.Text;

                nilai.Insert(penilai);

                cbMatkul.SelectedIndex = -1;
                cbCategory.SelectedIndex = -1;
                cbNPM.SelectedIndex = -1;
                tbNilai.Text = "";


                ShowConnect();

            }
        }

        private void btUbah_Click(object sender, EventArgs e)
        {
            if (cbMatkul.SelectedIndex == -1 || cbCategory.SelectedIndex == -1 || cbNPM.SelectedIndex == -1 || tbNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                daftarnilai nilai = new daftarnilai();
                penilai.Matkul = cbMatkul.Text;
                penilai.Kategori = cbCategory.Text;
                penilai.Npm = cbNPM.Text;
                penilai.Nilai = tbNilai.Text;

                nilai.Update(penilai, id_nilai);

                cbMatkul.SelectedIndex = -1;
                cbCategory.SelectedIndex = -1;
                cbNPM.SelectedIndex = -1;
                tbNilai.Text = "";


                ShowConnect();

            }
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            daftarnilai nilai = new daftarnilai();

            nilai.Delete(penilai, id_nilai);

            cbMatkul.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;
            cbNPM.SelectedIndex = -1;
            tbNilai.Text = "";


            ShowConnect();

        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            dtvNilai.DataSource = koneksi.ShowData("SELECT " +
                    "id_nilai, matkul, kategori, t_nilai.npm, nama, nilai "
                    + "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm"
                    + "WHERE t_nilai.npm LIKE '%" + tbFind.Text + "%' " + "OR matkul LIKE '%"
                    + tbFind.Text + "%'");

        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            cbMatkul.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;
            cbNPM.SelectedIndex = -1;
            tbNilai.Text = "";
            tbSiswa.Text = "";


            ShowConnect();
        }

        public void GetNamaMhs()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT nama FROM t_mahasiswa " +
                "WHERE npm= '" + cbNPM.Text + "'");
            while (reader.Read())
            {
                    tbSiswa.Text = reader.GetString(0);
            }
            koneksi.CloseConnection();  
        }

        private void cbNPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNamaMhs();
        }
    }
}
