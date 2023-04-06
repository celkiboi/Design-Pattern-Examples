using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype;

public interface ICar
{
    string Make { get; }
    string Model { get; }
    string LicensePlate { get; }
    ICar Clone();
}