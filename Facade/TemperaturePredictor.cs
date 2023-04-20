using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Facade;

public class TemperaturePredictor
{
    public GeoLocation Location { get; set; }
    readonly Random random = new();

    public TemperaturePredictor(GeoLocation location) 
    {
        Location = location;
    }

    public double CalculateTemperature()
    {
        double temperature = Location.Latitude / Location.Longitude;

        if(temperature > 0 || temperature < -25) temperature = 0;

        if (DateTime.Now.Month >= 4 && DateTime.Now.Month <= 10)
            temperature += random.NextDouble() * 20;
        else
            temperature += random.NextDouble() * 10;

        return temperature;
    }
}
