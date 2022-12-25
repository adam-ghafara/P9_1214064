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
    public partial class FormProduct : Form
    {
        connection koneksi = new connection();
        m_product product = new m_product();
        string id_barang;
        public FormProduct()
        {
            InitializeComponent();
        }
        public void ShowConnect()
        {
            // Query DB
            dtvProduk.DataSource = koneksi.ShowData("SELECT * FROM t_barang");

            // Mengubah Nama Kolom Tabel
            dtvProduk.Columns[0].HeaderText = "ID";
            dtvProduk.Columns[1].HeaderText = "Nama Barang";
            dtvProduk.Columns[2].HeaderText = "Harga";

        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            ShowConnect();
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (tbProduct.Text == "" | tbHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                product prod = new product();
                product.Nama_produk = tbProduct.Text;
                product.Harga = tbHarga.Text;

                prod.Insert(product);

                tbProduct.Text = "";
                tbHarga.Text = "";

                ShowConnect();

            }
        }

        private void btUbah_Click(object sender, EventArgs e)
        {
            if (tbProduct.Text == "" | tbHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                product prod = new product();
                product.Nama_produk = tbProduct.Text;
                product.Harga = tbHarga.Text;

                prod.Update(product, id_barang);

                tbProduct.Text = "";
                tbHarga.Text = "";

                ShowConnect();
            }
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            product prod = new product();
            prod.Delete(product, id_barang);

            tbProduct.Text = "";
            tbHarga.Text = "";

            ShowConnect();
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            id_barang = "";
            tbProduct.Text = "";
            tbHarga.Text = "";
            ShowConnect();
        }

        private void dtvProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_barang = dtvProduk.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbProduct.Text = dtvProduk.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbHarga.Text = dtvProduk.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            dtvProduk.DataSource = koneksi.ShowData("SELECT * FROM t_barang WHERE id_barang LIKE '%" + tbFind.Text + "%' "
                + "OR nama_barang LIKE '%" + tbFind.Text + "%'");
        }
    }
}
