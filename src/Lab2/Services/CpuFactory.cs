using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class CpuFactory : IFactory<CpuBase>
{
    private readonly List<CpuBase> _cpuList;

    public CpuFactory(List<CpuBase> cpuList)
    {
        _cpuList = cpuList;
    }

    public CpuBase? CreateByName(string cpuName)
    {
        return _cpuList.FirstOrDefault(cpu => cpu.Name.Equals(cpuName, StringComparison.OrdinalIgnoreCase));
    }
}