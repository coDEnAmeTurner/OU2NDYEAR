/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.covid19;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;
import java.util.List;

/**
 *
 * @author admin
 */
public class QuanLyVacxin {
    private List<Vacxin> ds = new ArrayList<>();
    public void themVx(Vacxin... a) {
        this.ds.addAll(Arrays.asList(a));
    }
    
    public void sapXep() {
        this.ds.sort(Comparator.comparing(Vacxin::getXuatXu).thenComparing(Vacxin::soLuong));
    }
}
