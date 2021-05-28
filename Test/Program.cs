using System;
using System.Diagnostics;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FirstTest firstTest = new FirstTest();
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //firstTest.ConsoleMethod(100000);

            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed.TotalSeconds);


            //stopwatch = new Stopwatch();
            //stopwatch.Start();
            //firstTest.ConsoleMethod2(100000);
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed.TotalSeconds);


            //int[] nums = new int[] { 4, -3, 5, -2, -1, 2, -6, -2 };
            //Console.WriteLine(firstTest.MaxSubseqSum3(nums));
            Console.WriteLine(firstTest.GetMax(45, 5, 67));

        }
    }
}
