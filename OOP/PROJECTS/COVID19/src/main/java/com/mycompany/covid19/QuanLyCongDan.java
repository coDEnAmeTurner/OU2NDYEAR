/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.covid19;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

/**
 *
 * @author admin
 */
public class QuanLyCongDan {
    private List<CongDan> ds = new ArrayList<>();
    
    public void themCd(CongDan... a) {
        this.ds.addAll(Arrays.asList(a));
    }
    
    public List<CongDan> timCdNN() {
        return this.ds.stream().filter(c -> c instanceof CongDanNuocNgoai).collect(Collectors.toList());
    }
    
    public List<CongDan> tiem2MuiTroLen() {
        return this.ds.stream().filter(c -> c.getTc().size() >= 2).collect(Collectors.toList());
    }
}
