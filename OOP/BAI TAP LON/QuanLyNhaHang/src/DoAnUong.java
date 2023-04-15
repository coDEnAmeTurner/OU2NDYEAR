public abstract class DoAnUong {
    private int maAnUong = ++dem;
    private String ten;
    private double gia;
    private static int dem = 0;
    public DoAnUong(String ten, double gia){
        this.setTen(ten);
        this.setGia(gia);
    }
    public void capNhat(){
        System.out.print("Nhap ten: ");
        this.setTen(CauHinh.sc.nextLine());
        System.out.print("Nhap gia: ");
        this.setGia(Double.parseDouble(CauHinh.sc.nextLine()));
    }
    public void hienThi(){
        System.out.printf("%-20s%-20s%-18.2f\n",this.maAnUong, this.ten, this.gia);
    }
    public int getMaAnUong() {
        return maAnUong;
    }

    public void setMaAnUong(int maAnUong) {
        this.maAnUong = maAnUong;
    }

    public String getTen() {
        return ten;
    }

    public void setTen(String ten) {
        this.ten = ten;
    }

    public double getGia() {
        return gia;
    }

    public void setGia(double gia) {
        this.gia = gia;
    }
}
