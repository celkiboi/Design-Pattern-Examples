using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator;

public abstract class CandyBarDecorator : ICandyBar
{
    readonly ICandyBar candyBar;

    public CandyBarDecorator(ICandyBar candyBar)
    {
        this.candyBar = candyBar;
    }

    
    public virtual string GetName()
    {
        return candyBar.GetName();
    }
}
