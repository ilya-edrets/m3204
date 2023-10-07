using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public sealed class Cosmokit : ObstacleBase
{
    public override int HitDamage(DeflectorBase deflector)
    {
        deflector?.TakeDamage(this);
    }
}