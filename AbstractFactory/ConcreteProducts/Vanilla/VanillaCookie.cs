using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteProducts.Vanilla;

public class VanillaCookie : Cookie
{
    public VanillaCookie(double weightGrams, double amountOfSugarGrams, double diameterCm)
        : base(weightGrams, amountOfSugarGrams, diameterCm)
    { }

    public override string ToString()
    {
        return "Vanilla " + base.ToString();
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(WeightGrams, AmountOfSugarGrams, DiameterCm, "Vanilla");
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is not VanillaCookie) return false;

        return obj.GetHashCode() == GetHashCode();
    }
}
