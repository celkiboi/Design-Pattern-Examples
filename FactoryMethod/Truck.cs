using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod;

class Truck : ITransport
{
    public int StaffCount { get; init; }
    public double AverageSpeedKph { get; init; }
    public decimal StaffPayDollarsPerHour { get; init; }

    const decimal gasGuzzlerTax = 0.25m;
    const decimal higwayTax = 0.08m;

    public Truck(double averageSpeed, decimal staffPayDollarsPerHour)
    {
        StaffCount = 1;
        AverageSpeedKph = averageSpeed;
        StaffPayDollarsPerHour = staffPayDollarsPerHour;
    }

    decimal CalculateBaseTransportCostDollars(double distanceKm)
    {
        return StaffCount * CalculateTransportDuration(distanceKm).Hours * StaffPayDollarsPerHour;
    }

    public decimal CalculateTransportCostDollars(double distanceKm)
    {
        return CalculateBaseTransportCostDollars(distanceKm) +
            CalculateBaseTransportCostDollars(distanceKm) * gasGuzzlerTax +
            CalculateBaseTransportCostDollars(distanceKm) * higwayTax;
    }

    public TimeSpan CalculateTransportDuration(double distanceKm)
    {
        return TimeSpan.FromHours(distanceKm / AverageSpeedKph);
    }
}
