/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.buoi3;

/**
 *
 * @author Admin
 */
public class DoanThang {
    private Diem d1;
    private Diem d2;
    
    public DoanThang(Diem d1, Diem d2)
    {
        this.d1 = d1;
        this.d2 = d2;
    }
    
    public Diem getD1()
    {
        return d1;
    }
    public Diem getD2()
    {
        return d2;
    }
    public void setD1(Diem d1)
    {
        this.d1 = d1;
    }
    public void setD2(Diem d2)
    {
        this.d2 = d2;
    }
    
    public void hienThi()
    {
        System.out.printf("[(%1.1f, %1.1f), (%1.1f, %1.1f)]", d1.getX(), d1.getY(), d2.getX(), d2.getY());
    }
    public double tinhDoDai()
    {
        return d1.tinhKhoangCach(d2);
    }
    public Diem timTrungDiem() 
    {
        return new Diem((d1.getX() + d2.getX()) / 2, (d1.getY() + d2.getY()) / 2);
    }
    public boolean isSongSong (DoanThang doan1)
    {
        double veTrai = (d1.getX() - d2.getX()) * (doan1.d1.getY() - doan1.d2.getY());
        double vePhai = (d1.getY() - d2.getY()) * (doan1.d1.getX() - doan1.d2.getX());
        double e = 0.00000001;
        
        return Math.abs(veTrai - vePhai) < e;
    }
}
