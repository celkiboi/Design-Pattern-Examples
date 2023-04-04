using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.ConcreteProducts.Chocolate;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteProducts.Vanilla;

public class VanillaCake : Cake
{
    public VanillaCake(double weightGrams, double amountOfSugarGrams, double diameterCm, double heightCm) 
        : base(weightGrams, amountOfSugarGrams, diameterCm, heightCm)
    { }

    public override string ToString()
    {
        return "Vanilla " + base.ToString();
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(WeightGrams, AmountOfSugarGrams, HeightCm, DiameterCm, "Vanilla");
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is not VanillaCake) return false;

        return obj.GetHashCode() == GetHashCode();
    }
}
