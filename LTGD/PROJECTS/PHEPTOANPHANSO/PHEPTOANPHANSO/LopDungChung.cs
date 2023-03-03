using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHEPTOANPHANSO
{
    internal class LopDungChung
    {
        public static int gcd(int x, int y)
        {
            if (y == 0) { return x; }
            return gcd(y, x % y);
        }
    }
}
