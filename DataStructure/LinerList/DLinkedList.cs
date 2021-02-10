using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinerList
{
    /// <summary>
    /// 双链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DLinkedList<T>
    {
        public DLinkedListNode<T> Head = new DLinkedListNode<T>();

        public void CreateListF(params T[] arrData)
        {
            var L = Head;
            for (int i = 0; i < arrData.Length; i++)
            {
                var node = new DLinkedListNode<T>();
                node.Data = arrData[i];

                node.Next = L.Next;
                if (L.Next != null)
                {
                    L.Next.Prior = node;
                }
                L.Next = node;
                node.Prior = L;
            }
        }

        public void CreateListL(params T[] arrData)
        {
            var L = Head;
            var r = L;
            for (int i = 0; i < arrData.Length; i++)
            {
                var node = new DLinkedListNode<T>();
                node.Data = arrData[i];

                r.Next = node;
                node.Prior = r;

                r = node;
            }
            r.Next = null;
        }

        public void ListInsert(int index, T t)
        {
            var p = Head;
            int i = 0;
            while (i < index - 1 && p != null)
            {
                i++;
                p = p.Next;
            }
            if (p != null)
            {
                var node = new DLinkedListNode<T>();
                node.Data = t;

                node.Next = p.Next;
                if (p.Next != null)
                {
                    p.Next.Prior = node;
                }
                node.Prior = p;
                p.Next = node;

            }
        }

        public void ListDelete(int index)
        {
            int i = 0;
            var p = Head;
            while (i < index - 1 && p != null)
            {
                i++;
                p = p.Next;
            }
            if (p != null)
            {
                var q = p.Next;//要删除的点
                if (q != null)
                {
                    p.Next = q.Next;
                    if (p.Next != null)
                    {
                       p.Next.Prior = p;
                    }
                }
                q = null; 
            }
        }

        public void Reverse(DLinkedList<T> list)
        {
            var p = list.Head.Next;
            var L = list.Head;
            L.Next = null;
          
            while (p != null)
            {
                var q = p.Next;

                p.Next = L.Next;
                if (L.Next != null)
                {
                    L.Next.Prior = p;
                }
                L.Next = p;
                p.Prior = L;

                p = q;
            }
        }
    }

    public class DLinkedListNode<T>
    {
        public T Data { get; set; }
        public DLinkedListNode<T> Prior { get; set; }
        public DLinkedListNode<T> Next { get; set; }
        public DLinkedListNode()
        {
            Prior = null;
            Next = null;
        }
    }

}
