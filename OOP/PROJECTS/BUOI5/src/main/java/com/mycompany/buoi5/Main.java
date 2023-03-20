/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.buoi5;

import java.io.FileNotFoundException;
import java.text.ParseException;

/**
 *
 * @author Admin
 */
public class Main {
    public static void main(String[] args) throws FileNotFoundException, ParseException {
        QuanLyHocVien ds = new QuanLyHocVien();
        ds.nhapDS("D:\\OU 2ND YEAR\\CODECOURSE\\OOP\\PROJECTS\\BUOI5\\src\\main\\resource\\hocvien");
        ds.hienThiDS();
    }
    
}
