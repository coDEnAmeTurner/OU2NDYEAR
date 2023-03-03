/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.buoi3;

/**
 *
 * @author Admin
 */
public class HinhChuNhat {
    private Diem trenTrai;
    private Diem duoiPhai;

    public HinhChuNhat(Diem trenTrai, Diem duoiPhai) throws Exception {
        if (duoiPhai.getX() <= trenTrai.getX() || trenTrai.getY() <= duoiPhai.getY())
            throw new Exception ("Invalid format of vertices");
        
        this.trenTrai = trenTrai;
        this.duoiPhai = duoiPhai;
    }

    /**
     * @return the trenTrai
     */
    public Diem getTrenTrai() {
        return trenTrai;
    }

    /**
     * @param trenTrai the trenTrai to set
     */
    public void setTrenTrai(Diem trenTrai) {
        this.trenTrai = trenTrai;
    }

    /**
     * @return the duoiPhai
     */
    public Diem getDuoiPhai() {
        return duoiPhai;
    }

    /**
     * @param duoiPhai the duoiPhai to set
     */
    public void setDuoiPhai(Diem duoiPhai) {
        this.duoiPhai = duoiPhai;
    }
    
    public double tinhDienTich() {
        return (duoiPhai.getX() - trenTrai.getX()) * (trenTrai.getY() - duoiPhai.getY());
    }
    
    public double tinhChuVi() {
        return (duoiPhai.getX() - trenTrai.getX()) + (trenTrai.getY() - duoiPhai.getY()) * 2;
    }
    
    public void hienThiTatCa() {
        trenTrai.hienThi();
        System.out.println();
        duoiPhai.hienThi();
        System.out.println();        
        System.out.println("Dien tich: " + tinhDienTich());
        System.out.println("Chu vi: " + tinhChuVi());

    }
}
