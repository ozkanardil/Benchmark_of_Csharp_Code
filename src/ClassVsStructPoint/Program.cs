// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

Console.WriteLine("Hello, World!");

var result = BenchmarkRunner.Run<TestsClass>();

public class PointClass
{
    public int X { get; set; }
    public int Y { get; set; }
    public PointClass(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class PointClassFinalized : PointClass
{
    public PointClassFinalized(int x, int y) : base(x, y)
    {
    }
    ~PointClassFinalized()
    {
        // added a finalizer to slow down the GC

    }
}

public struct PointStruct
{
    public int X { get; set; }
    public int Y { get; set; }
    public PointStruct(int x, int y)
    {
        X = x;
        Y = y;
    }
}

[MemoryDiagnoser]
public class TestsClass
{
    const int Iterations = 1000000;

    [Benchmark]
    public bool TestPointClassFinalized()
    {
        // access array elements
        var list = new PointClassFinalized[Iterations];
        for (int i = 0; i < Iterations; i++)
        {
            list[i] = new PointClassFinalized(i, i);
        }
        return true;
    }

    [Benchmark]
    public bool TestPointClass()
    {
        // access array elements
        var list = new PointClass[Iterations];
        for (int i = 0; i < Iterations; i++)
        {
            list[i] = new PointClass(i, i);
        }
        return true;
    }

    [Benchmark]
    public bool TestPointStruct()
    {
        // access array elements
        var list = new PointStruct[Iterations];
        for (int i = 0; i < Iterations; i++)
        {
            list[i] = new PointStruct(i, i);
        }
        return true;
    }
}