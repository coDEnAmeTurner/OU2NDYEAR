import java.awt.*;
import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class QuanLyMenu {
    private List<MenuBuoiTiec> dsMenu = new ArrayList<>();

    public void hienThi() {
        System.out.printf("%-20s%-20s%-20s\n", "Mã đồ ăn (uống): ", "Tên: ", "Giá: ");
        dsMenu.forEach(MenuBuoiTiec::hienThi);
    }

    public void themMenu(MenuBuoiTiec... menu)  {
        dsMenu.addAll(Arrays.asList(menu));
    }

    public MenuBuoiTiec traCuuMenu(int ma) {
        return dsMenu.stream().filter(menu -> menu.getMaMenu() == ma).findFirst().get();
    }
}
