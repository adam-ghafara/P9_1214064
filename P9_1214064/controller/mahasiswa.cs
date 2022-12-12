using P9_1214064.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P9_1214064.controller
{
    internal class mahasiswa
    {
        connection koneksi = new connection();

        public bool Insert(m_mahasiswa mahasiswa)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_mahasiswa (npm,nama,angkatan,alamat,email,nohp) VALUES ('" + mahasiswa.Npm + "','" + mahasiswa.Nama + "','" + mahasiswa.Angkatan + "','" + mahasiswa.Alamat + "','" + mahasiswa.Email + "','" + mahasiswa.Nohp + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return status;
        }
        public bool Update(m_mahasiswa mahasiswa, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_mahasiswa SET npm='" + mahasiswa.Npm + "'," + "nama='" + mahasiswa.Nama + "'," + "angkatan='" + mahasiswa.Angkatan + "'," + "alamat='" + mahasiswa.Alamat + "'," + "email='" + mahasiswa.Email + "'," + "nohp='" + mahasiswa.Nohp + "' WHERE npm='" + id + "'"); status = true;
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
        public bool Delete(m_mahasiswa mahasiswa, string npm)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_mahasiswa WHERE npm='" + npm + "'"); status = true;
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
