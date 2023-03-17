/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.buoi5;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.format.DateTimeFormatter;
import java.util.Date;
import java.util.Scanner;

/**
 *
 * @author Admin
 */
public class HocVien {
    private int ma;
    private String hoTen;
    private Date ngaySinh;
    private double[] diem;
    public static int count = 0;
    public static final SimpleDateFormat f = new SimpleDateFormat("dd/MM/yyyy");
    private static final Scanner sc = new Scanner(System.in);

    public HocVien() {
    }
    
    public HocVien(int ma, String hoTen, Date ngaySinh) {
        this.ma = ma;
        this.hoTen = hoTen;
        this.ma = ++count;
        this.ngaySinh = ngaySinh;
    }
    
    public HocVien(int ma, String hoTen, String ngaySinh) throws ParseException {
        this(ma, hoTen, f.parse(ngaySinh));
    }

    /**
     * @return the ma
     */
    public int getMa() {
        return ma;
    }

    /**
     * @param ma the ma to set
     */
    public void setMa(int ma) {
        this.ma = ma;
    }

    /**
     * @return the hoTen
     */
    public String getHoTen() {
        return hoTen;
    }

    /**
     * @param hoTen the hoTen to set
     */
    public void setHoTen(String hoTen) {
        this.hoTen = hoTen;
    }

    /**
     * @return the ngaySinh
     */
    public Date getNgaySinh() {
        return ngaySinh;
    }

    /**
     * @param ngaySinh the ngaySinh to set
     */
    public void setNgaySinh(Date ngaySinh) {
        this.ngaySinh = ngaySinh;
    }

    /**
     * @return the diem
     */
    public double[] getDiem() {
        return diem;
    }

    /**
     * @param diem the diem to set
     */
    public void setDiem(double[] diem) {
        this.diem = diem;
    }

    public void hienThi() {
        System.out.printf("Ho ten: %s\n", hoTen);
        System.out.printf("Ngay sinh: %s\n", f.format(ngaySinh));
        for (int i = 0; i < diem.length; i++) 
            System.out.printf("Diem mon %d: %1.1f\n", i, diem[i]);
    }
    
    public void nhapHV() throws ParseException {
        System.out.print("Nhap ho ten: "); hoTen = sc.nextLine();
        System.out.print("Nhap ngay sinh: "); ngaySinh = f.parse(sc.nextLine());
    }
}
