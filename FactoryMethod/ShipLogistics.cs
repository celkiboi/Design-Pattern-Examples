using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod;

public class ShipLogistics : ILogistics
{

    public int StaffCount { get; set; }
    public double AverageSpeedKph { get; set; }
    public decimal StaffPayPerHourDollars { get; set; }
    public ShipLogistics(int staffCount, double averageSpeedKph, decimal staffPayPerHourDollars)
    {
        StaffCount = staffCount;
        AverageSpeedKph = averageSpeedKph;
        StaffPayPerHourDollars = staffPayPerHourDollars;
    }

    public ITransport CreateTransport()
    {
        return new Ship(StaffCount, AverageSpeedKph, StaffPayPerHourDollars);
    }
}
