using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator;

public class CoconutCandyBarDecorator : CandyBarDecorator
{
    public CoconutCandyBarDecorator(ICandyBar candyBar) 
        : base(candyBar) 
    { }

    public override string GetName()
    {
        return "Coconut " + base.GetName();
    }
}
