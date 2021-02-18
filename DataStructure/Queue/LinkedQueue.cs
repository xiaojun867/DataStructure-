using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Queue
{
    /// <summary>
    /// 链队列
    /// </summary>
    public class LinkedQueue<T>
    {
        private LinkedQueueNode<T> front;
        private LinkedQueueNode<T> rear;
        private int _count;
        public bool IsEmpty { get { return front == null && rear == null; } }
        public int Count { get { return _count; } }

        public void InitQueue()
        {
            front = null;
            rear = null;
        }
        public void DestroyQueue()
        {
            var p = front;
            if (p != null)
            {
                var r = p.Next;
                while (r != null)
                {
                    p = null;
                    p = r;
                    r = p.Next;
                }
            }
            p = null;
        }
        public void Enqueue(T t)
        {
            var s = new LinkedQueueNode<T>();
            s.Data = t;
            s.Next = null;
            if (IsEmpty)
            {
                front = s;
                rear = s;
            }
            else
            {
                rear.Next = s;
                rear = s;
            }
            _count++;
        }
        public T DelQueue()
        {
            T t = default(T);
            if (rear == null && front == null)
            {
                Console.WriteLine("队空");
                return t;
            }
            var q = front;
            if (front == rear)
            {
                front = rear = null;
            }
            else
            {
                front = front.Next;
            }
            t = q.Data;
            q = null;
            _count--;
            return t;
        }
    }

    public class LinkedQueueNode<T>
    {
        public T Data { get; set; }
        public LinkedQueueNode<T> Next { get; set; }
    }
}
