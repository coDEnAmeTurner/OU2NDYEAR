//class DanhSachChoThue
public int tinhTanSo(SanhThue sanhThue) {
    int count = 0;
    for (var sanh : dsST) {
        if (sanh.equals(sanhThue))
            count++;
    }
    return count;
}

//class QuanLySanhCuoi  - da co instance DanhSachSanhThue
public void sapXep() {
    for (int i = 0; i < qlSC.Length() - 1; i++) {
        int max = instDSST.tinhTanSo(qlSC[0]);
        for (int j = 1; j < qlSC.Length(); j++) {
            if (instDSST.tinhTanSo(qlSC[j]) > max) {
                max = instDSST.tinhTanSo(qlSC[j]);
                swap(qlSC[i], qlSC[j]);
            }
        }
    }
}