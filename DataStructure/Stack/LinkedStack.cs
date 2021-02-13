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
        public LinkedStackNode<T> Top { get; set; }
        public int Count { get; set; }
        public bool IsEmpty { get { return Top == null; } }
        public bool IsEmpty2 { get { return Head.Next == null; } }

        public LinkedStackNode<T> Head = new LinkedStackNode<T>();

        public void InitLinkedStack()
        {
            Head.Data = default(T);
            Head.Next = null;
        }
        public void DestroyStack()
        {
            var p = Head;
            var q = Head.Next;
            while (q != null)
            {
                p = null;
                p = q;
                q = q.Next;
            }
            p = null;
        }
        public void Push(T t)
        {
            var s = new LinkedStackNode<T>();
            s.Data = t;
            s.Next = Top;
            Top = s;
            Count++;
        }
        public void Push2(T t)
        {
            var s = new LinkedStackNode<T>();
            s.Data = t;
            s.Next = Head.Next;
            Head.Next = s;
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
        public T Pop2()
        {
            T t = default(T);
            if (IsEmpty2)
            {
                Console.WriteLine("栈空");
                return t;
            }
            var q = Head.Next;
            t = q.Data;
            Head.Next = q.Next;
            q = null;
            Count--;
            return t;
        }
        public T GetTop()
        {
            T t = default(T);
            if (IsEmpty2)
            {
                Console.WriteLine("栈空");
                return t;
            }
            t = Head.Next.Data;
            return t;
        }
    }

    public class LinkedStackNode<T>
    {
        public T Data { get; set; }
        public LinkedStackNode<T> Next { get; set; }
    }

    public class LinkedStackApp
    {
        public bool IsSymmetry(string str)
        {
            LinkedStack<char> linkedStack = new LinkedStack<char>();
            linkedStack.InitLinkedStack();
            char[] s = str.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
               
                if (i + 1 < s.Length)
                {
                    if (linkedStack.GetTop()=='(' && linkedStack.GetTop() != s[i + 1])
                    {
                        linkedStack.Pop2();
                        i++;
                    }
                    else
                    {
                        linkedStack.Push2(s[i]);
                    }
                }

            }

            if (!linkedStack.IsEmpty2)
            {
                Console.WriteLine("不对称");
                return false;
            }
            Console.WriteLine("对称");
            return true;
        }
        public bool IsSymmetry2(string str)
        {
            LinkedStack<char> linkedStack = new LinkedStack<char>();
            linkedStack.InitLinkedStack();
            char[] s = str.ToCharArray();
            bool symmetry = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    linkedStack.Push2(s[i]);
                }
                else if (s[i] == ')')
                {
                    if (!linkedStack.IsEmpty2)
                    {
                        if (linkedStack.GetTop() != '(')
                        {
                            symmetry = false;
                        }
                        else
                        {
                            linkedStack.Pop2();
                        }
                    }
                    else
                    {
                        symmetry = false;
                    }
                    
                }
            }
            if (!linkedStack.IsEmpty2)
            {
                symmetry = false;
            }
            linkedStack.DestroyStack();
            return symmetry;
        }
    }
}
