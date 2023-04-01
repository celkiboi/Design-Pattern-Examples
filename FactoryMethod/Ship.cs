using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod;

public class Ship : ITransport
{

    public int StaffCount { get; init; }
    public double AverageSpeedKph { get; init; }
    public decimal StaffPayDollarsPerHour { get; init; }

    const decimal internationWatersTax = 0.2m;
    const decimal seaWorthyTax = 0.15m;

    public Ship(int staffCount, double averageSpeed, decimal staffPayDollarsPerHour)
    {
        StaffCount = staffCount;
        AverageSpeedKph = averageSpeed;
        StaffPayDollarsPerHour = staffPayDollarsPerHour;
    }

    decimal CalculateBaseTransportCostDollars(double distanceKm) 
    {
        return StaffCount * CalculateTransportDuration(distanceKm).Hours * StaffPayDollarsPerHour;
    }

    public decimal CalculateTransportCostDollars(double distanceKm)
    {

        return CalculateBaseTransportCostDollars(distanceKm)
            + CalculateBaseTransportCostDollars(distanceKm) * seaWorthyTax
            + CalculateBaseTransportCostDollars(distanceKm) * internationWatersTax;
    }

    public TimeSpan CalculateTransportDuration(double distanceKm)
    {
        return TimeSpan.FromHours(distanceKm / AverageSpeedKph);
    }
}
