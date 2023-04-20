using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade;

public class GeoLocation
{
    public double Latitude { get; init; }
    public double Longitude { get;  init; }

    private static readonly Dictionary<string, GeoLocation> geoLocations = new()
    {
        {"Tokyo", new GeoLocation(35.652832, 139.839478) },
        {"Berlin", new GeoLocation(52.520008, 13.404954) },
        {"Paris", new GeoLocation(48.864716, 2.349014) },
        {"Londom", new GeoLocation(51.509865, -0.118092) },
        {"Osijek", new GeoLocation(45.5511100, 18.6938900) },
        {"Miami", new GeoLocation(25.761681, -80.191788) },
        {"Austin", new GeoLocation(30.266666, -97.733330) }
    };

    private GeoLocation(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public static GeoLocation GetLocationByName(string locationName)
    {
        if (!geoLocations.ContainsKey(locationName))
            return new GeoLocation(0, 0);

        return geoLocations[locationName];
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Latitude, Longitude);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is not GeoLocation) return false;

        GeoLocation other = (GeoLocation)obj;

        return other.GetHashCode() == GetHashCode();
    }
}
