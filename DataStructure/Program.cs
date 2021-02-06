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
            SingleLinkedList<string> list = new SingleLinkedList<String>();
            list.CreatListL("a1","b1","a2","b2");
            //Console.WriteLine($"获取单链表中最大的节点{list.GetMaxNode(list)}");
            //Console.WriteLine($"删除单链表中最大的节点");
            //list.DelMaxNode(list);
           
           //list.Split(list);

            

        }
    }
}
