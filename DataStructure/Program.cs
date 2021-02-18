using DataStructure.LinerList;
using DataStructure.Maze;
using DataStructure.Stack;
using System;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello DataStructure!");
            //Console.WriteLine("SequenceList");

            //SequenceList<int> list = new SequenceList<int>(100);
            //list.Move3(1, 0, 2, 1, 0, 0, 1, 2, 2, 1, 0, 2);
            //Console.WriteLine("SingleLinkedList");
            //SingleLinkedList<int> list = new SingleLinkedList<int>();
            //list.CreatListL(1, 0, 2, 1, 0, 0, 1, 2, 2, 1, 0, 2);
            //Console.WriteLine($"获取单链表中最大的节点{list.GetMaxNode(list)}");
            //Console.WriteLine($"删除单链表中最大的节点");
            //list.DelMaxNode(list);
            //list.Split(list);
            //list.Move(list);

            //Console.WriteLine("DLinkedList");
            //DLinkedList<int> list = new DLinkedList<int>();
            //list.CreateListF(1, 2, 3);
            //list.CreateListL(1, 2, 3, 4, 5, 6, 7, 8, 9);
            //list.ListInsert(3, 23);
            //list.ListDelete(3);
            //list.Reverse(list);

            // CircularLinkedList<int> listC = new CircularLinkedList<int>();
            //list= listC.CreateD(list);
            //是否对称相等不懂
            //listC.Equal(list);
            //第三讲不懂



            //SequenceList<int> listSeq = new SequenceList<int>(5);
            //listSeq.CreateList(1, 5, 9);

            //SingleLinkedList<int> listLink = new SingleLinkedList<int>();
            //listLink.CreatListL(1, 5, 9);

            //OrderedList list = new OrderedList();
            //list.ListInsert(listLink, 6);


            //SequenceList<int> listA = new SequenceList<int>(10);
            //listA.CreateList(1, 3, 5);
            //SequenceList<int> listB = new SequenceList<int>(10);
            //listB.CreateList(2, 4, 6, 8);

            //SequenceList<int> listC = new SequenceList<int>(10);
            //OrderedList list = new OrderedList();


            // SequenceList<int> listA = new SequenceList<int>(5);
            // listA.CreateList(11,13,15,17,19);
            // SequenceList<int> listB = new SequenceList<int>(5);
            // listB.CreateList(2, 4, 6, 8,20);

            // OrderedList list = new OrderedList();
            //int i= list.M_Search(listA, listB);


            //SequenceList<int> listS = new SequenceList<int>(6);
            //listS.CreateList(1,1,1,2,2,3);

            //OrderedList list = new OrderedList();
            //list.DelRepetData(listS);


            //OrderedList list = new OrderedList();

            //SingleLinkedList<int> listA = new SingleLinkedList<int>();
            //listA.CreatListL(1,2,3);
            //SingleLinkedList<int> listB = new SingleLinkedList<int>();
            //listB.CreatListL(2,3,4);

            //SingleLinkedList<int> listC = new SingleLinkedList<int>();
            //list.InterSect(listA, listB, listC);



            //SeqStackApp sequenceStack = new SeqStackApp();
            //sequenceStack.IsSymmetry("123445453");

            //LinkedStackApp linkedStack = new LinkedStackApp();
            //Console.WriteLine(linkedStack.IsSymmetry2(")())"));
            //Console.WriteLine(linkedStack.IsSymmetry2("()()"));
            //Console.WriteLine(linkedStack.IsSymmetry2(")()"));
            //Console.WriteLine(linkedStack.IsSymmetry2("(()))"));


            //MazeByStack mazeByStack = new MazeByStack();
            //mazeByStack.MgPath(1, 1, 8, 8);
            MazeByQueue mazeByQueue = new MazeByQueue();
            mazeByQueue.MgPath(1, 1, 8, 8);

        }
    }
}
