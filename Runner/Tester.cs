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
using Prototype;
using Adapter;
using Composite;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using Decorator;
using Facade;
using Bridge;

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

    [TestMethod]
    public void TestPrototypeCar()
    {
        List<ICar> cars = new()
        {
            new PetrolCar("Porsche", "911 Targa GTS", "OS-911-TG", 6),
            new PetrolCar("Ferrari", "812 GTS", "ZG-812-GTS", 12),
            new ElectricCar("Rimac", "Nevera", "ZG-1914-HP", 120),
            new ElectricCar("Porsche", "Taycan Turbo S", "OS-560-KW", 93.4)
        };

        TextLogger.LogCollection(cars);
    }

    [TestMethod]
    public void TestColdCuts()
    {
        List<IColdCuts> cuts = new()
        {
            new MeatCuts(20, 100, "Peperonni"),
            new CheeseCutsAdapter(30, 200, "Gouda")
        };

        TextLogger.LogCollection(cuts);

        TextLogger.EnterNewLine();
        foreach (IColdCuts product in cuts)
        {
            TextLogger.Log($"Price of {product.ProductName} is: ");
            TextLogger.Log(product.CalculatePrice());
            TextLogger.EnterNewLine();
        }
    }

    [TestMethod]
    public void TestFileSystem()
    {
        Folder folder = new("Folder");
        folder.AddContent(new Composite.File("text.txt", 512));

        Folder nestedFolder = new("Nested Folder");
        nestedFolder.AddContent(new Composite.File("word.doc", 1024));
        folder.AddContent(nestedFolder);

        TextLogger.Log($"Folder size: {folder.SizeBytes}");
    }

    [TestMethod]
    public void TestCandyBars()
    {
        ICandyBar candyBar = new CandyBar();
        candyBar = new MilkCandyBarDecorator(candyBar);
        candyBar = new CoconutCandyBarDecorator(candyBar);
        candyBar = new ChocolateCandyBarDecorator(candyBar);

        TextLogger.Log(candyBar.GetName());
    }

    [TestMethod]
    public void TestWeather()
    {
        List<WeatherForcast> weatherList = new()
        {
            new("Osijek"),
            new("Miami"),
            new("Tokyo"),
            new("Paris"),
            new("Berlin"),
            new("Austin")
        };

        foreach(WeatherForcast weather in weatherList)
        {
            TextLogger.Log(weather.GetWeatherForcast());
            TextLogger.EnterNewLine();
        }
    }

    [TestMethod]
    public void TestRemotes()
    {
        Radio radio = new();
        Remote remote = new InfraredRemote(radio);
        remote.IncrementSound();
        TextLogger.Log(radio.VolumeLevel);
    }
}
