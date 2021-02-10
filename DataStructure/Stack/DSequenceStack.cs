using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Stack
{
    /// <summary>
    /// 两栈（顺序）共享
    /// </summary>
    public class DSequenceStack<T>
    {
        private T[] Data { get; set; }
        public DSequenceStack(int stackSize)
        {
            Data = new T[stackSize];
        }
        public T this[int index] { get { return Data[index]; } set { Data[index] = value; } }
        private int top1 { get; set; }
        private int top2 { get; set; }
        public void Push(T t, int stackNum)
        {
            if (top1 + 1 == top2)
            {
                Console.WriteLine("栈满");
                return;
            }
            if (stackNum == 1)
            {
                top1++;
                Data[top1] = t;
            }
            else if (stackNum == 2)
            {
                top2--;
                Data[top2] = t;
            }
        }
        public T Pop(int stackNum)
        {
            T t = default(T);
            if (stackNum == 1)
            {
                if (top1 == -1)
                {
                    Console.WriteLine("栈空");
                    return t;
                }
                t = Data[top1];
                top1--;

            }
            else if (stackNum == 2)
            {
                if (top2 == Data.Length)
                {
                    Console.WriteLine("栈空");
                    return t;
                }
                t = Data[top2];
                top2++;
            }
            return t;

        }
    }
}
