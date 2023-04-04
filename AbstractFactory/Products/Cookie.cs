using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products;

public abstract class Cookie
{
    private double weightGrams;
    private double amountOfSugarGrams;
    private double diameterCm;

    protected Cookie(double weightGrams, double amountOfSugarGrams, double diameterCm)
    {
        WeightGrams = weightGrams;
        AmountOfSugarGrams = amountOfSugarGrams;
        DiameterCm = diameterCm;
    }

    public double WeightGrams
    {
        get => weightGrams;
        private set
        {
            if (value <= 0)
                throw new DimensionZeroOrLowerException("weightGrams");
            weightGrams = value;
        }
    }

    public double AmountOfSugarGrams
    {
        get => amountOfSugarGrams;
        private set
        {
            if (value <= 0)
                throw new DimensionZeroOrLowerException("amountOfSugarGrams");
            amountOfSugarGrams = value;
        }
    }

    public double DiameterCm
    {
        get => diameterCm;
        private set
        {
            if (value <= 0)
                throw new DimensionZeroOrLowerException("diameterCm");
            diameterCm = value;
        }
    }

    public override string ToString()
    {
        return $"Cookie\nproduct weight: {WeightGrams}g\nsugar amount: {AmountOfSugarGrams}g\nSize (diameter): {DiameterCm}cm\n";
    }
}
