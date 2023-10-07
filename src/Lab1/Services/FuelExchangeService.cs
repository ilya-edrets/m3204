using System.Threading;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class FuelExchangeService : IFuelExchangeService
{
    private const decimal PricePerUnit = 10;

    public decimal GetPrice(decimal fuelAmount)
    {
        Thread.Sleep(2000 * 60);
        return fuelAmount * PricePerUnit;
    }

    public decimal BuyFuel(decimal money)
    {
        return money / PricePerUnit;
    }
}