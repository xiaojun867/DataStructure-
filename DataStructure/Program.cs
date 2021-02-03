using DataStructure.LinerList;
using System;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello DataStructure!");
            Console.WriteLine("SequenceList");

            Console.WriteLine("SingleLinkedList");
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.CreatListL(2, 5, 4, 456, 2, 35, 57, 343, 4677, 343, 5);
            //Console.WriteLine($"获取单链表中最大的节点{list.GetMaxNode(list)}");
            //Console.WriteLine($"删除单链表中最大的节点");
            //list.DelMaxNode(list);
           
            list.Reverse(list);
            list.DispList();

        }
    }
}
