import java.text.ParseException;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;


//Thay đổi cấu trúc uml:
//Sửa hienThi() của mỗi dịch vụ
//Bỏ cập nhật trong quanlyanuong, chuyển cho DoAnUong, thiết kế capNhat theo polymorphism
//Thêm tracuuanuong bằng tên
//Thêm enum thoidiemhthue, vitrisanh
public class Demo {
    public static void main(String[] args) throws ParseException {
        int choose;
        SanhCuoi s1 = new SanhCuoi("Diamonds",ViTriSanh.TANG_1,50);
        SanhCuoi s2 = new SanhCuoi("Golden", ViTriSanh.TANG_1,40);
        SanhCuoi s3 = new SanhCuoi("Silver",ViTriSanh.TANG_2,30);

        QuanLySanhCuoi qlySanhCuoi = new QuanLySanhCuoi();
        QuanLyDichVu qlyDichVu = new QuanLyDichVu();
        QuanLyAnUong qlyAnUong = new QuanLyAnUong();
        QuanLyMenu qlyMenu = new QuanLyMenu();
        QuanLyChoThue qlyChoThue = new QuanLyChoThue();
        qlySanhCuoi.themSanh(s1,s2,s3);

        do{
            System.out.println("=============== CHỨC NĂNG ================");
            System.out.println("1. Quản lý thông tin sảnh cưới");
            System.out.println("2. Quản lý thông tin dịch vụ");
            System.out.println("3. Quản lý thông tin thức ăn, thức uống");
            System.out.println("4. Quản lý cho thuê sảnh");
            System.out.println("5. Quản lý menu");
            System.out.println("6. Xuất hóa đơn");
            System.out.println("7. Báo cáo doanh thu");
            System.out.println("0. Thoát");
            System.out.println("==========================================");
            System.out.print("Nhập sự lựa chọn: ");
            choose = CauHinh.sc.nextInt();
            switch(choose){
                case 1:
                    do{
                        System.out.println("\n\n1. Thêm sảnh cưới");
                        System.out.println("2. Cập nhật thông tin sảnh cưới");
                        System.out.println("3. Xóa sảnh cưới");
                        System.out.println("4. Tra cứu theo tên sảnh");
                        System.out.println("5. Tra cứu theo sức chứa sảnh");
                        System.out.println("6. Tra cứu theo vị trí sảnh");
                        System.out.println("7. Hiển thị tất cả sảnh cưới");
                        System.out.println("8. Sắp xếp sảnh cưới theo tần số được thuê");
                        System.out.println("9. Hiển thị tên sảnh và tần số tương ứng");
                        System.out.println("0. Thoát");
                        System.out.print("\nNhập sự lựa chọn: ");
                        choose = CauHinh.sc.nextInt();
                        switch(choose) {
                            case 1: {
                                System.out.print("Nhập tên sảnh: ");
                                String ten = CauHinh.sc.nextLine();
                                System.out.print("Nhập vị trí sảnh(1/2): ");
                                ViTriSanh tang = ViTriSanh.values()[Integer.parseInt(CauHinh.sc.nextLine())];
                                System.out.print("Nhập vào sức chứa: ");
                                int sucChua = Integer.parseInt(CauHinh.sc.nextLine());
                                qlySanhCuoi.themSanh(new SanhCuoi(ten, tang, sucChua));
                                break;
                            }
                            case 2: {
                                qlySanhCuoi.hienThi();
                                System.out.print("\n\nNhập mã sảnh để cập nhật: ");
                                String ma = CauHinh.sc.nextLine();
                                var sanh = qlySanhCuoi.traCuuSanhTheoMa(ma);
                                System.out.println("Chọn thuộc tính để cập nhật: ");
                                System.out.print("1. Tên Sảnh\n2. Vị trí\n3.Sức chứa\n4. Cả 3");
                                System.out.print("Chọn: ");
                                int chon = Integer.parseInt(CauHinh.sc.nextLine());
                                switch (chon) {
                                    case 1:
                                        System.out.print("Tên sảnh mới: ");
                                        sanh.capNhat(CauHinh.sc.nextLine());
                                        break;
                                    case 2:
                                        System.out.print("Vị trí sảnh mới (1-2): ");
                                        sanh.capNhat(ViTriSanh.values()[Integer.parseInt(CauHinh.sc.nextLine())]);
                                        break;
                                    case 3:
                                        System.out.print("Sức chứa mới: ");
                                        sanh.capNhat(Integer.parseInt(CauHinh.sc.nextLine()));
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            }
                            case 3: {
                                qlySanhCuoi.hienThi();
                                System.out.print("\n\nNhap ma sanh can xoa: ");
                                qlySanhCuoi.xoaSanh(CauHinh.sc.nextLine());
                                break;
                            }
                            case 4: {
                                System.out.print("Nhập tên sảnh cần tra cứu: ");
                                var dsSanh = qlySanhCuoi.traCuuSanh(CauHinh.sc.nextLine());
                                System.out.printf("%-20s%-20s%-20s%-20d", "Mã sảnh", "Tên sảnh", "Vị trí", "Sức chứa");
                                dsSanh.forEach(SanhCuoi::hienThi);
                                break;
                            }
                            case 5: {
                                System.out.print("Nhập sức chứa sảnh cần tra cứu: ");
                                var dsSanh = qlySanhCuoi.traCuuSanh(Integer.parseInt(CauHinh.sc.nextLine()));
                                System.out.printf("%-20s%-20s%-20s%-20d", "Mã sảnh", "Tên sảnh", "Vị trí", "Sức chứa");
                                dsSanh.forEach(SanhCuoi::hienThi);
                                break;
                            }
                            case 6: {
                                System.out.print("Nhập vị trí sảnh cần tra cứu (1-2): ");
                                var dsSanh = qlySanhCuoi.traCuuSanh(ViTriSanh.values()[Integer.parseInt(CauHinh.sc.nextLine())]);
                                System.out.printf("%-20s%-20s%-20s%-20d", "Mã sảnh", "Tên sảnh", "Vị trí", "Sức chứa");
                                dsSanh.forEach(SanhCuoi::hienThi);
                                break;
                            }
                            case 7:
                                qlySanhCuoi.hienThi();
                                break;
                            case 8:
                                qlySanhCuoi.sapXepTheoTanSoThue();
                                break;
                            case 9:
                                qlySanhCuoi.hienThiTheoTanSo();
                                break;
                            case 0:
                                choose = 0;
                                break;
                            default:
                                System.out.println("Không có lựa chọn này!");
                                break;
                        }
                    }while(choose != 0);
                    break;
                case 2:
                    do{
                        System.out.println("\n\n1. Thêm dịch vụ");
                        System.out.println("2. Cập nhật dịch vụ");
                        System.out.println("3. Xóa dịch vụ");
                        System.out.println("4. Tra cứu theo tên dịch vụ");
                        System.out.println("5. Hiển thị tất cả dịch vụ");
                        System.out.println("0. Thoát");
                        System.out.print("\nNhập sự lựa chọn: ");
                        choose = Integer.parseInt(CauHinh.sc.nextLine()) ;
                        switch(choose) {
                            case 1: {
                                int option;
                                do {
                                    System.out.print("Nhập tên dịch vụ: ");
                                    String ten = CauHinh.sc.nextLine();
                                    System.out.print("Nhập giá dịch vụ: ");
                                    double gia = Double.parseDouble(CauHinh.sc.nextLine());
                                    System.out.print("Chọn loại dịch vụ: ");
                                    System.out.printf("1. Dịch vụ Karaoke\n2. Dịch vụ thuê ca sĩ\n3. Dịch vụ trang trí");
                                    System.out.print("Chọn: ");
                                    option = Integer.parseInt(CauHinh.sc.nextLine());
                                    DichVu dv;
                                    switch (option) {
                                        case 1: {
                                            System.out.print("Thời gian thuê (phút): ");
                                            double tg = Double.parseDouble(CauHinh.sc.nextLine());
                                            dv = new DvKaraoke(ten, gia, tg);
                                            qlyDichVu.themDVu(dv);

                                            break;
                                        }
                                        case 2: {
                                            System.out.print("Tên ca sĩ: ");
                                            String name = CauHinh.sc.nextLine();
                                            System.out.print("Số bài hát: ");
                                            int soBH = Integer.parseInt(CauHinh.sc.nextLine());
                                            dv = new DvThueCaSi(ten, gia, name, soBH);
                                            qlyDichVu.themDVu(dv);

                                            break;
                                        }
                                        case 3: {
                                            dv = new DvTrangTri(ten, gia);
                                            qlyDichVu.themDVu(dv);

                                            break;
                                        }
                                        case 0: {
                                            option = 0;
                                            break;
                                        }
                                        default:
                                            System.out.println("Không có lựa chọn này!");
                                            break;
                                    }
                                } while (option != 0);
                                break;
                            }
                            case 2: {
                                qlyDichVu.hienThi();
                                System.out.print("\n\nNhập mã dịch vụ để cập nhật: ");
                                String ma = CauHinh.sc.nextLine();
                                DichVu dv = qlyDichVu.traCuuTheoMa(ma);
                                dv.capNhat();
                                break;
                            }
                            case 3: {
                                qlyDichVu.hienThi();
                                System.out.print("\n\nNhập mã dịch vụ cần xoá: ");
                                qlyDichVu.xoaDVu(CauHinh.sc.nextLine());
                                break;
                            }
                            case 4: {
                                System.out.print("Nhập tên dịch vụ cần tra cứu: ");
                                var dsSanh = qlyDichVu.traCuuDichVu(CauHinh.sc.nextLine());
                                System.out.printf("%-20s%-20s%-18.2f\n", "Mã dịch vụ: ", "Tên dịch vụ: ", "Giá dịch vụ: ");
                                dsSanh.forEach(DichVu::hienThi);
                                break;
                            }
                            case 5: {
                                System.out.printf("%-20s%-20s%-20s%-20d\n", "Mã dịch vụ", "Tên dịch vụ", "Giá dịch vụ");
                                qlyDichVu.hienThi();
                                break;
                            }
                            case 0:
                                choose = 0;
                                break;
                            default:
                                System.out.println("Không có lựa chọn này!");
                                break;
                        }
                    }while(choose != 0);
                    break;
                case 3:
                    do{
                        System.out.println("\n\n1. Thêm đồ ăn uống");
                        System.out.println("2. Cập nhật đồ ăn uống");
                        System.out.println("3. Xóa đồ ăn uống");
                        System.out.println("4. Tra cứu đồ ăn uống");
                        System.out.println("5. Hiển thị tất cả đồ ăn uống");
                        System.out.println("0. Thoát");
                        System.out.print("\nNhập sự lựa chọn: ");
                        choose = Integer.parseInt(CauHinh.sc.nextLine()) ;
                        switch(choose) {
                            case 1: {
                                int option;
                                do {
                                    System.out.print("Nhập tên đồ ăn uống: ");
                                    String ten = CauHinh.sc.nextLine();
                                    System.out.print("Nhập giá đồ ăn uống: ");
                                    double gia = Double.parseDouble(CauHinh.sc.nextLine());
                                    System.out.print("Chọn loại đồ ăn uống: ");
                                    System.out.print("1. Thức ăn\n2. Thức uống\n");
                                    System.out.print("Chọn: ");
                                    option = Integer.parseInt(CauHinh.sc.nextLine());
                                    DoAnUong doAnUong;
                                    switch (option) {
                                        case 1: {
                                            System.out.print("Ăn chay được không(1-0): ");
                                            boolean isAnChay = Boolean.parseBoolean(CauHinh.sc.nextLine());
                                            doAnUong = new ThucAn(ten, gia, isAnChay);
                                            qlyAnUong.themDoAnUong(doAnUong);
                                            break;
                                        }
                                        case 2: {
                                            System.out.print("Hãng sản xuất: ");
                                            String name = CauHinh.sc.nextLine();
                                            doAnUong = new ThucUong(ten, gia, name);
                                            qlyAnUong.themDoAnUong(doAnUong);
                                            break;
                                        }
                                        case 0: {
                                            option = 0;
                                            break;
                                        }
                                        default:
                                            System.out.println("Không có lựa chọn này!");
                                            break;
                                    }
                                } while (option != 0);
                                break;
                            }
                            case 2: {
                                qlyAnUong.hienThi();
                                System.out.print("\n\nNhập mã đồ ăn (uống) để cập nhật: ");
                                int ma = Integer.parseInt( CauHinh.sc.nextLine());
                                DoAnUong dau = qlyAnUong.traCuuAnUong(ma);
                                dau.capNhat();
                                break;
                            }
                            case 3: {
                                qlyAnUong.hienThi();
                                System.out.print("\n\nNhập mã đồ ăn (uống) cần xoá: ");
                                qlyAnUong.xoaDoAnUong(Integer.parseInt( CauHinh.sc.nextLine()));
                                break;
                            }
                            case 4: {
                                System.out.print("Nhập tên đồ ăn (uống) cần tra cứu: ");
                                var dsDAU = qlyAnUong.traCuuAnUong(CauHinh.sc.nextLine());
                                System.out.printf("%-20s%-20s%-20s\n", "Mã đồ ăn (uống): ", "Tên đồ ăn (uống): ", "Giá đồ ăn (uống): ");
                                dsDAU.forEach(DoAnUong::hienThi);
                                break;
                            }
                            case 5: {
                                qlyAnUong.hienThi();
                                break;
                            }
                            case 0:
                                choose = 0;
                                break;
                            default:
                                System.out.println("Không có lựa chọn này!");
                                break;
                        }
                    }while(choose != 0);
                    break;
                case 4:
                    do{
                        System.out.println("\n\n1. Cho thuê sảnh");
                        System.out.println("0. Thoát");
                        System.out.print("\nNhập sự lựa chọn: ");
                        choose = Integer.parseInt(CauHinh.sc.nextLine()) ;
                        switch(choose) {
                            case 1: {
                                Boolean thoat = false;
                                do {
                                    System.out.print("Nhập thông tin cho thuê: ");
                                    System.out.print("Nhập tên bữa tiệc: ");
                                    String tenTiec = CauHinh.sc.nextLine();
                                    qlySanhCuoi.hienThi();
                                    System.out.print("\nNhập mã sảnh cần thuê: ");
                                    SanhCuoi sanh = qlySanhCuoi.traCuuSanhTheoMa(CauHinh.sc.nextLine());
                                    System.out.print("Nhập đơn giá thuê sảnh: ");
                                    double donGiaThue = Double.parseDouble(CauHinh.sc.nextLine());
                                    System.out.print("Nhập thời điểm thuê (1-Sáng, 2-Chiều, 3-Tối): ");
                                    ThoiDiemThue thoiDiem = ThoiDiemThue.values()[Integer.parseInt(CauHinh.sc.nextLine())];
                                    System.out.print("Nhập ngày thuê (dd-MM-yyyy): ");
                                    Date ngayThue = CauHinh.f.parse(CauHinh.sc.nextLine());
                                    qlyMenu.hienThi();
                                    List<Integer> ma = new ArrayList<>();
                                    Boolean thoatTrong = false;
                                    do {
                                        System.out.print("Nhập mã menu cần đặt: ");
                                        ma.add(Integer.parseInt(CauHinh.sc.nextLine()));
                                        System.out.println("Thoát? (0-1): ");
                                        thoat = Boolean.parseBoolean(CauHinh.sc.nextLine());
                                    } while (!thoatTrong);
                                    var dsMenu = ma.stream().map(qlyMenu::traCuuMenu).toList();
                                    qlyDichVu.hienThi();
                                    List<String> ma2 = new ArrayList<>();
                                    thoat = false;
                                    do {
                                        System.out.print("Nhập mã dịch vụ cần đặt: ");
                                        ma2.add(CauHinh.sc.nextLine());
                                        System.out.println("Thoát? (0-1): ");
                                        thoat = Boolean.parseBoolean(CauHinh.sc.nextLine());
                                    } while (!thoatTrong);
                                    var dsDV = ma2.stream().map(qlyDichVu::traCuuTheoMa).toList();
                                    qlyChoThue.themChoThue(new ChoThueSanh(tenTiec, sanh, donGiaThue, thoiDiem, ngayThue, dsMenu, dsDV));
                                    System.out.print("Nhập tiếp việc cho thuê? (0-1): ");
                                    thoat = Boolean.parseBoolean(CauHinh.sc.nextLine());
                                } while (!thoat);
                                break;
                            }
                            case 0:
                                choose = 0;
                                break;
                            default:
                                System.out.println("Không có lựa chọn này!");
                                break;
                        }
                    }while(choose != 0);
                    break;
                case 5: {
                    boolean thoat = false;
                    do {
                        System.out.println("Nhập menu mới: ");
                        boolean thoatTrong = false;
                        List<Integer> dsMaAnUong = new ArrayList<>();
                        qlyAnUong.hienThi();
                        do {
                            System.out.print("Nhập mã đồ ăn (uống) trong menu");
                            dsMaAnUong.add(Integer.parseInt(CauHinh.sc.nextLine()));
                            System.out.println("Nhập tiếp đồ ăn uống? (0-1): ");
                            thoatTrong = Boolean.parseBoolean(CauHinh.sc.nextLine());
                        } while (!thoatTrong);
                        MenuBuoiTiec menu = new MenuBuoiTiec(dsMaAnUong.stream().map(ma -> qlyAnUong.traCuuAnUong(ma)).toList());
                        qlyMenu.themMenu(menu);
                        System.out.println("Nhập tiếp menu? (0-1): ");
                        thoat = Boolean.parseBoolean(CauHinh.sc.nextLine());
                    } while (!thoat);
                    break;
                }
                case 6: {
                    boolean thoat = false;

                }
                case 0:
                    break;
                default:
                    System.out.print("Lỗi.Vui lòng chọn lại!!!");
            }
        }while(choose != 0);
    }
}
