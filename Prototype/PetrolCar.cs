using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype;

public class PetrolCar : ICar
{
    public string Make { get; init; }

    public string Model { get; init; }

    public string LicensePlate { get; init; }

    public int NumberOfCylinders { get; init; }

    public PetrolCar(string make, string model, string licensePlate, int numberOfCylinders)
    {
        Make = make;
        Model = model;
        LicensePlate = licensePlate;
        NumberOfCylinders = numberOfCylinders;
    }

    public ICar Clone()
    {
        return (ICar)this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"{Make} {Model}\nLicense plate: {LicensePlate}\nNumber od cylinders: {NumberOfCylinders}\n";
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Make, Model, LicensePlate, NumberOfCylinders);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is not ICar) return false;

        return obj.GetHashCode() == GetHashCode();
    }
}
