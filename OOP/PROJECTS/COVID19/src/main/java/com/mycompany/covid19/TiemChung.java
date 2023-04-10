/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.covid19;

import java.util.Calendar;

/**
 *
 * @author admin
 */
public class TiemChung {
    private String noiTiem;
    private Calendar ngayTiem;
    private CongDan cd;
    private Vacxin vx;
    
    public void ghiNhanTiemChung(Vacxin v, CongDan cd, String nt) {
        this.noiTiem = nt;
        this.vx = v;
        this.cd = cd;
        
        this.cd.getTc().add(this);
        this.vx.getTc().add(this);
    }

    /**
     * @return the noiTiem
     */
    public String getNoiTiem() {
        return noiTiem;
    }

    /**
     * @param noiTiem the noiTiem to set
     */
    public void setNoiTiem(String noiTiem) {
        this.noiTiem = noiTiem;
    }

    /**
     * @return the ngayTiem
     */
    public Calendar getNgayTiem() {
        return ngayTiem;
    }

    /**
     * @param ngayTiem the ngayTiem to set
     */
    public void setNgayTiem(Calendar ngayTiem) {
        this.ngayTiem = ngayTiem;
    }

    /**
     * @return the cd
     */
    public CongDan getCd() {
        return cd;
    }

    /**
     * @param cd the cd to set
     */
    public void setCd(CongDan cd) {
        this.cd = cd;
    }

    /**
     * @return the vx
     */
    public Vacxin getVx() {
        return vx;
    }

    /**
     * @param vx the vx to set
     */
    public void setVx(Vacxin vx) {
        this.vx = vx;
    }
}
