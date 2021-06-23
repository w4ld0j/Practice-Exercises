package com.oswbc;

import java.util.Scanner;

public class Console {
    private static Scanner sc = new Scanner(System.in);

    public static double readNumber(String prompt) {
        return  sc.nextDouble();
    }
    public static double readNumber(String prompt, double max, double min) {
        System.out.print(prompt);
        double value = sc.nextDouble();
        while (value < min || value > max) {
            System.out.print("Error: Please enter a value between " + min + " and " + max + ": ");
            value = sc.nextDouble();
        }
        return value;
    }
}
