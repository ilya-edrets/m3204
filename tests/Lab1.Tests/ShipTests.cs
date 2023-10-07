using System;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Services;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class ShipTests
{
    private readonly JourneyPlannerService _journeyPlannerService;

    public ShipTests()
    {
        var fuelService = new FuelExchangeService();
        var decorator = new FuelExchangeServiceCacheDecorator(fuelService);
        _journeyPlannerService = new JourneyPlannerService(decorator);
    }

    [Theory]
    [InlineData(100, 20, typeof(Ship))]
    [InlineData(21, 20)]
    [InlineData(2000, 200)]
    [InlineData(1, 0)]
    public void TakeSmallDamage(int armorHp, int damage, Type type)
    {
        // Arrange
        var ship = new Ship(
            new ImpulseEngineBase(),
            new JumpingEngineBase(),
            new NullDeflector(),
            new Armor { HitPoints = armorHp });

        var obstacle = new Asteroid { Damage = damage };

        // Act
        ship.TakeDamage(obstacle);

        // Assert
        Assert.True(ship.IsShipAlive);
        Assert.False(obstacle.IsAlive);
    }

    public void Test()
    {
        _journeyPlannerService.Ships
    }
}