using System.Linq;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using Microsoft.VSDiagnostics;

[CPUUsageDiagnoser]
public class NumberSeparatorBenchmark
{
    private int[] arreglo;
    [GlobalSetup]
    public void Setup()
    {
        arreglo = new int[]
        {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10
        };
    }

    [Benchmark(Baseline = true)]
    public void Original()
    {
        int[] pares = new int[arreglo.Length];
        int[] impares = new int[arreglo.Length];
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] % 2 == 0)
            {
                pares[i] = arreglo[i];
            }
            else
            {
                impares[i] = arreglo[i];
            }
        }
    }

    [Benchmark]
    public void UsingLists()
    {
        var pares = new List<int>(arreglo.Length);
        var impares = new List<int>(arreglo.Length);
        foreach (var num in arreglo)
        {
            if (num % 2 == 0)
                pares.Add(num);
            else
                impares.Add(num);
        }

        var paresArray = pares.ToArray();
        var imparesArray = impares.ToArray();
    }

    [Benchmark]
    public void UsingLinq()
    {
        var paresArray = arreglo.Where(x => x % 2 == 0).ToArray();
        var imparesArray = arreglo.Where(x => x % 2 != 0).ToArray();
    }
}