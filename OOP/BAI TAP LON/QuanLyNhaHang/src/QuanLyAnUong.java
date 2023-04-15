import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class QuanLyAnUong {
    private List<DoAnUong> dsAnUong = new ArrayList<>();
    public void themDoAnUong(DoAnUong ...a){
        this.getDsAnUong().addAll(Arrays.asList(a));
    }

    public void xoaDoAnUong(int id){
        this.getDsAnUong().removeIf(x -> (x.getMaAnUong() == id));
    }
    public DoAnUong traCuuAnUong(int ma){
        return this.dsAnUong.stream().filter(dau -> dau.getMaAnUong() == ma).findFirst().get();
    }
    public List<DoAnUong> traCuuAnUong(String ten){
        return this.dsAnUong.stream().filter(dau -> dau.getTen() == ten).collect(Collectors.toList());
    }
    public void hienThi(){
        System.out.printf("%-20s%-20s%-20s", "Mã đồ ăn (uống): ", "Tên đồ ăn (uống): ", "Giá đồ ăn (uống): ");
        this.getDsAnUong().forEach(a ->a.hienThi());
    }

    public List<DoAnUong> getDsAnUong() {
        return dsAnUong;
    }

    public void setDsAnUong(List<DoAnUong> dsAnUong) {
        this.dsAnUong = dsAnUong;
    }
}
