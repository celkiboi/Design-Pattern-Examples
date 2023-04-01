using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;
using FactoryMethod;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _Runner;

[TestClass]
class Tester
{
    private ITextLogger textLogger;

    public Tester(ITextLogger textLogger)
    {
        this.textLogger = textLogger;
    }

    public ITextLogger TextLogger
    {
        get { return TextLogger; }
        set
        {
            if (value is null)
                throw new NullLoggerException();
            textLogger = value;
        }
    }

    [TestMethod]
    public void TestRandomGenerator()
    {
        textLogger.Log("Testing if all references of singleton are equal...");
        bool result = ReferenceEquals(RandomGenerator.Instance, RandomGenerator.Instance);

        textLogger.EnterNewLine();
        textLogger.Log(result);

        textLogger.EnterNewLine();
        List<int> numbers = new();
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(RandomGenerator.Instance.NextInt(0, 10));
        }
        textLogger.LogCollection(numbers);
        textLogger.EnterNewLine();
    }

    [TestMethod]
    public void TestShipmentManager()
    {
        ILogistics logistics = new TruckLogistics(40, 30);
        ShipmentManager shipmentManager = new(logistics);
        textLogger.Log(shipmentManager.CalculateShipmentDollars(300));
        textLogger.EnterNewLine();

        shipmentManager.Logistics = new ShipLogistics(10, 30, 50);
        textLogger.Log(shipmentManager.CalculateShipmentDollars(300));
        textLogger.EnterNewLine();
    }
}
