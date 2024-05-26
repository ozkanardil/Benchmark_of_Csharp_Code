// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;

Console.WriteLine("String vs StringBuilder!");

var result = BenchmarkRunner.Run<TestClassStringVsStringBuilder>();

[MemoryDiagnoser]
public class TestClassStringVsStringBuilder
{
    private const int N = 1000;

    [Benchmark]
    public string StringConcatenation()
    {
        string result = "";
        for (int i = 0; i < N; i++)
        {
            result += "Welcome";
        }
        return result;
    }

    [Benchmark(Baseline = true)]
    public string StringBuilderConcatenation()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < N; i++)
        {
            sb.Append("Welcome");
        }
        return sb.ToString();
    }
}