using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge;

public abstract class Remote
{
    protected IDevice device;

    protected Remote(IDevice device)
    {
        this.device = device;
    }

    public abstract void IncrementSound();

    public abstract void DecrementSound();
    
}
