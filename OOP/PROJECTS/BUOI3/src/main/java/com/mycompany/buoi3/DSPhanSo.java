/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.buoi3;

import java.util.ArrayList;
import java.util.Arrays;

/**
 *
 * @author Admin
 */
public class DSPhanSo {
    private ArrayList<PhanSo> danhSach;

    public DSPhanSo() {
        danhSach = new ArrayList<>();
    }

    public DSPhanSo(PhanSo... ps) {
        this.danhSach = new ArrayList<>(Arrays.asList(ps));
    }
    
    public void themPhanSo (PhanSo ps) {
        danhSach.add(ps);
    }
    
    public void themPhanSo (PhanSo... ps) {
        danhSach.addAll(Arrays.asList(ps));
    }
    
    public void hienThi() {
        danhSach.forEach(x -> {x.hienThi(); System.out.println();});
    }
    
    public void xoaPhanSo(PhanSo ps) {
        danhSach.removeIf(x -> (x.getTu() == ps.getTu() && x.getMau() == ps.getMau()));
    }
    
    public void xoaPhanSo(int tu, int mau) {
        danhSach.removeIf(x -> (x.getTu() == tu && x.getMau() == mau));
    }
    
    public PhanSo tongAllPhanSo() {
        return danhSach.stream().reduce(new PhanSo(), (t, x) -> t.cong(x));
    }
    
    public PhanSo minDanhSach() {
        return danhSach.stream().min((x, y) -> x.soSanh(y)).get();
    }
    
    public PhanSo maxDanhSach() {
        return danhSach.stream().max((x, y) -> x.soSanh(y)).get();
    }
    
    public void sortAscend() {
        danhSach.sort((x, y) -> x.soSanh(y));
    }
}
