using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.String
{
    public class LinkedString
    {
        public LinkedStringNode Head = new LinkedStringNode();
        public void CreateTable(params char[] arr)
        {
            var r = Head;
            for (int i = 0; i < arr.Length; i++)
            {
                LinkedStringNode node = new LinkedStringNode();
                node.Data = arr[i];
                r.Next = node;
                r = node;
            }
            r.Next = null;
        }
        public void Replace()
        {
            var p = Head;
            while (p.Next != null)
            {
                if (p.Data == 'a' && p.Next.Data == 'b')
                {
                    p.Data = 'x';
                    p.Next.Data = 'z';
                    LinkedStringNode y = new LinkedStringNode();
                    y.Data = 'y';
                    y.Next = p.Next;
                    p.Next = y;
                    break;
                }
                p = p.Next;
            }
        }
    }
    public class LinkedStringNode
    {
        public char Data { get; set; }
        public LinkedStringNode Next { get; set; }
    }
}
