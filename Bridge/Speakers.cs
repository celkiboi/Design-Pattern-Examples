using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge;

public class Speakers : IDevice
{
    public bool CurrentlyPlaying { get; private set; }

    public uint VolumeLevel { get; set; }

    public void TogglePlay()
    {
        CurrentlyPlaying = !CurrentlyPlaying;
    }
}
