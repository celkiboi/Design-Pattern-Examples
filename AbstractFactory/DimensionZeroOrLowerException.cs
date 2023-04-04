using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory;
public class DimensionZeroOrLowerException : Exception
{
    public DimensionZeroOrLowerException(string dimensionName)
        : base($"Dimension {dimensionName} cannot be 0 or lower")
    { }
}

