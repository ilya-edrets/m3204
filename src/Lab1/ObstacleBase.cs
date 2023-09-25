namespace Itmo.ObjectOrientedProgramming.Lab1;

public class ObstacleBase
{
    public int Damage { get; set; }

    public bool IsAlive => Damage > 0;
}