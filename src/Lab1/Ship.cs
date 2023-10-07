#pragma warning disable CA1822

using System;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class Ship
{
    public Ship(
        ImpulseEngineBase impulseEngine,
        JumpingEngineBase? jumpingEngine,
        DeflectorBase deflector,
        Armor armor)
    {
        IsShipAlive = true;
        IsTeamAlive = true;
        ImpulseEngine = impulseEngine ?? throw new ArgumentNullException(nameof(impulseEngine));
        JumpingEngine = jumpingEngine;
        Deflector = deflector ?? new NullDeflector();
        Armor = armor;
    }

    public bool IsShipAlive { get; private set; }

    public bool IsTeamAlive { get; private set; }

    public ImpulseEngineBase ImpulseEngine { get; }

    public JumpingEngineBase? JumpingEngine { get; }

    public DeflectorBase Deflector { get; }

    public Armor Armor { get; }

    public void TakeDamage(ObstacleBase obstacle)
    {
        obstacle = obstacle ?? throw new ArgumentNullException(nameof(obstacle));

        int i = obstacle switch
        {
            AntiMatterSpark antiMatterSpark => antiMatterSpark.HitDamage(Deflector),
            Asteroid asteroid => asteroid.HitDamage(Deflector),
            Cosmokit cosmokit => cosmokit.HitDamage(Deflector),
        };

        obstacle.HitDamage(Deflector);
        obstacle.HitDamage(Armor);

        if (obstacle.IsAlive)
        {
            IsTeamAlive = false;
        }
    }

    public JourneyResult Fly()
    {
        return new JourneyResult(100);
    }
}