using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class ShipTests
{
    [Theory]
    [InlineData(100, 20)]
    [InlineData(21, 20)]
    [InlineData(2000, 200)]
    [InlineData(1, 0)]
    public void TakeSmallDamage(int armorHP, int damage)
    {
        // Arrange
        var ship = new Ship(
            new ImpulseEngineBase(),
            new JumpingEngineBase(),
            new NullDeflector(),
            new Armor { HP = armorHP });

        var obstacle = new ObstacleBase { Damage = damage };

        // Act
        ship.TakeDamage(obstacle);

        // Assert
        Assert.True(ship.IsAlive);
        Assert.False(obstacle.IsAlive);
    }
}