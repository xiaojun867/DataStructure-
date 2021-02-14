using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Queue
{
    /// <summary>
    /// 顺序队列
    /// </summary>
    public class SequenceQueue<T>
    {
        private T[] Data;
        private int front;//队首
        private int rear;//队尾
        private int _length { get; set; }
        private int _maxSize { get; set; }
        public SequenceQueue(int maxSize)
        {
            Data = new T[maxSize];
            _maxSize = maxSize;
            front = rear = -1;
        }
        public T this[int index] { get { return Data[index]; } set { Data[index] = value; } }
        public int MaxSize { get { return _maxSize; } }
        public int Length { get { return _length; } }
        public bool IsEmpty { get { return rear == front; } }

        public void InitQueue()
        {
            front = rear = -1;
            _length = 0;
        }
        public void DestroyQueue()
        {
            Data = null;
            _length = 0;
        }
        public void Enqueue(T t)
        {
            if (rear == _maxSize - 1)
            {
                Console.WriteLine("队满");
                return;
            }
            else
            {
                rear++;
                Data[rear] = t;
                _length++;
            }
        }
        public T DelQueue()
        {
            if (rear == front)
            {
                Console.WriteLine("队空");
                return default(T);
            }
            else
            {
                front++;
                _length--;
                return Data[front];
                
            }
        }
    }
}
