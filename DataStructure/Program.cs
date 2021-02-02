using DataStructure.LinerList;
using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SequenceList<int> list = new SequenceList<int>(5, 2, 3, 4, 5);
            list.Move1(3, 8, 2, 7, 1, 5, 3, 4, 6, 0);
            Console.WriteLine("************************");
            list.Move2(5,6,2,7,8);
        }
    }
}
