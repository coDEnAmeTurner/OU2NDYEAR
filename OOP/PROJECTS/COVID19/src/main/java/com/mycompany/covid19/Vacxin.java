/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.covid19;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author admin
 */
public class Vacxin {
    private static int dem;
    private int id = ++dem;
    private String ten;
    private String xuatXu;
    private List<TiemChung> tc;

    public Vacxin(String ten, String xuatXu) {
        this.ten = ten;
        this.xuatXu = xuatXu;
        this.tc = new ArrayList<>();
    }
    
    public int soLuong() {
        return this.tc.size();
    }

    /**
     * @return the id
     */
    public int getId() {
        return id;
    }

    /**
     * @param id the id to set
     */
    public void setId(int id) {
        this.id = id;
    }

    /**
     * @return the ten
     */
    public String getTen() {
        return ten;
    }

    /**
     * @param ten the ten to set
     */
    public void setTen(String ten) {
        this.ten = ten;
    }

    /**
     * @return the xuatXu
     */
    public String getXuatXu() {
        return xuatXu;
    }

    /**
     * @param xuatXu the xuatXu to set
     */
    public void setXuatXu(String xuatXu) {
        this.xuatXu = xuatXu;
    }

    /**
     * @return the tc
     */
    public List<TiemChung> getTc() {
        return tc;
    }

    /**
     * @param tc the tc to set
     */
    public void setTc(List<TiemChung> tc) {
        this.tc = tc;
    }
}
