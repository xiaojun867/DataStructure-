using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinerList
{
    public class SingleLinkedList<T>
    {
        public Node<T> Head { get; set; }

        public void CreatListF(params T[] arrT)
        {
            Head = new Node<T>();
            for (int i = 0; i < arrT.Length; i++)
            {
                Node<T> node = new Node<T>(arrT[i]);
                node.Next = Head.Next;
                Head.Next = node;
            }
        }
        public void CreatListL(params T[] arrT)
        {
            Head = new Node<T>();
            Node<T> point = Head;
            for (int i = 0; i < arrT.Length; i++)
            {
                Node<T> node = new Node<T>(arrT[i]);
                node.Next = node;
                point = node;
               
            }

        }
      
    }
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T>? Next { get; set; }
        public Node(T t)
        {
            Data = t;
            Next = null;
        }
        public Node()
        {
            Data= default(T);
            Next = null;
        }
    }

}
