import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class QuanLyChoThue {
    private List<ChoThueSanh> dsChoThue = new ArrayList<>();

    public void themChoThue(ChoThueSanh... choThueSanh) {
        dsChoThue.addAll(Arrays.asList(choThueSanh));
    }

    public long tinhTanSo(SanhCuoi sanhCuoi) {
        return dsChoThue.stream().filter(s -> s.equals(sanhCuoi)).count();
    }

    public List<SanhCuoi> traCuuSanh (int nam) {
        return dsChoThue.stream().filter(choThue -> choThue.getNgayThue().getYear() == nam).map(ChoThueSanh::getSanhThue).toList();
    }
}
