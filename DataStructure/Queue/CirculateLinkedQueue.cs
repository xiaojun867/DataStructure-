using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Queue
{
    public class CirculateLinkedQueue<T>
    {
        private LinkedQueueNode<T> rear;
        private int _count;
        public int Count { get { return _count; } }
        public bool IsEmpty { get { return rear == null; } }
        public void InitQueue()
        {
            rear = null;
            _count = 0;
        }
        public void Enqueue(T t)
        {
            var s = new LinkedQueueNode<T>();
            s.Data = t;
            if (rear == null)
            {
                s.Next = s;
                rear = s;
            }
            else
            {
                s.Next = rear.Next;
                rear.Next = s;
                rear = s;
            }
            _count++;

        }
        public T DelQueue()
        {
            T t = default(T);
            if (rear == null)
            {
                return t;
            }
            else if (rear.Next == rear)
            {
                t = rear.Data;
                rear = null;
                _count--;
            }
            else
            {
                var q = rear.Next;
                t = q.Data;
                rear.Next = q.Next;
                q = null;
                _count--;
            }
            return t;
        }
    }

}
