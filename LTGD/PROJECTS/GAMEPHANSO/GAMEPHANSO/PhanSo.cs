using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMEPHANSO
{
    internal class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }
        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo; this.mauSo = mauSo != 0 ? mauSo : 1;
        }

        public int TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }

        public int MauSo
        {
            get { return mauSo; }
            set { mauSo = value; }
        }

        private void toiGian()
        {
            int ucln = LopDungChung.gcd(tuSo, mauSo);
            if (ucln == 0) { return; }
            tuSo /= ucln;
            mauSo /= ucln;
        }

        public static PhanSo cong(PhanSo phanso, PhanSo phanso1)
        {
            var kq = new PhanSo(phanso.tuSo * phanso1.mauSo + phanso.mauSo * phanso1.tuSo, phanso.mauSo * phanso1.mauSo);
            kq.toiGian();
            return kq;
        }

        public static PhanSo nhan(PhanSo phanso, PhanSo phanso1)
        {
            var kq = new PhanSo(phanso.tuSo * phanso1.tuSo, phanso.mauSo * phanso1.mauSo); kq.toiGian();
            return kq;
        }

        public static PhanSo tru(PhanSo phanso, PhanSo phanso1)
        {
            var kq = new PhanSo(phanso.tuSo * phanso1.mauSo - phanso.mauSo * phanso1.tuSo, phanso.mauSo * phanso1.mauSo);
            kq.toiGian();
            return kq;
        }

        public static PhanSo chia(PhanSo phanso, PhanSo phanso1)
        {
            var kq = PhanSo.nhan(phanso, new PhanSo(phanso1.mauSo, phanso1.tuSo));
            kq.toiGian();
            return kq;
        }

        public static bool isBang(PhanSo phanso, PhanSo phanso1)
        {
               phanso.toiGian();
                phanso1.toiGian();

                return phanso.tuSo == phanso1.tuSo && phanso.mauSo == phanso1.mauSo;
        }
    }
}
