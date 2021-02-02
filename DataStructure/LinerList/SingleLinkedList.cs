using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinerList
{
    public class SingleLinkedList<T>
    {
        Node<T> Head = new Node<T>();
        private int _count;
        public int Count { get { return _count; } }
        public void CreatListF(params T[] arrT)
        {
            for (int i = 0; i < arrT.Length; i++)
            {
                Node<T> node = new Node<T>(arrT[i]);
                node.Next = Head.Next;
                Head.Next = node;
                _count++;
            }

        }
        public void CreatListL(params T[] arrT)
        {
            Node<T> point = Head;
            for (int i = 0; i < arrT.Length; i++)
            {
                Node<T> node = new Node<T>(arrT[i]);
                point.Next = node;
                point = node;
                _count++;
            }

        }
        public void InitList()
        {
            this.Head.Next = null;
        }

        public void DestroyList()
        {
            var pre = Head;
            var p = Head.Next;
            while (p != null)
            {
                pre = null;
                pre = p;
                p = pre.Next;
            }
            pre = null;
        }

        public bool ListEmpty()
        {
            return Head.Next == null;
        }
        public int ListLength()
        {
            int result = 0;
            var p = Head;
            while (p.Next != null)
            {
                result++;
                p = p.Next;
            }
            return result;
        }
        public void DispList()
        {
            var p = Head.Next;
            while (p != null)
            {
                Console.WriteLine(p.Next.Data);
                p = p.Next;
            }
        }
        public T GetElem(int index)
        {
            return default(T);
        }
    }
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T t)
        {
            Data = t;
            Next = null;
        }
        public Node()
        {
            Data = default(T);
            Next = null;
        }
    }

}
