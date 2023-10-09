using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public interface IComputerDetailsFactory
{
    CpuBase? CreateCpuByName(string cpuName);
}