using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder;

public interface IPizzaBuilder
{
    IPizzaBuilder BuildKetchup();
    IPizzaBuilder BuildCheese();
    IPizzaBuilder BuildSalami();
    IPizzaBuilder BuildPepperoni();
    IPizzaBuilder BuildMushrooms();
    IPizzaBuilder BuildTuna();
    IPizzaBuilder BuildHam();
    IPizzaBuilder Reset();
    Pizza Build();
}
