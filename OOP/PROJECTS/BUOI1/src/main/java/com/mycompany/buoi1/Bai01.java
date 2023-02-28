/*
* Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
* Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
*/
package com.mycompany.buoi1;

import java.util.Scanner;

/**
 *
 * @author Admin
 */
public class Bai01 {
    public static void main(String[] args) {
        int randNum = (int)(100 * (Math.random() + 1));
        Scanner sc = new Scanner(System.in);
        int x;
        
        System.out.println(randNum);
        do {
            System.out.print("Doan so randNum: "); x = sc.nextInt();
            if (x < randNum)
                System.out.println("So ban doan nho hon");
            else if (x > randNum)
                System.out.println("So ban doan lon hon");
            else
                System.out.println("Ban da doan dung");
        }while (x < randNum || x > randNum);
        
    }
}
