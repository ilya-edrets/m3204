using System;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class JourneyResult
{
    public JourneyResult(decimal requiredFuelAmount)
    {
        if (requiredFuelAmount < 0)
        {
            throw new ArgumentException("requiredFuelAmount must be positive", nameof(requiredFuelAmount));
        }

        RequiredFuelAmount = requiredFuelAmount;
    }

    public decimal RequiredFuelAmount { get; private set; }

    public void AddRequiredFuelAmount(decimal requiredFuelAmount)
    {
        if (requiredFuelAmount < 0)
        {
            throw new ArgumentException("requiredFuelAmount must be positive", nameof(requiredFuelAmount));
        }

        RequiredFuelAmount = requiredFuelAmount;
    }
}