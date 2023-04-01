using Singleton;

namespace _Runner;

class Program
{
    public static void Main()
    {
        Tester tester = new(new ConsoleLogger(','));
        tester.TestShipmentManager();
    }
}