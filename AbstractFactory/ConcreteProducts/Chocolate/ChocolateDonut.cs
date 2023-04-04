using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteProducts.Chocolate;

public class ChocolateDonut : Donut
{
    public ChocolateDonut(double weightGrams, double amountOfSugarGrams, double diameterCm, double holeDiameterCm)
        : base(weightGrams, amountOfSugarGrams, diameterCm, holeDiameterCm)
    { }

    public override string ToString()
    {
        return "Chocolate " + base.ToString();
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(WeightGrams, AmountOfSugarGrams, DiameterCm, HoleDiameterCm, "Chocolate");
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is not ChocolateDonut) return false;

        return obj.GetHashCode() == GetHashCode();
    }
}
