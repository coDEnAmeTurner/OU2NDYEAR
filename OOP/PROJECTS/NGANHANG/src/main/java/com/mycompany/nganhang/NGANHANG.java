/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.nganhang;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

/**
 *
 * @author Admin
 */
public class NGANHANG {

    public static void main(String[] args) {
        List<NhanVien> dsNV = new ArrayList<>();
        dsNV.sort(Comparator.comparing(NhanVien::getTen));
    }
}
