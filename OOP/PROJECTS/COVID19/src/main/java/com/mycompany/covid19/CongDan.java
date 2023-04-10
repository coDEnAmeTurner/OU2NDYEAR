/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.covid19;

import java.text.ParseException;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;
import java.util.List;

/**
 *
 * @author admin
 */
public class CongDan {
    private String cccd;
    private String hoTen;
    private Date ngaySinh;
    private List<TiemChung> tc;

    public CongDan(String cccd, String hoTen, Date ngaySinh) {
        this.cccd = cccd;
        this.hoTen = hoTen;
        this.ngaySinh = ngaySinh;
        this.tc = new ArrayList<>();
    }
    
    public CongDan(String cccd, String hoTen, String ngaySinh) throws ParseException {
       this(cccd, hoTen, CauHinh.F.parse(ngaySinh));
    }
    
    public boolean isTiem() {
        Date d = new Date();
        if (this.tc.isEmpty())
            return d.getYear() - this.ngaySinh.getYear() >= 18;
        
        Calendar nt = this.tc.get(this.tc.size() - 1).getNgayTiem();
        nt.add(Calendar.MONTH, 3);
        Calendar c = new GregorianCalendar();
        
        return c.compareTo(nt) >= 0;
    }

    /**
     * @return the cccd
     */
    public String getCccd() {
        return cccd;
    }

    /**
     * @param cccd the cccd to set
     */
    public void setCccd(String cccd) {
        this.cccd = cccd;
    }

    /**
     * @return the hoTen
     */
    public String getHoTen() {
        return hoTen;
    }

    /**
     * @param hoTen the hoTen to set
     */
    public void setHoTen(String hoTen) {
        this.hoTen = hoTen;
    }

    /**
     * @return the ngaySinh
     */
    public Date getNgaySinh() {
        return ngaySinh;
    }

    /**
     * @param ngaySinh the ngaySinh to set
     */
    public void setNgaySinh(Date ngaySinh) {
        this.ngaySinh = ngaySinh;
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
