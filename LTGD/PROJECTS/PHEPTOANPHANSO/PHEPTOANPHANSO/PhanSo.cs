namespace PHEPTOANPHANSO
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

        public PhanSo cong (PhanSo phanso1)
        {
            var kq = new PhanSo(tuSo * phanso1.mauSo + mauSo * phanso1.tuSo, mauSo * phanso1.mauSo);
            kq.toiGian();
            return kq;
        }

        public PhanSo nhan (PhanSo phanso1)
        {
            var kq = new PhanSo(tuSo * phanso1.tuSo, mauSo * phanso1.mauSo); kq.toiGian();
            return kq;
        }

        public PhanSo tru (PhanSo phanso1)
        {
            var kq = new PhanSo(tuSo * phanso1.mauSo - mauSo * phanso1.tuSo, mauSo * phanso1.mauSo);
            kq.toiGian();
            return kq;
        }

        public PhanSo chia (PhanSo phanso1)
        {
            var kq = nhan(new PhanSo(phanso1.mauSo, phanso1.tuSo));
            kq.toiGian();
            return kq;
        }
    }
}
