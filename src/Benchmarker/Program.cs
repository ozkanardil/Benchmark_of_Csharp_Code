// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;

Console.WriteLine("Hello, World!");

var result = BenchmarkRunner.Run<Demo>();


[MemoryDiagnoser]
public class Demo
{
    [Benchmark]
    public string GetFullStringNormally()
    {
        string output = "";

        for (int i = 0; i < 1000; i++)
        {
            output += i;
        }

        return output;
    }

    [Benchmark(Baseline = true)]
    public string GetFullStringStringBuilder()
    {
        StringBuilder output = new StringBuilder();

        for (int i = 0; i < 1000; i++)
        {
            output.Append(i);
        }

        return output.ToString();
    }
}