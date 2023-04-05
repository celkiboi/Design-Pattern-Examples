using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder;

public class PizzaDirector
{
    public IPizzaBuilder Builder { get; set; }

    public PizzaDirector(IPizzaBuilder pizzaBuilder)
    {
        Builder = pizzaBuilder;   
    }

    public Pizza BuildCapricciosa()
    {
        return Builder.Reset()
            .BuildKetchup()
            .BuildSalami()
            .BuildCheese()
            .BuildMushrooms()
            .Build();
    }

    public Pizza BuildVesuvio()
    {
        return Builder.Reset()
            .BuildKetchup()
            .BuildSalami()
            .BuildCheese()
            .Build();
    }

    public Pizza BuildPeperoni()
    {
        return Builder.Reset()
            .BuildKetchup()
            .BuildSalami()
            .BuildCheese()
            .BuildPepperoni()
            .Build();
    }
}
