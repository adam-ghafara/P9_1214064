using P9_1214064.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1214064.controller
{
    internal class transaksi
    {
        connection koneksi = new connection();

        public bool Insert(m_transaksi transaksi)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_transaksi (id_barang,qty,total) VALUES ('"
                    + transaksi.Id_barang + "','" + transaksi.Quantity + "')");
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
        public bool Update(m_transaksi transaksi, string id_transaksi)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_transaksi SET id_barang='"
                    + transaksi.Id_barang + "'," + "qty='"
                    + transaksi.Quantity + "' WHERE id_transaksi='" + id_transaksi + "'");
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
        public bool Delete(m_transaksi transaksi, string id_transaksi)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE * FROM t_transaksi WHERE id_transaksi='"
                    + id_transaksi + "'"); status = true;
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
