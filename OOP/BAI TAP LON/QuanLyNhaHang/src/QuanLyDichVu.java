import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class QuanLyDichVu {
    private List<DichVu> dsDVu = new ArrayList<>();
    public void themDVu(DichVu ...a){
        this.getDsDVu().addAll(Arrays.asList(a));
    }
    public void xoaDVu(String maDv){
        this.dsDVu.removeIf(d->d.getMaDV().equals(maDv));
    }

    public DichVu traCuuTheoMa(String ma) {
        return this.dsDVu.stream().filter(dv -> dv.getMaDV() == ma).findFirst().get();
    }
    public List<DichVu> traCuuDichVu(String tenDv){
        return this.dsDVu.stream().filter(d->d.getTenDV().equals(tenDv)).collect(Collectors.toList());
    }
    public void hienThi(){
        System.out.printf("%-20s%-20s%-20d", "Mã dịch vụ", "Tên dịch vụ", "Giá dịch vụ");
        this.dsDVu.forEach(d->d.hienThi());
    }

    public List<DichVu> getDsDVu() {
        return dsDVu;
    }

    public void setDsDVu(List<DichVu> dsDVu) {
        this.dsDVu = dsDVu;
    }
}
