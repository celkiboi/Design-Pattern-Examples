using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteProducts.Chocolate;

public class ChocolateCake : Cake
{
    public ChocolateCake(double weightGrams, double amountOfSugarGrams, double diameterCm, double heightCm)
        : base(weightGrams, amountOfSugarGrams, diameterCm, heightCm)
    { }

    public override string ToString()
    {
        return "Chocolate " + base.ToString();
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(WeightGrams, AmountOfSugarGrams, HeightCm, DiameterCm, "Chocolate");
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is not ChocolateCake) return false;

        return obj.GetHashCode() == GetHashCode();
    }
}
