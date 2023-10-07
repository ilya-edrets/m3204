using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public abstract class DeflectorBase
{
    public virtual void TakeDamage(Asteroid obstacle)
    {
    }

    public virtual void TakeDamage(AntiMatterSpark obstacle)
    {
    }

    public virtual void TakeDamage(Cosmokit obstacle)
    {
    }
}