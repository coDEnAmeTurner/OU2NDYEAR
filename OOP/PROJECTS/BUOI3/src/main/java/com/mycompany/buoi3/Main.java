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
        HinhTron h1 = new HinhTron(new Diem(1, 1), 1);
        HinhTron h2 = new HinhTron(new Diem(3, 2), 4);
        System.out.println(h1.timViTriTuongDoiDTron(h2));
    }
}
