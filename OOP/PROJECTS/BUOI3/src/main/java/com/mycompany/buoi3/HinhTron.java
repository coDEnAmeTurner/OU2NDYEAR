/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.buoi3;

/**
 *
 * @author Admin
 */
public class HinhTron {
    private Diem tamDiem;
    private double banKinh;

    public HinhTron(Diem tamDiem, double banKinh) throws Exception {
        if (banKinh <= 0)
            throw new Exception ("Ban kinh phai >= 0");
        this.tamDiem = tamDiem;
        this.banKinh = banKinh;
    }

    /**
     * @return the tamDiem
     */
    public Diem getTamDiem() {
        return tamDiem;
    }

    /**
     * @param tamDiem the tamDiem to set
     */
    public void setTamDiem(Diem tamDiem) {
        this.tamDiem = tamDiem;
    }

    /**
     * @return the banKinh
     */
    public double getBanKinh() {
        return banKinh;
    }

    /**
     * @param banKinh the banKinh to set
     */
    public void setBanKinh(double banKinh) {
        this.banKinh = banKinh;
    }
    
    public double tinhDienTich()
    {
        return Math.pow(banKinh, 2) * Math.PI;
    }
    
    public double tinhChuVi()
    {
        return banKinh * 2 * Math.PI;
    }
    
    public void timViTriTuongDoi(Diem a)
    {
        double kcDenTam = tamDiem.tinhKhoangCach(a);
        double e = 0.00000001;
        if (Math.abs(kcDenTam - banKinh) < e)
            System.out.println("Diem nam tren duoung tron");
        else if (kcDenTam - banKinh < 0)
            System.out.println("Diem nam trong duong tron");
        else
            System.out.println("Diem nam ngoai duong tron");
            
    }
    
}
