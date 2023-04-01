using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod;

public class TruckLogistics : ILogistics
{
    public double AverageSpeedKph { get; set; }
    public decimal StaffPayPerHourDollars { get; set; }

    public TruckLogistics(double averageSpeedKph, decimal staffPayPerHourDollars)
    {
        AverageSpeedKph = averageSpeedKph;
        StaffPayPerHourDollars = staffPayPerHourDollars;
    }

    public ITransport CreateTransport()
    {
        return new Truck(AverageSpeedKph, StaffPayPerHourDollars);
    }
}
