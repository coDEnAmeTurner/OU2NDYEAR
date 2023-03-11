using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HINHTRON
{
    internal class HinhTron
    {
        private Diem tam;
        private double r;

        public HinhTron(Diem tam, double r)
        {
            if (r < 0) throw new ArgumentException("Ban kinh la so thuc duong");
            this.tam = tam;
            this.r = r;
        }

        public double R { get => r; set => r = value; }

        public Diem Tam { get => tam; set => tam = value; }

        public double tinhS()
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        public double tinhCV() { 
            return 2 * Math.PI * r;
        }

        public ViTriDiem ktViTriDiem(Diem p)
        {
            double kcDenTam = p.tinhKC(tam);
            double e = 0.000001;

            if (Math.Abs(kcDenTam - r) < e)
            {
                return ViTriDiem.TRENDUONGTRON;
            }
            else if (kcDenTam < r)
            {
                return ViTriDiem.NAMTRONG;
            }
            else
            {
                return ViTriDiem.NAMNGOAI;
            }
        }
    }
}
