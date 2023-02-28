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
        System.out.printf("[(), ()]");
    }
}
