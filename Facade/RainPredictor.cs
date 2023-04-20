using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Facade;

public class RainPredictor
{
    public GeoLocation Location { get; set; }

    public double RainFactor { get; set; }

    readonly Random random = new();

    public RainPredictor(GeoLocation location)
    {
        Location = location;
    }

    static double CalculateRainFactor()
    {
        if (DateTime.Now.Month >= 6 && DateTime.Now.Month <= 9)
            return 0;
        if (DateTime.Now.Month >= 10 && DateTime.Now.Month <= 12)
            return 0.6;
        return 0.2;
    }

    public double CalculateChance()
    {
        double chance = 0;
        RainFactor = CalculateRainFactor();

        if (Location.Latitude > 0) chance += random.NextDouble() * 0.2;
        if (Location.Longitude > 0) chance += random.NextDouble() * 0.3;
        if (RainFactor > 0) chance += random.NextDouble() * 0.2;
        if (RainFactor > 0.5) chance += random.NextDouble() * 0.3;

        return chance;
    }
}
