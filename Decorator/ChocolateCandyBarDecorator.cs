using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator;

public class ChocolateCandyBarDecorator : CandyBarDecorator
{
    public ChocolateCandyBarDecorator(ICandyBar candyBar)
        : base(candyBar)
    { }

    public override string GetName()
    {
        return "Chocolate " + base.GetName();
    }
}

