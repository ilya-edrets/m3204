using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public sealed interface IHitDamage
{
    int HitDamage(DeflectorBase deflector);
}