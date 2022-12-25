using MySql.Data.MySqlClient;
using Org.BouncyCastle.Security.Certificates;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P9_1214064.view
{
    public partial class FormTransaction : Form
    {
        connection koneksi = new connection();
        m_transaksi transaction = new m_transaksi();
        string id_transaksi;
        public FormTransaction()
        {
            InitializeComponent();
        }
        public void ShowConnect()
        {
            // Query DB
            dtvTransaksi.DataSource = koneksi.ShowData("SELECT " + "id_transaksi, t_transaksi.id_barang, nama_barang, harga, qty, total"
                + " FROM t_transaksi JOIN t_barang ON t_barang.id_barang = t_transaksi.id_barang");

            // Mengubah Nama Kolom Tabel
            dtvTransaksi.Columns[0].HeaderText = "ID";
            dtvTransaksi.Columns[1].HeaderText = "ID Barang";
            dtvTransaksi.Columns[2].HeaderText = "Nama Barang";
            dtvTransaksi.Columns[3].HeaderText = "Harga";
            dtvTransaksi.Columns[4].HeaderText = "Quantity";
            dtvTransaksi.Columns[5].HeaderText = "Total";

        }
        public void GetDataProduct()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_barang");
            while (reader.Read())
            {
                string productlist = reader.GetString("id_barang");
                cbID.Items.Add(productlist);
            }
            koneksi.CloseConnection();
        }
        private void FormTransaction_Load(object sender, EventArgs e)
        {
            ShowConnect();
            GetDataProduct();
        }

        private void dtvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = dtvTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbID.Text = dtvTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbProduct.Text = dtvTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbHarga.Text = dtvTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbQuantity.Text = dtvTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbTotal.Text = dtvTransaksi.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        public void GetDataNamaProduk()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT nama_barang, harga FROM t_barang " +
                "WHERE id_barang= '" + cbID.Text + "'");
            while (reader.Read())
            {
                tbProduct.Text = reader.GetString(0);
                tbHarga.Text = reader.GetString(1);
            }
            koneksi.CloseConnection();
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbQuantity.Text, "  ^ [0-9]"))
            {
                e.Handled = true;
            }
        }
        public void PriceOperator()
        {
            int price = int.Parse(tbHarga.Text);
            int quantity = int.Parse(tbQuantity.Text);
            tbTotal.Text = (price * quantity).ToString();
        }
        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataNamaProduk();
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

        }
        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            cbID.SelectedIndex = -1;
            tbProduct.Text = "";
            tbHarga.Text = "";
            tbQuantity.Text = "";
            tbTotal.Text = "";

            ShowConnect();
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (cbID.SelectedIndex == -1 || tbProduct.Text == "" || tbHarga.Text == "" || tbQuantity.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                transaksi trans = new transaksi();
                transaction.Id_barang = cbID.Text;
                transaction.Quantity = tbQuantity.Text;

                trans.Insert(transaction);

                cbID.SelectedIndex = -1;
                tbProduct.Text = "";
                tbHarga.Text = "";
                tbQuantity.Text = "";
                tbTotal.Text = "";

                ShowConnect();

            }
        }

        private void btUbah_Click(object sender, EventArgs e)
        {
            if (cbID.SelectedIndex == -1 || tbProduct.Text == "" || tbHarga.Text == "" || tbQuantity.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                transaksi trans = new transaksi();
                transaction.Id_barang = cbID.Text;
                transaction.Quantity = tbQuantity.Text;


                trans.Update(transaction, id_transaksi);

                cbID.SelectedIndex = -1;
                tbProduct.Text = "";
                tbHarga.Text = "";
                tbQuantity.Text = "";
                tbTotal.Text = "";

                ShowConnect();

            }
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            if (cbID.SelectedIndex == -1 || tbProduct.Text == "" || tbHarga.Text == "" || tbQuantity.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                transaksi trans = new transaksi();
                trans.Delete(transaction, id_transaksi);

                cbID.SelectedIndex = -1;
                tbProduct.Text = "";
                tbHarga.Text = "";
                tbQuantity.Text = "";
                tbTotal.Text = "";

                ShowConnect();

            }
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            dtvTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi,nama_barang FROM t_transaksi JOIN t_barang WHERE id_transaksi LIKE '%"
                                                    + tbFind.Text + "%' "
                                                    + "OR nama_barang LIKE '%" + tbFind.Text + "%'");
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            PriceOperator();
            if (System.Text.RegularExpressions.Regex.IsMatch(tbQuantity.Text, "  ^ [0-9]"))
            {
                tbQuantity.Text = "";
            }
        }

        private void nudQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            PriceOperator();
        }
    }
}
