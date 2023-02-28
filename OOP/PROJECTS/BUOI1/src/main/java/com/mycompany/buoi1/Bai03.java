/*
* Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
* Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
*/
package com.mycompany.buoi1;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Random;
import java.util.Scanner;

/**
 *
 * @author Admin
 */
public class Bai03 {
    public static boolean isPrime(int x)
    {
        for (int i = 2; i <= Math.sqrt((double)x); i++)
        {
            if (x % i == 0)
                return false;
        }
        return true;
    }
    
    public static void main(String[] args) throws FileNotFoundException {
        //3a
//        String s;
//        Scanner sc = new Scanner(System.in);
//        System.out.println("Nhap vao dia chi mail: ");
//        s = sc.nextLine();
//        s = s.substring(0, s.indexOf("@"));
//        System.out.printf("Ten dia chi: %s", s);

//3b
//        String s;
//        Scanner sc = new Scanner(System.in);
//        System.out.print("Nhap vao 1 chuoi: "); s = sc.nextLine();
//
//        int count = 0;
//        for (int i = 0; i < s.length(); i++)
//        {
//            if (Character.isUpperCase(s.charAt(i)))
//                count++;
//        }
//
//        System.out.printf("So ky tu hoa: %d", count);

//3c
//        File fi = new File("src/main/resources/input.txt");
//        String s;
//        try (Scanner si = new Scanner(fi))
//        {
//            s = si.nextLine();
//            s = s.replaceAll("\\{file\\}", "tap tin");
//        }
//        
//        File fo = new File("src/main/resources/output.txt");
//        try(PrintWriter pw = new PrintWriter(fo))
//        {
//            pw.println(s);
//        }
        //3d
//        Scanner sc = new Scanner(System.in);
//        System.out.print("Nhap vao chuoi: "); String s = sc.nextLine();
//        String[] a = s.split("[\\s,;]+");
//        System.out.println(a.length);
//        int maxi = 0;
//        for (int i = 1; i < a.length; i++)
//        {
//            if (a[maxi].length() <= a[i].length())
//                maxi = i;
//        }
//        System.out.printf("Tu dai nhat trong chuoi: %s", a[maxi]);

//        3e
//        Scanner sc = new Scanner(System.in);
//        System.out.println("Nhap vao 1 chuoi: "); String s = sc.nextLine();
//        
//        s = s.trim().replaceAll("\\s+", " ");
//        String[] a = s.split(" ");
//        for (int i = 0; i < a.length; i++)
//        {
//            a[i] = Character.toUpperCase(a[i].charAt(0)) + a[i].substring(1).toLowerCase();
//        }
//        s = "";
//        for (int i = 0; i < a.length; i++)
//        {
//            s += a[i];
//            if (i != a.length - 1)
//                s += " ";
//        }
//        
//        System.out.printf("%s", s);

//        4a
        Scanner sc = new Scanner(System.in);
        System.out.println("Nhap so n: "); int n = sc.nextInt();
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = sc.nextInt();
        }
        for (int x : a)
            System.out.printf("%d ", x);
        System.out.println();
//        
//        int sum = 0;
//        for (int numInA : a)
//        {
//            if (isPrime(numInA))
//                sum += numInA;
//        }
//        
//        System.out.printf("Tong cac so nguyen to: %d", sum);
        
        int max = a[0], min = a[0];
        for (int numInA : a)
        {
            if (numInA > max)
                max = numInA;
        }
        for (int numInA : a)
        {
            if (numInA < min)
                min = numInA;
        }
        if (max > 0)
            System.out.printf("So duong lon nhat: %d\n", max);
        else 
            System.out.println("*");
        
        if (min < 0)
            System.out.printf("So am be nhat: %d\n", min);
        else 
            System.out.println("*");
    }
}
