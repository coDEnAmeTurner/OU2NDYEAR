/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.buoi5;

import java.io.File;
import java.io.FileNotFoundException;
import java.text.ParseException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author Admin
 */
public class QuanLyHocVien {
    private List<HocVien> ds;

    public QuanLyHocVien() {
        ds = new ArrayList<>();
    }
    
    public QuanLyHocVien(HocVien... ds) {
        this.ds = new ArrayList<>();
        this.ds.addAll(Arrays.asList(ds));
    }
    
    public void nhapDS(int n) throws ParseException {
        for (int i = 0; i < n; i++) {
            HocVien hv = new HocVien();
            System.out.printf("Nhap hoc vien thu %d:\n", i);
            hv.nhapHV();
        }
    }
    
    public void nhapDS(HocVien... hv) {
        ds.addAll(Arrays.asList(hv));
    }
    
    public void nhapDS(String path) throws FileNotFoundException, ParseException {
        File fin = new File(path);
        try (Scanner fsc = new Scanner(fin))
        {
            while (fsc.hasNext()) {
                HocVien hv = new HocVien();
                hv.setHoTen(fsc.nextLine());
                hv.setNgaySinh(Utility.f.parse(fsc.nextLine()));
                ds.add(hv);
            }
        }
        
    }
    
    public void hienThiDS() {
        for (int i = 0; i < ds.size(); i++)  {
            System.out.printf("Hoc vien thu %d: \n", i);
            ds.get(i).hienThi();
        }
    }
    
    
}
