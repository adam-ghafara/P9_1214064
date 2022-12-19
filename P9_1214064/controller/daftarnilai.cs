using P9_1214064.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1214064.controller
{
    internal class daftarnilai
    {
        connection koneksi = new connection();

        public bool Insert(m_nilai daftarnilai)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_nilai (matkul,kategori,npm,nilai) VALUES ('" + daftarnilai.Matkul + "','" + daftarnilai.Kategori + "','" + daftarnilai.Npm + "','" + daftarnilai.Nilai + "')");
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
        public bool Update(m_nilai daftarnilai, string id_nilai)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_nilai SET matkul='" + daftarnilai.Matkul + "'," + "kategori='" + daftarnilai.Kategori + "'," + "npm='" + daftarnilai.Npm + "'," + "nilai='" + daftarnilai.Nilai + "'" + " WHERE id_nilai='" + id_nilai + "'"); status = true;
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
        public bool Delete(m_nilai daftarnilai, string id_nilai)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_nilai WHERE id_nilai='" + id_nilai + "'"); status = true;
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
