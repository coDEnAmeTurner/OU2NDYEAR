/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Enum.java to edit this template
 */
package com.mycompany.nganhang;

/**
 *
 * @author Admin
 */
public enum KyHan {
    MOT_TUAN(1.1f) {
        @Override
        public double tinhTienLai() {
            throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
        }
    },
    MOT_THANG(4.5f) {
        @Override
        public double tinhTienLai() {
            throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
        }
    },
    MOT_NAM(6.8f) {
        @Override
        public double tinhTienLai() {
            throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
        }
    };
    
    private double ls;

    private KyHan(double ls) {
        this.ls = ls;
    }
    
    public abstract double tinhTienLai();
}
