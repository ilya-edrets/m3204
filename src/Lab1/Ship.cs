using System;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class Ship
{
    public Ship(
        ImpulseEngineBase impulseEngine,
        JumpingEngineBase? jumpingEngine,
        DeflectorBase deflector,
        Armor armor)
    {
        IsAlive = true;
        ImpulseEngine = impulseEngine ?? throw new ArgumentNullException(nameof(impulseEngine));
        JumpingEngine = jumpingEngine;
        Deflector = deflector ?? new NullDeflector();
        Armor = armor;
    }

    public bool IsAlive { get; private set; }

    public ImpulseEngineBase ImpulseEngine { get; }

    public JumpingEngineBase? JumpingEngine { get; }

    public DeflectorBase Deflector { get; }

    public Armor Armor { get; }

    public void TakeDamage(ObstacleBase obstacle)
    {
        obstacle = obstacle ?? throw new ArgumentNullException(nameof(obstacle));

        this.Deflector.TakeDamage(obstacle);
        this.Armor.TakeDamage(obstacle);

        if (obstacle.Damage > 0)
        {
            this.IsAlive = false;
        }
    }
}