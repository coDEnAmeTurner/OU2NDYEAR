using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HINHTRON
{
    internal class Diem
    {
        private double x;
        private double y;

        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get { return x; } set { x = value; } }

        public double Y { get { return y; } set { y = value; } }

        public double tinhKC(Diem p1)
        {
            return Math.Sqrt(Math.Pow(p1.x - x, 2) + Math.Pow(p1.y - y, 2));
        }
    }
}
