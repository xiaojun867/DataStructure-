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

            SequenceList<int> list = new SequenceList<int>(100);
            list.Move3(1, 0, 2, 1, 0, 0, 1, 2, 2, 1, 0, 2);
            //Console.WriteLine("SingleLinkedList");
            //SingleLinkedList<int> list = new SingleLinkedList<int>();
            //list.CreatListL(1,0,2,1,0,0,1,2,2,1,0,2);
            //Console.WriteLine($"获取单链表中最大的节点{list.GetMaxNode(list)}");
            //Console.WriteLine($"删除单链表中最大的节点");
            //list.DelMaxNode(list);

            //list.Split(list);

            // list.Move(list);

        }
    }
}
