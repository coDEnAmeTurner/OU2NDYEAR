package com.mycompany.buoi1;


import java.util.Scanner;

/*
* Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
* Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
*/

/**
 *
 * @author Admin
 */
public class Bai02 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Nhap vao bac: "); int n = sc.nextInt();
        System.out.print("Nhap vao bien x: "); double x = sc.nextDouble();
        
        double gt = 0, heso;
        for (int i = 0; i <= n; i++)
        {
            System.out.printf("Nhap vao he so thu %d: ", i); 
            heso = sc.nextDouble();
            gt += heso * Math.pow(x, i);
        }
        
        System.out.printf("Gia tri cua ham: %1.0f", gt);
    }
}
