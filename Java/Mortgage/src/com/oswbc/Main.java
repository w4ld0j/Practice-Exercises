package com.oswbc;

public class Main {

    public static void main(String[] args) {
        int principal = (int) Console.readNumber("Principal ($1K - $1M): ", 1_000_000, 1_000);
        float annualInterestRate = (float) Console.readNumber("Annual Interest Rate: ", 30, 1);
        byte periodYears = (byte) Console.readNumber("Period (Years): ", 30, 1);

        var calculator = new MortgageCalculator(principal, annualInterestRate, periodYears);
        var report = new MortgageReport(calculator);

        report.printMortgage();
        report.printPaymentSchedule();

    }
}