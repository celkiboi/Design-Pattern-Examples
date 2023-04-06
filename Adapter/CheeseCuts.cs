using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter;

public class CheeseCuts
{
    readonly string typeName;
    readonly decimal pricePer100Grams;
    readonly double weightDekaGrams;

    public CheeseCuts(string typeName, decimal pricePer100Grams, double weightDekaGrams)
    {
        this.typeName = typeName;
        this.pricePer100Grams = pricePer100Grams;
        this.weightDekaGrams = weightDekaGrams;
    }

    public string GetTypeName()
    {
        return typeName;
    }

    public decimal GetPricePer100Grams()
    {
        return pricePer100Grams;
    }

    public double GetWeightDekaGrams()
    {
        return weightDekaGrams;
    }
}
