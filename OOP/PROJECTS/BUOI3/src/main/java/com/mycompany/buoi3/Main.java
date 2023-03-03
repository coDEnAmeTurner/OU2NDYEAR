/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.buoi3;

/**
 *
 * @author Admin
 */
public class Main {
    public static void main(String[] args) throws Exception {
        HinhChuNhat hcn = new HinhChuNhat(new Diem(1, 5), new Diem(7, 3));

        hcn.hienThiTatCa();
    }
}
