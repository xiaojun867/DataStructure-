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

        public SequenceStack(int maxSize)
        {
            Data = new T[maxSize];
            _maxSize = maxSize;
            top = -1;
        }
        private int _length;
        private int _maxSize;
        public int Length { get { return _length; } }
        public int MaxSize { get { return _maxSize; } }

        public bool IsEmpty { get { return top == -1; } }

        public void InitStack()
        {
            top = -1;
            _length = 0;
            
        }
        public void DestroyStack()
        {
            top = -1;
            this.Data = null;
            _length = 0;
            _maxSize = 0;
        }
        public T GetTop()
        {
            T t = default(T);
            if (top == -1)
            {
                Console.WriteLine("栈空");
                return t;
            }
            t = Data[top];
            return t;
        }
        public void Push(T t)
        {
            if (top == _maxSize - 1)
            {
                Console.WriteLine("栈满，无法进栈");
                return;
            }
            top++;
            Data[top] = t;
            _length++;
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
            _length--;
            return t;
        }
    }

    public class SeqStackApp
    {
        public bool IsSymmetry(string str)
        {
            SequenceStack<char> sequenceStack = new SequenceStack<char>(10);
            char[] s = str.ToCharArray();
            if (s.Length > sequenceStack.MaxSize)
            {
                Console.WriteLine("超出数组长度");
                return false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                sequenceStack.Push(s[i]);
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != sequenceStack.Pop())
                {
                    Console.WriteLine("非对称字符串");
                    sequenceStack.DestroyStack();
                    return false;
                }
            }
            Console.WriteLine("是对称字符串");
            sequenceStack.DestroyStack();
            return true;
        }
    }
}
