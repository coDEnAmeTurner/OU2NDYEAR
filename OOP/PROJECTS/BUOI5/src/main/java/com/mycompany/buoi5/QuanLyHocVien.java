/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.buoi5;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.text.ParseException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

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
    
    public void nhapDiem() {
        ds.forEach(hv -> {
            System.out.printf("Nhap hoc vien %s:\n", hv.getHoTen());
            hv.nhapDiem();
        });
    }
    
    public HocVien tim(int ma) {
        return ds.stream().filter(hv -> hv.getMa() == ma).findFirst().get();
    }
    
    public HocVien tim(String ten) {
        return ds.stream().filter(hv -> hv.getHoTen() == ten).findFirst().get();
    }
    
    public void sapXepTheoDiem() {
        ds.sort((hv1, hv2) -> {
            double d1 = hv1.tinhTrungBinh();
            double d2 = hv2.tinhTrungBinh();
            
            if (d1 == d2)
                return 0;
            else if (d1 > d2)
                return 1;
            else 
                return 0;
        });
    }
    
    public void hienThiDS() {
        for (int i = 0; i < ds.size(); i++)  {
            System.out.printf("Hoc vien thu %d: \n", i);
            ds.get(i).hienThi();
        }
    }
    
    public List<HocVien> taoDSHocBong() {
        return ds.stream().filter(hv -> {
            double[] da = hv.getDiem();
            double tb = hv.tinhTrungBinh();
            for (var d : da)
                if (d < 5)
                    return false;
            return tb >= 8;
        }).collect(Collectors.toList());
    }
    
    public void xuatDSHocBong(String path) throws IOException {
        File fo = new File(path);
        PrintWriter pw = new PrintWriter(fo);
        var dsHB = taoDSHocBong();
        for (var hv : dsHB) {
            pw.printf("Ma hoc vien: %d\n", hv.getMa());
            pw.printf("Ten hoc vien: %s\n", hv.getHoTen());
            pw.printf("Diem trung binh hoc vien: %.1f\n", hv.tinhTrungBinh());
        }
        pw.close();
    }
}
