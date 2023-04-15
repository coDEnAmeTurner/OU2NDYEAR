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
                {
                    this.canhA = canhA;
                    this.canhB = canhB;
                    this.canhC = canhC;
                }
                else
                    throw new ArgumentException("Tổng 2 cạnh bất kỳ phải lớn hơn cạnh còn lại");

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

        public static bool isTamGiac(double a, double b, double c)
        {
            if (a + b > c && b + c > a && a + c > b)
                return true; 
            return false;
        }

        public double tinhChuVi()
        {
            return canhA + canhB + canhC;
        }

        public double tinhDienTich()
        {
            double chuvi = tinhChuVi();
            return Math.Sqrt(chuvi * (chuvi - canhA) * (chuvi - canhB) * (chuvi - canhC));
        }

        public TamGiacType checkTamGiacType()
        {
            if (canhA == canhB || canhB == canhC || canhA == canhC)
                return TamGiacType.CAN;
            else if (canhA == canhB && canhB == canhC)
                return TamGiacType.DEU;
            else if (Math.Pow(canhA, 2) + Math.Pow(canhB, 2) == Math.Pow(CanhC, 2) || Math.Pow(canhB, 2) + Math.Pow(canhC, 2) == Math.Pow(CanhA, 2) 
                || Math.Pow(canhA, 2) + Math.Pow(canhC, 2) == Math.Pow(CanhB, 2))
                return TamGiacType.VUONG;
            else 
                return TamGiacType.THUONG;
        }

    }
}
