using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_1214064.model
{
    internal class m_product
    {
        string nama_produk, harga;

        public string Nama_produk { get => nama_produk; set => nama_produk = value; }
        public string Harga { get => harga; set => harga = value; }

        public m_product(string nama_produk, string harga)
        {
            this.Nama_produk = nama_produk;
            this.Harga = harga;
        }

        public m_product()
        {

        }
    }
}
