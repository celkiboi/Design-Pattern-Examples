using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge;

public class TV : IDevice
{
    readonly List<string> channels = new()
    {
        "BBC",
        "NBC",
        "Fox"
    };

    int channelIndex = 0;

    public uint VolumeLevel { get; set; }

    public uint BrightnessLevel { get; set; }

    public string CurrentChannel
    {
        get { return channels[channelIndex]; }
    }

    public void NextChannel()
    {
        if (channelIndex < channels.Count)
            channelIndex++;
        else channelIndex = 0;
    }
}
