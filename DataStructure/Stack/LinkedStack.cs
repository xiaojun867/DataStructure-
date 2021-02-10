using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Stack
{
    /// <summary>
    /// 链栈
    /// </summary>
    public class LinkedStack<T>
    {
        public StackNode<T> Top { get; set; }
        public int Count { get; set; }
        public bool IsEmpty { get { return Top == null; }  }
        public void Push(T t)
        {
            var s = new StackNode<T>();
            s.Data = t;
            s.Next = Top;
            Top = s;
            Count++;
        }
        public T Pop()
        {
            T t = default(T);
            if (IsEmpty)
            {
                Console.WriteLine("栈空");
                return t;
            }
            var p = Top;
            t = Top.Data;
            Top = Top.Next;
            p = null;
            Count--;
            return t;
        }
    }

    public class StackNode<T>
    {
        public T Data { get; set; }
        public StackNode<T> Next { get; set; }
    }
}
