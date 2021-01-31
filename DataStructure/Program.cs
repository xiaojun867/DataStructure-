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
            Console.WriteLine(list.GetElem(4));
        }
    }
}
