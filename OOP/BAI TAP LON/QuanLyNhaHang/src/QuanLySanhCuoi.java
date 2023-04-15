import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class QuanLySanhCuoi {
    private List<SanhCuoi> dsSanhCuoi = new ArrayList<>();

    private QuanLyChoThue quanLyChoThue;
    public void themSanh(SanhCuoi... sanhCuois) {
        dsSanhCuoi.addAll(Arrays.asList(sanhCuois));
    }
    public SanhCuoi traCuuSanhTheoMa(String maSanh) {
        return dsSanhCuoi.stream().filter(sanh -> sanh.getMaSanh() == maSanh).findFirst().get();
    }

    public List<SanhCuoi> traCuuSanh(String ten) {
        return dsSanhCuoi.stream().filter(sanh -> sanh.getTenSanh().equals(ten)).collect(Collectors.toList());
    }
    public List<SanhCuoi> traCuuSanh(int sucChua) {
        return this.dsSanhCuoi.stream().filter(sanh -> sanh.getSucChua() == sucChua).collect(Collectors.toList());
    }
    public List<SanhCuoi> traCuuSanh(ViTriSanh viTriSanh) {
        return this.dsSanhCuoi.stream().filter(sanh -> sanh.getViTriSanh() == viTriSanh).collect(Collectors.toList());
    }

    public void xoaSanh(String ma) {
        this.dsSanhCuoi.removeIf(s -> s.getMaSanh() == ma);
    }

    public void sapXepTheoTanSoThue() {
        dsSanhCuoi.sort((sanhA, sanhB) -> Math.toIntExact(quanLyChoThue.tinhTanSo(sanhA) - quanLyChoThue.tinhTanSo(sanhB)));
    }

    public void hienThi(){
        System.out.printf("%-20s%-20s%-20s%-20d","Mã sảnh", "Tên sảnh", "Vị trí", "Sức chứa");
        this.dsSanhCuoi.forEach(sanh -> sanh.hienThi());
    }

    public void hienThiTheoTanSo() {
        dsSanhCuoi.forEach(sanh -> {
            System.out.println("Danh sách tên sảnh - tần số thuê:");
            System.out.printf("%-20s%-20s", sanh.getTenSanh(), quanLyChoThue.tinhTanSo(sanh));
        });
    }

    public List<SanhCuoi> getDsSanhCuoi() {
        return dsSanhCuoi;
    }
    public void setDsSanhCuoi(List<SanhCuoi> dsSanhCuoi) {
        this.dsSanhCuoi = dsSanhCuoi;
    }

    public void setQuanLyChoThue(QuanLyChoThue quanLyChoThue) {
        this.quanLyChoThue = quanLyChoThue;
    }
}
