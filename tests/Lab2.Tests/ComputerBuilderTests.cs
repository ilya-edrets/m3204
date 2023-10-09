using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class ComputerBuilderTests
{
    private readonly ComputerDetailsFactory _computerDetailsFactory;

    public ComputerBuilderTests()
    {
        var cpuList = new List<CpuBase>();
        cpuList.Add(new LGA1700Cpu { Name = "Intel i7 13600H" });
        cpuList.Add(new LGA1700Cpu { Name = "Intel i7 13600H" });
        cpuList.Add(new LGA1700Cpu { Name = "Intel i7 13600H" });
        cpuList.Add(new LGA1700Cpu { Name = "Intel i7 13800H" });
        cpuList.Add(new LGA1700Cpu { Name = "Intel i7 13215H" });
        cpuList.Add(new LGA1700Cpu { Name = "Intel i7 13600H" });
        cpuList.Add(new LGA1700Cpu { Name = "Intel i7 13600H" });

        var cpuFactory = new CpuFactory(cpuList);
        _computerDetailsFactory = new ComputerDetailsFactory(cpuFactory, null, null);
    }

    [Theory]
    [InlineData("Intel i7")]
    public void Test1(string cpuName)
    {
        var cpu = _computerDetailsFactory.CreateCpuByName(cpuName);
    }
}