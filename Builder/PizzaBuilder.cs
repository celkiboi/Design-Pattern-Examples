using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder;

public class PizzaBuilder : IPizzaBuilder
{
    bool hasKetchup = true;
    bool hasCheese = true;
    bool hasSalami = false;
    bool hasPepperoni = false;
    bool hasMushrooms= false;
    bool hasTuna = false;
    bool hasHam = false;

    public Pizza Build()
    {
        return new(hasKetchup, hasCheese, hasSalami, hasPepperoni,hasMushrooms, hasTuna, hasHam);
    }

    public IPizzaBuilder BuildCheese()
    {
        hasCheese = true;
        return this;
    }

    public IPizzaBuilder BuildHam()
    {
        hasHam = true;
        return this;
    }

    public IPizzaBuilder BuildKetchup()
    {
        hasKetchup = true;
        return this;
    }

    public IPizzaBuilder BuildMushrooms()
    {
        hasMushrooms = true;
        return this;
    }

    public IPizzaBuilder BuildPepperoni()
    {
        hasPepperoni= true;
        return this;
    }

    public IPizzaBuilder BuildSalami()
    {
        hasSalami = true;
        return this;
    }

    public IPizzaBuilder BuildTuna()
    {
        hasTuna = true;
        return this;
    }

    public IPizzaBuilder Reset()
    {
        hasKetchup = false;
        hasCheese = false;
        hasSalami = false;
        hasPepperoni = false;
        hasMushrooms = false;
        hasTuna = false;
        hasHam = false;
        return this;
    }
}
