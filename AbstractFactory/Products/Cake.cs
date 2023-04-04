using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products;

public abstract class Cake
{
    private double weightGrams;
    private double amountOfSugarGrams;
    private double diameterCm;
    private double heightCm;

    protected Cake(double weightGrams, double amountOfSugarGrams, double diameterCm, double heightCm)
    {
        WeightGrams = weightGrams;
        AmountOfSugarGrams = amountOfSugarGrams;
        DiameterCm = diameterCm;
        HeightCm = heightCm;
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

    public double HeightCm
    {
        get { return heightCm; }
        set
        {
            if (value <= 0)
                throw new DimensionZeroOrLowerException("heightCm");
            heightCm = value;
        }
    }

    public override string ToString()
    {
        return $"Cake\nproduct weight: {WeightGrams}g\nsugar amount: {amountOfSugarGrams}g\ndiameter: {DiameterCm}cm\nheight:{HeightCm}\n";
    }
}