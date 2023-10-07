using System;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class PhotonicDeflector : DeflectorBase
{
    private int _protectionCount = 3;

    public override void TakeDamage(AntiMatterSpark obstacle)
    {
        obstacle = obstacle ?? throw new ArgumentNullException(nameof(obstacle));

        if (_protectionCount > 0)
        {
            _protectionCount--;
            obstacle.Destroy();
        }
    }
}