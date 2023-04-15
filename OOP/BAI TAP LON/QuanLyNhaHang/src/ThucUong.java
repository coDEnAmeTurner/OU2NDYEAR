public class ThucUong extends DoAnUong{
    private String hangSanXuat;
    public ThucUong(String ten, double gia, String hangSX){
        super(ten, gia);
        this.hangSanXuat = hangSX;
    }

    @Override
    public void hienThi(){
        super.hienThi();
        System.out.printf("%-20s\n", hangSanXuat);
    }

    @Override
    public void capNhat(){
        super.capNhat();
        System.out.print("Nhap hang san xuat: ");
        this.hangSanXuat = CauHinh.sc.nextLine();
    }
    public String getHangSanXuat() {
        return hangSanXuat;
    }

    public void setHangSanXuat(String hangSanXuat) {
        this.hangSanXuat = hangSanXuat;
    }
}
