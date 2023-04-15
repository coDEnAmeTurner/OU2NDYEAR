import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class MenuBuoiTiec {
    private static int dem = 0;
    private int maMenu;
    private List<DoAnUong> dsDoAnUong = new ArrayList<>();
    {
        maMenu = ++dem;
    }
    public MenuBuoiTiec(DoAnUong... doAnUong) {
        this.dsDoAnUong.addAll(Arrays.asList(doAnUong));
    }
    public MenuBuoiTiec(List<DoAnUong> doAnUong) {
        this.dsDoAnUong.addAll(doAnUong);
    }
    public double tinhGia() {
        return dsDoAnUong.stream().map(dau -> dau.getGia()).reduce(Double.valueOf(0.0), (sum, gia) -> sum += gia);
    }
    public void hienThi(){
        this.dsDoAnUong.forEach(DoAnUong::hienThi);
    }
    public List<DoAnUong> getDsDoAnUong() {
        return dsDoAnUong;
    }

    public int getMaMenu() {
        return maMenu;
    }

}

