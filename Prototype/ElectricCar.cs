using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype;

public class ElectricCar : ICar
{

    public string Make { get; init; }

    public string Model { get; init; }

    public string LicensePlate { get; init; }

    public double BatterySizeKWh { get; init; }
    public ElectricCar(string make, string model, string licensePlate, double batterySizeKWh)
    {
        Make = make;
        Model = model;
        LicensePlate = licensePlate;
        BatterySizeKWh = batterySizeKWh;
    }

    public ICar Clone()
    {
        return (ICar)this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"{Make} {Model}\nLicense plate: {LicensePlate}\nBattery size: {BatterySizeKWh}kWh\n";
    }
}
