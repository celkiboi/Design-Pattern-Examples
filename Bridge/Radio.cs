using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge;

public class Radio : IDevice
{
    readonly List<double> frequencies = new()
    {
        93.7,
        99.2,
        102.8,
        108.4
    };

    int frequencyIndex = 0;

    public uint VolumeLevel { get; set; }

    public uint BrightnessLevel { get; set; }

    public double CurrentFrequency
    {
        get { return frequencies[frequencyIndex]; }
    }

    public void NextFrequency()
    {
        if (frequencyIndex < frequencies.Count)
            frequencyIndex++;
    }
}
