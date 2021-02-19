using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinerList
{
    public class LinerListApp<T>
    {
        public HNode<T> Head { get; set; }
        public void CreateTable(int row, int column)
        {

            Head = new HNode<T>();
            Head.Next = null;
            Head.Row = row;
            Head.Column = column;

            DNode<T> r = new DNode<T>();
            for (int i = 0; i < Head.Row; i++)
            {
                Console.WriteLine($"请输入第{i + 1}行数据");
                DNode<T> node = new DNode<T>(Head.Column);

                for (int j = 0; j < Head.Column; j++)
                {
                    node.Data[j] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                }
                if (Head.Next == null)
                {
                    Head.Next = node;
                }
                else
                {
                    r.Next = node;
                }
                r = node;
            }
            r.Next = null;
        }

        public void DestroyTable()
        {
            var pre = Head.Next;
            var p = pre.Next;
            while (p != null)
            {
                pre = null;
                pre = p;
                p = p.Next;
            }
            pre = null;
            Head = null;
        }

        public void DispTable()
        {
            var p = Head.Next;
            while (p != null)
            {
                for (int i = 0; i < p.Data.Length; i++)
                {
                    Console.Write(p.Data[i]);
                }
                Console.WriteLine();
                p = p.Next;
            }
        }

        public void LinkTable(HNode<T> h1, HNode<T> h2, int m, int n)
        {
            Head = new HNode<T>();
            Head.Next = null;

            Head.Column = h1.Column + h2.Column;

            var p1 = h1.Next;
            
            var r = new DNode<T>();


            while (p1 != null)
            {
                var p2 = h2.Next;
                while (p2 != null)
                {
                    if (object.Equals(p1.Data[m - 1], p2.Data[n - 1 ]))
                    {
                        Head.Row++;
                        var node = new DNode<T>(Head.Column);
                        for (int i = 0; i < p1.Data.Length; i++)
                        {
                            node.Data[i] = p1.Data[i];
                        }
                        for (int j = 0; j < p2.Data.Length; j++)
                        {
                            node.Data[h1.Column + j] = p2.Data[j];
                        }
                        if (Head.Next == null)
                        {
                            Head.Next = node;
                        }
                        else
                        {
                            r.Next = node;
                        }
                        r = node;
                    }
                    p2 = p2.Next;
                }
                p1 = p1.Next;
            }
            r.Next = null;
        }
    }
    public class DNode<T>
    {
        public T[] Data { get; set; }
        public DNode<T> Next { get; set; }
        public DNode(int colnum)
        {
            Data = new T[colnum];
        }
        public DNode()
        { }
    }
    public class HNode<T>
    {
        public int Column { get; set; }
        public int Row { get; set; }
        public DNode<T> Next { get; set; }
    }
}
