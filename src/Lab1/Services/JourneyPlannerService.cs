using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class JourneyPlannerService
{
    private FuelExchangeService _fuelExchangeService;
    private readonly List<Ship> _ships;

    public IReadOnlyList<Ship> Ships => _ships;

    public JourneyPlannerService()
    {
        _fuelExchangeService = new FuelExchangeService();

        _ships = new List<Ship>();
    }

    public Ship FindBestShip(IEnumerable<Ship> ships)
    {
        var ship = new Ship(
            new ImpulseEngineBase(),
            new JumpingEngineBase(),
            new NullDeflector(),
            new Armor { HitPoints = 100 });

        /********
         * Code
         *********/

        JourneyResult journeyResult = ship.Fly();
        var price = _fuelExchangeService.GetPrice(journeyResult.RequiredFuelAmount);

        /********
         * Code
         *********/
        return ship;
    }
}