using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton;

public class RandomGenerator
{
    private static RandomGenerator? instance;
    private readonly Random generator = new();

    static readonly int defaultMinValue = 0;
    static readonly int defaultMaxValue = int.MaxValue;

    private RandomGenerator()
    { }

    public static RandomGenerator Instance
    {
        get
        {
            instance ??= new();
            return instance;
        }
    }

    public int NextInt(int minValue, int maxValue)
    {
        return generator.Next(minValue, maxValue);
    }
    public int NextInt(int maxValue)
    {
        return NextInt(defaultMinValue, maxValue);
    }
    public int NextInt()
    {
        return NextInt(defaultMinValue, defaultMaxValue);
    }
    public double NextDouble()
    {
        return generator.NextDouble();
    }
}