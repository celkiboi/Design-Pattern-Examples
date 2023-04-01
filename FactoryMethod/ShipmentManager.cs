using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod;

public class ShipmentManager
{
    public ILogistics Logistics { get; set; }

    public ShipmentManager(ILogistics logistics)
    {
        Logistics = logistics;
    }

    public decimal CalculateShipmentDollars(double distance)
    {
        ITransport transport = Logistics.CreateTransport();

        return transport.CalculateTransportCostDollars(distance);
    }
}
