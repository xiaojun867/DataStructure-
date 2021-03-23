using System;

namespace DataStructure
{
    /// <summary>
    /// 递归
    /// </summary>
    public class Recursive
    {
        public int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        public int Accumulation(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + Accumulation(n - 1);
            }
        }
        public int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) * Fibonacci(n - 2);
            }
        }
        /// <summary>
        /// xiangbumingbai
        /// </summary>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public void Hanoi(int n, string x, string y, string z)
        {
            if (n == 0)
            {
                return;
            }
            Hanoi(n - 1, x, z, y);
            move(x, z);
            Hanoi(n - 1, y, x, z);
        }
        public void move(string x, string z)
        {
            Console.WriteLine($"移动{x}-->{z}");
        }
        public int Min(int[] arr, int n)
        {
            int m = 0;
            if (n == 0)
            {
                return arr[0];
            }
            else
            {
                m = Min(arr, n - 1);
                if (m > arr[n])
                {
                    return arr[n];
                }
                else
                {
                    return m;
                }
            }
        }
        public int Count(LinerList.LinkedListNode<int> list)
        {
            if (list == null)
            {
                return 0;
            }
            else
            {
                return Count(list.Next);
            }
        }
        public void Traverse(LinerList.LinkedListNode<int> list)
        {
            if (list == null) return;
            Console.WriteLine(list.Data);
            Traverse(list.Next);
        }
        public void TraverseR(LinerList.LinkedListNode<int> list)
        {
            if (list == null) return;
            TraverseR(list.Next);
            Console.WriteLine(list.Data);
        }
        #region 递归求解迷宫
        public class Box
        {
            public int i { get; set; }
            public int j { get; set; }
            public int di { get; set; }
        }
        public class PathType
        {
            public Box[] Data { get; set; }
            public int Length { get; set; }
            public PathType()
            {
                Data = new Box[100];
            }
        }
        private int[,] mg = new int[,] {
            //{1,1,1,1,1,1,1,1,1,1},
            //{1,0,0,1,0,0,0,1,0,1},
            //{1,0,0,1,0,0,0,1,0,1},
            //{1,0,0,0,0,1,1,0,0,1},
            //{1,0,1,1,1,0,0,0,0,1},
            //{1,0,0,0,1,0,0,0,0,1},
            //{1,0,1,0,0,0,1,0,0,1},
            //{1,0,1,1,1,0,1,1,0,1},
            //{1,1,0,0,0,0,0,0,0,1},
            //{1,1,1,1,1,1,1,1,1,1}
            {1,1,1,1,1,1},
            {1,0,0,0,1,1},
            {1,0,1,0,0,1},
            {1,0,0,0,1,1},
            {1,1,0,0,0,1},
            {1,1,1,1,1,1}
        };
        public void mgPath(int xi, int yi, int xe, int ye, PathType path)
        {

        }
        #endregion



    }
}
