using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter;

public class MeatCuts : IColdCuts
{

    public decimal PricePerKg { get; init; }

    public double WeightGrams { get; init; }

    public string ProductName { get; init; }

    public MeatCuts(decimal pricePerKg, double weightGrams, string productName)
    {
        PricePerKg = pricePerKg;
        WeightGrams = weightGrams;
        ProductName = productName;
    }

    public decimal CalculatePrice()
    {
        return (decimal)WeightGrams / 1000 * PricePerKg;
    }

    public override string ToString()
    {
        return $"Name: {ProductName}\nPrice per kilogram: {PricePerKg}\nWeight: {WeightGrams}g\nMmm tasty meat\n";
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ProductName, PricePerKg, WeightGrams);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is not MeatCuts) return false;

        return obj.GetHashCode() == GetHashCode();
    }
}
