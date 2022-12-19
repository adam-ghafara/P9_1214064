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
            dtvNilai.DataSource = koneksi.ShowData("SELECT * FROM t_nilai");

            // Mengubah Nama Kolom Tabel
            dtvNilai.Columns[0].HeaderText = "Mata Kuliah";
            dtvNilai.Columns[1].HeaderText = "Kategori";
            dtvNilai.Columns[2].HeaderText = "NPM";
            dtvNilai.Columns[3].HeaderText = "Nilai";

        }
        private void FormNilai_Load(object sender, EventArgs e)
        {
            ShowConnect();
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
            dtvNilai.DataSource = koneksi.ShowData("SELECT * FROM t_nilai WHERE kategori LIKE '%' '" + tbFind.Text + "' '%' OR npm LIKE '%' '" + tbFind.Text + "' '%'");

        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            cbMatkul.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;
            cbNPM.SelectedIndex = -1;
            tbNilai.Text = "";


            ShowConnect();
        }
    }
}
