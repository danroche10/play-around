using System;
using System.Collections.Generic;
using System.Diagnostics;


public class ListArrayTest
{

    //List int
    public void ListInt(int iterations)
    {
        List<int> li = new List<int>();

        for (int i = 0; i < iterations; i++)
        {
            li.Add(i);
        }
    }

    //List object
    public void ListObject(int iterations)
    {
        List<object> li = new List<object>();

        for (int i = 0; i < iterations; i++)
        {
            li.Add(i);
        }
    }

    //List long
    public void ListLong(long iterations)
    {
        List<long> li = new List<long>();

        for (int i = 0; i < iterations; i++)
        {
            li.Add(i);
        }
    }

    //List ulong
    public void ListUlong(ulong iterations)
    {
        List<ulong> li = new List<ulong>();

        for (ulong i = 0; i < iterations; i++)
        {
            li.Add(i);
        }
    }

    //Array int
    public void ArrayInt(int iterations)
    {
        int[] a = new int[iterations];

        for (int i = 0; i < iterations; i++)
        {
            a[i] = i;
        }
    }

    //Array object
    public void ArrayObject(int iterations)
    {
        object[] a = new object[iterations];

        for (int i = 0; i < iterations; i++)
        {
            a[i] = i;
        }
    }

    //Array long
    public void ArrayLong(long iterations)
    {
        long[] a = new long[iterations];

        for (long i = 0; i < iterations; i++)
        {
            a[i] = i;
        }
    }

    //Array ulong
    public void ArrayUlong(ulong iterations)
    {
        ulong[] a = new ulong[iterations];

        for (ulong i = 0; i < iterations; i++)
        {
            a[i] = i;
        }
    }

}
public class Program
{
    public static void Main(string[] args)
    {
        ListArrayTest listArrayTest = new ListArrayTest();
        Stopwatch stopWatch = new Stopwatch();
        int iterations = 10000;

        //List int
        stopWatch.Start();
        listArrayTest.ListInt(iterations);
        stopWatch.Stop();
        Console.WriteLine("List<int> => " + stopWatch.ElapsedTicks);
        stopWatch.Reset();

        //List object
        stopWatch.Start();
        listArrayTest.ListObject(iterations);
        stopWatch.Stop();
        Console.WriteLine("List<object> => " + stopWatch.ElapsedTicks);
        stopWatch.Reset();

        //List long
        stopWatch.Start();
        listArrayTest.ListLong(iterations);
        stopWatch.Stop();
        Console.WriteLine("List<long> => " + stopWatch.ElapsedTicks);
        stopWatch.Reset();

        //List ulong
        stopWatch.Start();
        listArrayTest.ListUlong((ulong)iterations);
        stopWatch.Stop();
        Console.WriteLine("List<ulong> => " + stopWatch.ElapsedTicks);
        stopWatch.Reset();

        //Array int
        stopWatch.Start();
        listArrayTest.ArrayInt(iterations);
        stopWatch.Stop();
        Console.WriteLine("Array<int> => " + stopWatch.ElapsedTicks);
        stopWatch.Reset();

        //Array object
        stopWatch.Start();
        listArrayTest.ArrayObject(iterations);
        stopWatch.Stop();
        Console.WriteLine("Array<object> => " + stopWatch.ElapsedTicks);
        stopWatch.Reset();

        //Array long
        stopWatch.Start();
        listArrayTest.ArrayLong(iterations);
        stopWatch.Stop();
        Console.WriteLine("Array<long> => " + stopWatch.ElapsedTicks);
        stopWatch.Reset();

        //Array ulong
        stopWatch.Start();
        listArrayTest.ArrayUlong((ulong)iterations);
        stopWatch.Stop();
        Console.WriteLine("Array<ulong> => " + stopWatch.ElapsedTicks);
        stopWatch.Reset();

        Console.ReadKey();
    }
}