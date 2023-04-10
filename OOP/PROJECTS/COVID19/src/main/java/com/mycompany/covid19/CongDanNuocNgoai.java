/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.covid19;

import java.text.ParseException;

/**
 *
 * @author admin
 */
public class CongDanNuocNgoai extends CongDan {
    private String soHoChieu;

    public CongDanNuocNgoai(String cccd, String hoTen, String ngaySinh, String soHoChieu) throws ParseException {
        super(cccd, hoTen, ngaySinh);
        this.soHoChieu = soHoChieu;
    }
    
    

    /**
     * @return the soHoChieu
     */
    public String getSoHoChieu() {
        return soHoChieu;
    }

    /**
     * @param soHoChieu the soHoChieu to set
     */
    public void setSoHoChieu(String soHoChieu) {
        this.soHoChieu = soHoChieu;
    }
}
