﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge;

public class InfraredRemote : Remote
{
    public InfraredRemote(IDevice device) : base(device)
    { }

    public override void DecrementSound()
    {
        base.device.VolumeLevel--;
    }

    public override void IncrementSound()
    {
        base.device.VolumeLevel++;
    }
}
