using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class ComputerDetailsFactory : IComputerDetailsFactory
{
    private readonly IFactory<CpuBase> _cpuFactory;
    private readonly IFactory<MotherBoardBase> _otherBoardFactory;
    private readonly IFactory<RamStickBase> _ramStickFactory;

    public ComputerDetailsFactory(
        IFactory<CpuBase> cpuFactory,
        IFactory<MotherBoardBase> otherBoardFactory,
        IFactory<RamStickBase> ramStickFactory)
    {
        _cpuFactory = cpuFactory;
        _otherBoardFactory = otherBoardFactory;
        _ramStickFactory = ramStickFactory;
    }

    public CpuBase? CreateCpuByName(string cpuName)
    {
        return _cpuFactory.CreateByName(cpuName);
    }
}