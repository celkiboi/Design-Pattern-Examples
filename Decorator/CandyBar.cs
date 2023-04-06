using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator;

public class CandyBar : ICandyBar
{
    public string GetName()
    {
        return "Candy bar";
    }
}
