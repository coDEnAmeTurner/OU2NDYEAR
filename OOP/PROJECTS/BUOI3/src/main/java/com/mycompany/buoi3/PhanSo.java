/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.buoi3;

/**
 *
 * @author Admin
 */
public class PhanSo {
    private int tu;
    private int mau;
    private static int soPhanSo;
    
    static {
        soPhanSo = 0;
    }
    
    public PhanSo() {
        this(0, 1);
    }
    
    public PhanSo(int tu, int mau) {
        try {
            if (mau == 0)
                throw new ArithmeticException("Ko dc chia cho 0");
            this.tu = tu;
            this.mau = mau;
            soPhanSo++;
        }
        catch (ArithmeticException ex) {
            System.out.println(ex.getMessage());
        }
    }
    
    public static int timUCLN(int a, int b) {
        if (b == 0) return a;
        return timUCLN(b, a % b);
    }

    /**
     * @return the tu
     */
    public int getTu() {
        return tu;
    }

    /**
     * @param tu the tu to set
     */
    public void setTu(int tu) {
        this.tu = tu;
    }

    /**
     * @return the mau
     */
    public int getMau() {
        return mau;
    }

    /**
     * @param mau the mau to set
     */
    public void setMau(int mau) {
        this.mau = mau;
    }
    
    private void rutGon() {
        int ucln = timUCLN(tu, mau);
        tu /= ucln;
        mau /= ucln;
    }
    
    public PhanSo cong(PhanSo p1) {
        var kq = new PhanSo(tu * p1.mau + mau * p1.tu, mau * p1.mau);
        kq.rutGon();
        return kq;
    }
    
    public PhanSo tru(PhanSo p1) {
        PhanSo kq = new PhanSo(tu * p1.mau - mau * p1.tu, mau * p1.mau);
        kq.rutGon();
        return kq;
    }
    
    public PhanSo nhan(PhanSo p1) {
        PhanSo kq = new PhanSo(tu * p1.tu, mau * p1.mau);
        kq.rutGon();
        return kq;
    }
    
    public PhanSo chia (PhanSo p1) {
        PhanSo kq = new PhanSo(tu * p1.mau, mau * p1.tu);
        kq.rutGon();
        return kq;
    }
    
    public int soSanh(PhanSo p1) {
        rutGon();
        p1.rutGon();
        int diff = tu * p1.mau - mau * p1.tu;
        if (diff < 0)
            return -1;
        else if (diff == 0)
            return 0;
        else
            return 1;
    }
    
    public void hienThi() {
        System.out.printf("%d/%d", tu, mau);
    }
}
