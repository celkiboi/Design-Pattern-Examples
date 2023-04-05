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
using AbstractFactory;
using AbstractFactory.ConcreteFactories;
using AbstractFactory.Products;
using Builder;

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
        get { return textLogger; }
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

    [TestMethod]
    public void TestDessertFactories()
    {
        IDessertFactory dessertFactory = new ChocolateDessertFactory();
        LogDesserts(dessertFactory);
        dessertFactory = new VanillaDesertFactory();
        LogDesserts(dessertFactory);
    }

    void LogDesserts(IDessertFactory dessertFactory)
    {
        Cookie cookie = dessertFactory.CreateCookie();
        Donut donut = dessertFactory.CreateDonut();
        Cake cake = dessertFactory.CreateCake();

        TextLogger.Log<string>(cookie.ToString());
        TextLogger.Log<string>(donut.ToString());
        TextLogger.Log<string>(cake.ToString());
        TextLogger.EnterNewLine();
    }

    [TestMethod]
    public void TestPizzaDirector()
    {
        IPizzaBuilder pizzaBuilder = new PizzaBuilder();
        PizzaDirector pizzaDirector = new(pizzaBuilder);
        List<Pizza> pizzas = new()
        {
            pizzaDirector.BuildCapricciosa(),
            pizzaDirector.BuildVesuvio(),
            pizzaDirector.BuildPeperoni()
        };

        TextLogger.LogCollection(pizzas);
    }
}
