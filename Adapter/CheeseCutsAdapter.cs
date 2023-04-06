using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter;

public class CheeseCutsAdapter : IColdCuts
{
    readonly CheeseCuts cheeseCuts;

    public CheeseCutsAdapter(decimal pricePerKg, double weightGrams, string productName)
    {
        cheeseCuts = new(productName, pricePerKg / 10, weightGrams / 10);
    }

    public decimal PricePerKg
    {
        get 
        { 
            return cheeseCuts.GetPricePer100Grams() * 10; 
        }
    }
    public double WeightGrams 
    {
        get 
        {
            return cheeseCuts.GetWeightDekaGrams() * 10;
        }
    }

    public string ProductName 
    {
        get 
        {
            return cheeseCuts.GetTypeName();
        }
    }

    public decimal CalculatePrice()
    {
        return (decimal)WeightGrams / 1000 * PricePerKg;
    }

    public override string ToString()
    {
        return $"Name: {ProductName}\nPrice per kilogram: {PricePerKg}\nWeight: {WeightGrams}g\nMmm tasty cheese\n";
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ProductName, PricePerKg, WeightGrams);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is not CheeseCutsAdapter) return false;

        return obj.GetHashCode() == GetHashCode();
    }
}
