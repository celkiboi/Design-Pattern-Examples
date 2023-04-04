﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteProducts.Chocolate;

public class ChocolateCookie : Cookie
{
    public ChocolateCookie(double weightGrams, double amountOfSugarGrams, double diameterCm)
        : base(weightGrams, amountOfSugarGrams, diameterCm)
    { }

    public override string ToString()
    {
        return "Chocolate " + base.ToString();
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(WeightGrams, AmountOfSugarGrams, DiameterCm, "Chocolate");
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is not ChocolateCookie) return false;

        return obj.GetHashCode() == GetHashCode();
    }
}
