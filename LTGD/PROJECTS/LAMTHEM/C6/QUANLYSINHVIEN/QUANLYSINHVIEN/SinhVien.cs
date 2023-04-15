using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN
{
    internal class SinhVien
    {
        private string mSSV;
        private string ho;
        private string ten;

        public SinhVien()
        {
        }

        public SinhVien(string mSSV, string ho, string ten)
        {
            this.mSSV = mSSV;
            this.Ho = ho;
            this.Ten = ten;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Ho { get => ho; set => ho = value; }
        public string MSSV { get => mSSV; set => mSSV = value; }
    }
}
