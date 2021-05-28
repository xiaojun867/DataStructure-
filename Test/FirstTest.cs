using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class FirstTest
    {
        public void ConsoleMethod(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                // Console.Write(i);
            }
        }

        public void ConsoleMethod2(int n)
        {
            if (n == 0)
            {
                return;
            }
            ConsoleMethod2(n - 1);

            // Console.Write(n);
        }

        //int[] nums = new int[] { 4, -3, 5, -2, -1, 2, -6, -2  };
        public int MaxSubseqSum2(int[] nums)
        {
            int MaxSum = 0;
            int Sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                Sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    Sum += nums[j];
                    Console.WriteLine(Sum);
                    if (Sum > MaxSum)
                    {
                        MaxSum = Sum;
                    }
                }
            }
            return MaxSum;
        }

        public int MaxSubseqSum3(int[] nums)
        {
            int MaxSum = 0;
            int Sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                Sum += nums[i];
                if (Sum > MaxSum)
                {
                    MaxSum = Sum;
                }
                else if (Sum < 0)
                {
                    Sum = 0;
                }
            }
            return MaxSum;
        }


        public int GetMax(int a,int b,int c)
        {
            return a > b ? a > c ? a : c : b > c ? b : c;
        }


    }
}
