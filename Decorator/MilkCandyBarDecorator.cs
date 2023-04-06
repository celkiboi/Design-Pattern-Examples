using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator;

public class MilkCandyBarDecorator : CandyBarDecorator
{
    public MilkCandyBarDecorator(ICandyBar candyBar) 
        : base(candyBar)
    { }

    public override string GetName()
    {
        return "Milk " + base.GetName();
    }
}
