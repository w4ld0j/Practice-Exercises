package com.oswbc;

import java.text.NumberFormat;

public class MortgageReport {

    private final NumberFormat currency;
    private MortgageCalculator calculator;

    public MortgageReport(MortgageCalculator calculator) {
        this.calculator = calculator;
        currency = NumberFormat.getCurrencyInstance();
    }
    public void printMortgage() {
        System.out.println("\nMORTGAGE");
        System.out.println("-------");
        System.out.println("Monthly Payments: " + currency.format(calculator.calculateMortgage()));
    }

    public void printPaymentSchedule() {
        System.out.println("\nPAYMENT SCHEDULE");
        System.out.println("----------------");
        for (double balance : calculator.getRemainingBalances() ) {
            System.out.println(currency.format(balance));
        }
    }
}
