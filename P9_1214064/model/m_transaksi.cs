using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_1214064.model
{
    internal class m_transaksi
    {
        string id_barang, quantity;

        public string Id_barang { get => id_barang; set => id_barang = value; }
        public string Quantity { get => quantity; set => quantity = value; }

        public m_transaksi(string id_barang, string quantity)
        {
            this.Id_barang = id_barang;
            this.Quantity = quantity;
        }

        public m_transaksi()
        {

        }
    }
}
