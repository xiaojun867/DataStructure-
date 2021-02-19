using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinerList
{
    /// <summary>
    /// 循环链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CircularLinkedList<T>
    {
        public DLinkedListNode<T> head { get; set; }

        public void CreateD(params T[] arr)
        {
            head = new DLinkedListNode<T>();
            head.Next = head;
            head.Prior = head;
            var r = head;
            for (int i = 0; i < arr.Length; i++)
            {
                var s = new DLinkedListNode<T>();
                s.Data = arr[i];
                if (head.Next == head)
                {
                    head.Next = s;
                    s.Next = head;
                    s.Prior = head;
                    r = s;
                }
                else
                {
                    s.Next = r.Next;
                    r.Next.Prior = s;
                    s.Prior = r;
                    r.Next = s;
                    r = s;
                }
            }
        }


        public bool IsSymmetric()
        {
            bool b = true;
            var p = head.Next;
            var q = head.Prior;
            while (p != q && p.Next != q)
            {
                if (!object.Equals(p.Data, q.Data))
                {
                    b = false;
                    break;
                }
                p = p.Next;
                q = q.Prior;
            }
            return b;
        }

    }
}
