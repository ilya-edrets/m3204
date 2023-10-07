namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public interface IFuelExchangeService
{
    decimal GetPrice(decimal fuelAmount);
    decimal BuyFuel(decimal money);
}