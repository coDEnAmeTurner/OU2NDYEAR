public class DvKaraoke extends DichVu{
    private double thoiGianThue;
    public DvKaraoke(String ten, double gia, double thoiGian){
        super(ten, gia);
        this.setThoiGianThue(thoiGian);
    }
    public void capNhat(){
        super.capNhat();
        System.out.print("Nhap thoi gian thue (0 để thoát): ");
        this.thoiGianThue = Double.parseDouble(CauHinh.sc.nextLine());

    }

    @Override
    public void hienThi(){
        super.hienThi();
        System.out.printf("%18.2f\n", this.getThoiGianThue());
    }

    public double getThoiGianThue() {
        return thoiGianThue;
    }

    public void setThoiGianThue(double thoiGianThue) {
        this.thoiGianThue = thoiGianThue;
    }
}
