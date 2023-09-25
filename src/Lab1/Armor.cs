namespace Itmo.ObjectOrientedProgramming.Lab1;

public class Armor
{
    public int HP { get; set; }

    public void TakeDamage(ObstacleBase obstacle)
    {
        if (obstacle is not null)
        {
            int actual = obstacle.Damage < this.HP ? obstacle.Damage : this.HP;
            this.HP -= actual;
            obstacle.Damage -= actual;
        }
    }
}