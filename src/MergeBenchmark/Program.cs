// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;

Console.WriteLine("Merging!");

var result = BenchmarkRunner.Run<MergeArraysBenchmark>();

[MemoryDiagnoser]
public class MergeArraysBenchmark
{
    private int[] arr1 = new int[15] { 2, 8, 22, 100, 1251, 1500, 1777, 1778, 1779, 1800, 1801, 1802, 1803, 1804, 1805 };
    private int[] arr2 = new int[17] { 1, 3, 9, 23, 55, 123, 146, 171, 200, 201, 202, 203, 204, 205, 206, 207, 208 };

    [Benchmark(Baseline = true)]
    public int[] UsedPartialArrays()
    {
        int[] result = new int[arr1.Length + arr2.Length];
        int iterateCounter = arr1.Length > arr2.Length ? arr1.Length : arr2.Length;
        int counter = 0;
        int resultCounter = 0;

        while (counter < iterateCounter)
        {
            if (counter < arr1.Length && counter < arr2.Length)
            {
                if (arr1[counter] < arr2[counter])
                {
                    result[resultCounter] = arr1[counter];
                    result[resultCounter + 1] = arr2[counter];
                }
                else
                {
                    result[resultCounter] = arr2[counter];
                    result[resultCounter + 1] = arr1[counter];
                }
                resultCounter++;
            }
            else if (counter >= arr1.Length && counter < arr2.Length)
            {
                result[resultCounter] = arr2[counter];
            }
            else
            {
                result[resultCounter] = arr1[counter];
            }
            resultCounter++;
            counter++;
        }
        return result;
    }

    [Benchmark]
    public int[] UsedSortArrays()
    {
        int[] result = new int[arr1.Length + arr2.Length];
        int resultCounter = 0;

        for (int i = 0; i < arr1.Length; i++)
        {
            result[resultCounter] = arr1[i];
            resultCounter++;
        }
                
        for (int j = 0; j < arr2.Length; j++)
        {
            result[resultCounter] = arr2[j];
        }

        Array.Sort(result);

        return result;
    }

    [Benchmark]
    public int[] UsedPriorityQueue()
    {
        PriorityQueue<int, int> pk = new PriorityQueue<int, int>();

        for (int i = 0; i < arr1.Length; i++)
        {
            pk.Enqueue(arr1[i], arr1[i]);
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            pk.Enqueue(arr2[i], arr2[i]);
        }

        int[] result = new int[pk.Count];
        int counter = 0;
        while (pk.Count > 0)
        {
            result[counter] = pk.Dequeue();
            counter++;
        }

        return result;
    }

}