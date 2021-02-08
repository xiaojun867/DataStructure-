using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinerList
{
    public class CircularLinkedList<T>
    {
        /// <summary>
        /// 循环双链表
        /// </summary>
        /// <param name="list"></param>
        public DLinkedList<T> CreateD(DLinkedList<T> list)
        {
            var p = list.Head;

            while (p != null)
            {
                var q = p.Next;
                if (p.Next == null)
                {
                    p.Next = list.Head;
                    list.Head.Prior = p;
                }
                p = q;

            }
            return list;
        }

        public int Equal(DLinkedList<int> list)
        {
            return 0;
        }
    }
}
