public class SanhCuoi {
    private String maSanh;
    private String tenSanh;
    private ViTriSanh viTriSanh;
    private int sucChua;
    private static int dem = 0;
    {
        maSanh = String.format("S%03d",++dem);
    }

    public SanhCuoi(String tenSanh, ViTriSanh viTriSanh, int sucChua) {
        this.tenSanh = tenSanh;
        this.viTriSanh = viTriSanh;
        this.sucChua = sucChua;
    }

    public void hienThi() {
        //System.out.printf("Ma sanh: %s\nTen sanh: %s\nVi tri sanh: %s\nSuc chua: %d ban\n", maSanh, tenSanh, viTriSanh, sucChua);
        System.out.printf("%-20s%-20s%-20s%-20d",this.maSanh,this.tenSanh,this.viTriSanh,this.sucChua);
    }

    public void capNhat(String tenSanh) {
        setTenSanh(tenSanh);
    }

    public void capNhat(ViTriSanh viTriSanh) {
        setViTriSanh(viTriSanh);
    }

    public void capNhat(int sucChua) {
        setSucChua(sucChua);
    }

    @Override
    public boolean equals(Object obj) {
        SanhCuoi sanhCuoi = (SanhCuoi) obj;
        return this.maSanh.equals(sanhCuoi.maSanh) && this.tenSanh.equals(sanhCuoi.tenSanh)
                && this.viTriSanh == sanhCuoi.viTriSanh && this.sucChua == sanhCuoi.sucChua;
    }

    public String getMaSanh() {
        return maSanh;
    }

    public void setMaSanh(String maSanh) {
        this.maSanh = maSanh;
    }

    public String getTenSanh() {
        return tenSanh;
    }

    public void setTenSanh(String tenSanh) {
        this.tenSanh = tenSanh;
    }

    public ViTriSanh getViTriSanh() {
        return viTriSanh;
    }

    public void setViTriSanh(ViTriSanh viTriSanh) {
        this.viTriSanh = viTriSanh;
    }

    public int getSucChua() {
        return sucChua;
    }

    public void setSucChua(int sucChua) {
        this.sucChua = sucChua;
    }
}

