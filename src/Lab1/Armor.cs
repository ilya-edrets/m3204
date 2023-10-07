using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class Armor
{
    public int HitPoints { get; set; }

    public void TakeDamage(ObstacleBase obstacle)
    {
        if (obstacle is null) return;

        int actual = obstacle.Damage < this.HitPoints ? obstacle.Damage : this.HitPoints;
        this.HitPoints -= actual;
        obstacle.Damage -= actual;
    }
}