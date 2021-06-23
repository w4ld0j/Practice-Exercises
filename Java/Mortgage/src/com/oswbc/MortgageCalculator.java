package com.oswbc;

public class MortgageCalculator {
    private final static byte MONTHS_IN_YEAR = 12;
    private final static byte PERCENT = 100;

    private int principal;
    private float annualInterestRate;
    byte periodYears;

    public MortgageCalculator(int principal, float annualInterestRate, byte periodYears) {
        this.principal = principal;
        this.annualInterestRate = annualInterestRate;
        this.periodYears = periodYears;
    }

    public double calculateMortgage() {
        float monthInterestRate = getMonthInterestRate();
        short periodMonths = getNumberOfPayments();

        return principal * ((monthInterestRate * Math.pow(1 + monthInterestRate, periodMonths))
                / (Math.pow(1 + monthInterestRate, periodMonths) - 1));
    }

    public double calculateBalance(short paymentsDone) {
        float monthInterestRate = getMonthInterestRate(); //monthly interest
        short periodMonths = getNumberOfPayments(); //number of payments

        double remainingBalance = principal * (Math.pow(1 + monthInterestRate, periodMonths)
                - Math.pow(1 + monthInterestRate, paymentsDone))
                / (Math.pow(1 + monthInterestRate, periodMonths) - 1);
        return remainingBalance;
    }
    public double[] getRemainingBalances() {
        double[] balances = new double[getNumberOfPayments()];
        for (short month = 1; month <= balances.length; month++) {
            balances[month - 1] = calculateBalance(month);
        }
        return balances;
    }

    private short getNumberOfPayments() {
        return (short) (periodYears * MONTHS_IN_YEAR);
    }

    private float getMonthInterestRate() {
        return annualInterestRate / PERCENT / MONTHS_IN_YEAR;
    }
}
