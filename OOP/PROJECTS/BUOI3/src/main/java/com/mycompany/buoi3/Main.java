/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.buoi3;

import java.util.Arrays;
import java.util.stream.BaseStream;
import java.util.stream.IntStream;
import java.util.stream.Stream;

/**
 *
 * @author Admin
 */
public class Main {
    public static void main(String[] args) throws Exception {
        PhanSo[] a = new PhanSo[] {new PhanSo(1, 2), new PhanSo(1, 1), new PhanSo(2, 3)};
        PhanSo sum = new PhanSo();
        PhanSo max = a[0];
        for (PhanSo ps : a) {
            if (max.soSanh(ps) < 0)
                max = ps;
            sum = sum.cong(ps);
            ps.hienThi();
            System.out.println();
        }
        sum.hienThi();
        System.out.println();
        max.hienThi();
        System.out.println();
    }
}
