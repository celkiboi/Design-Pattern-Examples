using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products;

public abstract class Donut
{
    private double weightGrams;
    private double amountOfSugarGrams;
    private double diameterCm;
    private double holeDiameterCm;

    protected Donut(double weightGrams, double amountOfSugarGrams, double diameterCm, double holeDiameterCm)
    {
        WeightGrams = weightGrams;
        AmountOfSugarGrams = amountOfSugarGrams;
        DiameterCm = diameterCm;
        HoleDiameterCm = holeDiameterCm;
    }

    public double WeightGrams
    {
        get { return weightGrams; }
        set
        {
            if (value <= 0)
                throw new DimensionZeroOrLowerException("weightGrams");
            weightGrams = value;
        }
    }

    public double AmountOfSugarGrams
    {
        get { return amountOfSugarGrams; }
        set
        {
            if (value <= 0)
                throw new DimensionZeroOrLowerException("amountOfSugarGrams");
            amountOfSugarGrams = value;
        }
    }

    public double DiameterCm
    {
        get { return diameterCm; }
        set
        {
            if (value <= 0)
                throw new DimensionZeroOrLowerException("diameterCm");
            diameterCm = value;
        }
    }

    public double HoleDiameterCm
    {
        get { return holeDiameterCm; }
        set
        {
            if (value <= 0)
                throw new DimensionZeroOrLowerException("holeDiameterCm");
            holeDiameterCm = value;
        }
    }

    public override string ToString()
    {
        return $"Donut\nproduct weight: {WeightGrams}g\nsugar amount: {amountOfSugarGrams}g\ndiameter: {DiameterCm}cm\nhole diameter:{HoleDiameterCm}\n";
    }
}
