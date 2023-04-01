using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod;

public interface ITransport
{
    int StaffCount { get; init; }

    double AverageSpeedKph { get; init; }

    decimal StaffPayDollarsPerHour { get; init; }

    decimal CalculateTransportCostDollars(double distanceKm);

    TimeSpan CalculateTransportDuration(double distanceKm);
}
