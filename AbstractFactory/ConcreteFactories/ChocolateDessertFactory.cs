using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.ConcreteProducts.Chocolate;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteFactories;

public class ChocolateDessertFactory : IDessertFactory
{
    const double defaultCakeWeightGrams = 500;
    const double defaultCakeAmountOfSugarGrams = 200;
    const double defaultCakeDiameterCm = 30;
    const double defaultCakeHeightCm = 6;

    const double defaultCookieWeightGrams = 60;
    const double defaultCookieAmountOfSugarGrams = 15;
    const double defaultCookieDiameterCm = 7;

    const double defaultDonutWeightGrams = 40;
    const double defaultDonutAmountOfSugarGrams = 10;
    const double defaultDonutDiameterCm = 8;
    const double defaultDonutHoleDiameterCm = 3;

    public Cake CreateCake()
    {
        return new ChocolateCake(defaultCakeWeightGrams, 
            defaultCakeAmountOfSugarGrams, 
            defaultCakeDiameterCm, 
            defaultCakeHeightCm);
    }

    public Cookie CreateCookie()
    {
        return new ChocolateCookie(defaultCookieWeightGrams,
            defaultCookieAmountOfSugarGrams,
            defaultCookieDiameterCm);
    }

    public Donut CreateDonut()
    {
        return new ChocolateDonut(defaultDonutWeightGrams,
            defaultDonutAmountOfSugarGrams,
            defaultDonutDiameterCm,
            defaultDonutHoleDiameterCm);
    }
}

