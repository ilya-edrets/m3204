using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class FuelExchangeServiceCacheDecorator : IFuelExchangeService
{
    private readonly IFuelExchangeService _inner;

    private readonly Dictionary<decimal, decimal> _cache = new Dictionary<decimal, decimal>();

    public FuelExchangeServiceCacheDecorator(IFuelExchangeService inner)
    {
        _inner = inner;
    }

    public decimal GetPrice(decimal fuelAmount)
    {
        if (_cache.TryGetValue(fuelAmount, out decimal result))
        {
            return result;
        }

        decimal value = _inner.GetPrice(fuelAmount);
        _cache[fuelAmount] = value;

        return value;
    }

    public decimal BuyFuel(decimal money)
    {
        return _inner.BuyFuel(money);
    }
}