using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Queue
{
    /// <summary>
    /// 环形顺序队列
    /// 按照front和rear最大有MaxSize-1个元素
    /// 按照front和count最大有MaxSize个元素
    /// </summary>
    public class CirculateSeqQueue<T>
    {
        private T[] Data;
        private int front;
        private int _count;
        private int _maxSize;
        public CirculateSeqQueue(int maxSize)
        {
            Data = new T[maxSize];
            _maxSize = maxSize;
            front = -1;
            _count = 0;
        }
        public int Count { get { return _count; } }
        public int MaxSize { get { return _maxSize; } }
        public bool IsEmpty { get { return _count == 0; } }
        public T this[int index] { get { return Data[index]; } set { Data[index] = value; } }

        public void InitCirculeQueue()
        {
            front = 0;
            _count = 0;
        }
        public void DestroyQueue()
        {
            Data = null;
            _count = 0;
        }
        public void Enqueue(T t)
        {
            int rear = (front + _count) % _maxSize;
            if (_count == _maxSize)
            {
                Console.WriteLine("队满");
                return;
            }
            else
            {
                rear = (rear + 1) % _maxSize;
                Data[rear] = t;
                _count++;
            }
        }
        public T DelQueue()
        {
            int rear = (front + _count) % _maxSize;
            if (_count == 0)
            {
                Console.WriteLine("队空");
                return default(T);
            }
            else
            {
                front = (front + 1) % _maxSize;
                _count--;
                return Data[front];
            }
        }
    }
}
