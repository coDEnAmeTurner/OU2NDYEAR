import javax.swing.text.StyledEditorKit;

public class ThucAn extends DoAnUong {
    private boolean isChay;
    public ThucAn(String ten , double gia, boolean isChay){
        super(ten, gia);
        this.isChay = isChay;
    }
    @Override
    public void hienThi(){
        super.hienThi();
        System.out.printf("%-20s\n", (isChay()) ? "Chay" : "Khong Chay");
    }

    public boolean isChay() {
        return isChay;
    }

    @Override
    public void capNhat(){
        super.capNhat();
        System.out.print("Co an chay duoc khong (0-1)");
        this.isChay = Boolean.parseBoolean(CauHinh.sc.nextLine());
    }

    public void setChay(boolean chay) {
        isChay = chay;
    }
}
