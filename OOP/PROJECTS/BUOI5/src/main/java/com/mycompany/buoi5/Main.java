/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.buoi5;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.text.ParseException;

/**
 *
 * @author Admin
 */
class A {
    private int c = 111;
    
    public void inC() {
        
    }
}
class B extends A {
    public int c = 222;
    
    public void inC() {
        System.out.println(c);
    }
}

public class Main {
    public static void main(String[] args) throws FileNotFoundException, ParseException, IOException {
        A b = new B();
        b.inC();
    }
    
}
