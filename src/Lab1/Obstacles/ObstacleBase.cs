using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public abstract class ObstacleBase
{
    public int Damage { get; set; }

    public bool IsAlive { get; protected set; }

    public abstract int HitDamage(DeflectorBase deflector);

    public void HitDamage(Armor armor)
    {
        armor?.TakeDamage(this);
    }
}