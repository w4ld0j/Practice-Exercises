package com.oswbc;

import java.util.HashMap;

public class Test {
    public static void main (String[] args) {
        HashMap<String, Integer> numbers = new HashMap<String, Integer>();
        numbers.put("Juan", 12);
        numbers.put("Jorge", 13);
        System.out.println(numbers.containsKey("Pepe"));
        System.out.println(numbers.values());
//        int a = numbers.get("Juann");

    }

}
