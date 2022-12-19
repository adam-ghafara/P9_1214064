using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_1214064.model
{
    internal class m_nilai
    {
        string matkul, kategori, npm, nilai;

        public string Matkul { get => matkul; set => matkul = value; }
        public string Kategori { get => kategori; set => kategori = value; }
        public string Npm { get => npm; set => npm = value; }
        public string Nilai { get => nilai; set => nilai = value; }

        public m_nilai(string matkul, string kategori, string npm, string nilai)
        {
            this.Matkul = matkul;
            this.Kategori = kategori;
            this.Npm = npm;
            this.Nilai = nilai;
        }

        public m_nilai()
        {

        }
    }
}
