using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _Runner;

internal class NullLoggerException : Exception
{
    const string error = "Cannot test RandomGenerator(Logger property not set to an instance of object)";
    public NullLoggerException() : base(error) { }
}

