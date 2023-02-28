/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.buoi3;

/**
 *
 * @author Admin
 */
public class Diem {
    private double x;
    private double y;

    public Diem(double x, double y) {
        this.x = x;
        this.y = y;
    }
    
    public double getX(){
        return x;
    }
    public double getY(){
        return y;
    }
    public void setX(double x)
    {
        this.x = x;
    }
    public void setY(double y)
    {
        this.y = y;
    }
    public void hienThi()
    {
        System.out.printf("(%1.1f, %1.1f)", x, y);
    }
    public double tinhKhoangCach(Diem d)
    {
        return Math.sqrt(Math.pow(d.x - x, 2) + Math.pow(d.y - y, 2));
    }
}
