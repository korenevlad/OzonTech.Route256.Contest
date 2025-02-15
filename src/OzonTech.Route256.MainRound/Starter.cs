namespace OzonTech.Route256.Mainround;

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Obj
{
    public long Value { get; }
    public long Index { get; }

    // Конструктор класса Obj
    public Obj(long value, long index)
    {
        Value = value;
        Index = index;
    }
}

class Program
{
    static void Main()
    {
        using (var input = new StreamReader(Console.OpenStandardInput()))
        using (var output = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true })
        {
            long t = long.Parse(input.ReadLine());

            for (long testCase = 0; testCase < t; testCase++)
            {
                int m = int.Parse(input.ReadLine());
                var b = input.ReadLine().Split().Select(long.Parse).ToArray();
                int n = int.Parse(input.ReadLine());
                var a = input.ReadLine().Split().Select(long.Parse).ToArray();


                List<Obj> listb = new List<Obj>();
                for (long i = 0; i < m; i++)
                {
                    listb.Add(new Obj(b[i], i));
                }
                List<Obj> lista = new List<Obj>();
                for (long i = 0; i < n; i++)
                {
                    lista.Add(new Obj(a[i], i));
                }
                var sortedListA = lista.OrderBy(obj => obj.Value).ToList();
                var sortedListB = listb.OrderBy(obj => obj.Value).ToList();
                long[] ans = new long[sortedListA.Count];
                int k = 0;
                long min_ = 1000000000000000000l;
                long max_ = 0l;
                for (int i = 0; i < sortedListA.Count; i++)
                {
                    ans[sortedListA[i].Index] = sortedListB[k].Index;
                    if (Math.Ceiling((double)sortedListA[i].Value / (double)sortedListB[k].Value) < min_)
                    {
                        min_ = (long)Math.Ceiling((double)sortedListA[i].Value / (double)sortedListB[k].Value);
                    }
                    if (Math.Ceiling((double)sortedListA[i].Value / (double)sortedListB[k].Value) > max_)
                    {
                        max_ = (long)Math.Ceiling((double)sortedListA[i].Value / (double)sortedListB[k].Value);
                    }
                    if (k < sortedListB.Count - 1 && i < sortedListA.Count - 1)
                    {
                        long min1 = min_;
                        long max1 = max_;
                        if (Math.Ceiling((double)sortedListA[i + 1].Value / (double)sortedListB[k].Value) < min1)
                        {
                            min1 = (long)Math.Ceiling((double)sortedListA[i].Value / (double)sortedListB[k].Value);
                        }
                        if (Math.Ceiling((double)sortedListA[i + 1].Value / (double)sortedListB[k].Value) > max1)
                        {
                            max1 = (long)Math.Ceiling((double)sortedListA[i].Value / (double)sortedListB[k].Value);
                        }
                        ++k;
                        long min2 = min_;
                        long max2 = max_;
                        if (Math.Ceiling((double)sortedListA[i + 1].Value / (double)sortedListB[k].Value) < min2)
                        {
                            min2 = (long)Math.Ceiling((double)sortedListA[i].Value / (double)sortedListB[k].Value);
                        }
                        if (Math.Ceiling((double)sortedListA[i + 1].Value / (double)sortedListB[k].Value) > max2)
                        {
                            max2 = (long)Math.Ceiling((double)sortedListA[i].Value / (double)sortedListB[k].Value);
                        }
                        if (max1 - min1 < max2 - min2)
                        {
                            --k;
                        }
                    }
                }
                output.WriteLine(max_ - min_);
                for (long i = 0; i < n; ++i)
                {
                    output.Write(ans[i] + 1);
                    output.Write(" ");
                }
                output.WriteLine();
            }
        }
    }
}

