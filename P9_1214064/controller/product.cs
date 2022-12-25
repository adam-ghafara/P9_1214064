using P9_1214064.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1214064.controller
{
    class product
    {
        connection koneksi = new connection();

        public bool Insert(m_product product)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_barang (nama_barang,harga) VALUES ('" 
                    + product.Nama_produk + "','" + product.Harga + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return status;
        }
        public bool Update(m_product product, string id_barang)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_barang SET nama_barang='"
                    + product.Nama_produk + "'," + "harga='" + product.Harga
                    + "' WHERE id_barang='" + id_barang + "'");
                status = true;
                MessageBox.Show("Data berhasil di ubah", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return status;
        }
        public bool Delete(m_product product, string id_barang)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_barang WHERE id_barang='"
                    + id_barang + "'"); status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return status;
        }
    }
}
