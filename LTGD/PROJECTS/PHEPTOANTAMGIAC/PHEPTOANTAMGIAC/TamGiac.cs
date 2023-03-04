namespace PHEPTOANTAMGIAC
{
    internal class TamGiac
    {
        private double canhA;
        private double canhB;
        private double canhC;

        public TamGiac(double canhA, double canhB, double canhC)
        {
            try
            {
                if (canhA + canhB > canhC && canhB + canhC > canhA && canhA + canhC > canhB) 
                    throw new ArgumentException("Tổng 2 cạnh bất kỳ phải lớn hơn cạnh còn lại");
                this.canhA = canhA;
                this.canhB = canhB;
                this.canhC = canhC;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public double CanhA { 
            get { return canhA; } 
            set { canhA = value; }
        }

        public double CanhB
        {
            get { return canhB; }
            set { canhB = value; }
        }

        public double CanhC
        {
            get { return canhC; }
            set { canhC = value; }
        }

        public double tinhChuVi()
        {
            return canhA + canhB + canhC;
        }

        public double tinhDienTich()
        {
            double chuvi = tinhChuVi();
            return Math.Sqrt(chuvi * (chuvi - canhA) *(chuvi - canhB) * (chuvi - canhC));
        }

        public TamGiacType checkTamGiacType()
        {
            if (canhA != canhB && canhB != canhC && canhC != CanhA)
                return TamGiacType.thuong;
            else if ()
        }
    }
}
