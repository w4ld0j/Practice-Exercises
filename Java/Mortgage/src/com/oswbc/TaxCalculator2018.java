package com.oswbc;

public class TaxCalculator2018 implements TaxCalculator {
    private double texableIncome;

    public TaxCalculator2018(double texableIncome) {
        this.texableIncome = texableIncome;
    }
    @Override
    public double calculateTax() {
        return texableIncome * 0.3;
    }
}
