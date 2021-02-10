using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Stack
{
    /// <summary>
    /// 顺序栈
    /// </summary>
    public class SequenceStack<T>
    {
        private T[] Data { get; set; }
        private int top { get; set; }


        public T this[int index] { get { return Data[index]; } set { Data[index] = value; } }

        public SequenceStack(int stackSize)
        {
            Data = new T[stackSize];
            top = -1;
        }
        public int StackSize { get; set; }

        public void Push(T t)
        {
            if (top == StackSize - 1)
            {
                Console.WriteLine("栈满，无法进栈");
                return;
            }
            top++;
            Data[top] = t;
        }

        public T Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("栈空，没有元素可以出栈");
                return default(T);
            }
            T t = Data[top];
            top--;
            return t;
        }
    }
}
