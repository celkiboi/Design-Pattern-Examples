using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade;

public class WeatherForcast
{
    readonly GeoLocation location;
    readonly TemperaturePredictor temperaturePredictor;
    readonly RainPredictor rainPredictor;

    public WeatherForcast(string locationName)
    {
        location = GeoLocation.GetLocationByName(locationName);
        temperaturePredictor = new(location);
        rainPredictor = new(location);
    }

    public string GetWeatherForcast()
    {
        StringBuilder stringBuilder = new();

        double temperature = temperaturePredictor.CalculateTemperature();
        stringBuilder.Append($"Temperature: {double.Round(temperature)}°C\n");

        double rain = rainPredictor.CalculateChance();
        stringBuilder.Append($"Rain chances: {double.Round(rain * 100)}%\n");

        return stringBuilder.ToString();
    }
}
