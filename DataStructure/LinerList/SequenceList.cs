using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinerList
{
    /// <summary>
    /// 顺序表
    /// </summary>
    public class SequenceList<T>
    {
        private T[] Data { get; set; }
        private int Length { get; set; }
        public SequenceList(int maxSize, params T[] t)
        {
            Data = new T[maxSize];
            CreateList(t);
        }
        public void CreateList(params T[] t)
        {
            if (t.Length > Data.Length)
            {
                Console.WriteLine("您的初始化数据已超过线性表可存储范围！");
                return;
            }
            for (int i = 0; i < t.Length; i++)
            {
                Data[i] = t[i];
            }
            this.Length = t.Length;
        }

        public void InitList()
        {
            this.Length = 0;
        }
        public void DestroyList()
        {
            this.Length = 0;
            this.Data = null;
        }
        public bool ListEmpty()
        {
            return this.Length == 0;
        }
        public int ListLength()
        {
            return this.Length;
        }
        public void DispList()
        {
            if (this.ListEmpty()) return;
            for (int i = 0; i < this.Length; i++)
            {
                Console.WriteLine(Data[i]);
            }
        }

        public T GetElem(int index)
        {
            if (index < 1 || index > this.Length)
            {
                Console.WriteLine("index超出元素范围");
                return default(T);
            }
            else if (this.Length == 0)
            {
                Console.WriteLine("线性表数据为空");
                return default(T);
            }
            else
            {
                return Data[index - 1];
            }

        }
        public (bool, int) LocateElem(T t)
        {
            #region for
            //for (int i = 0; i < this.Length; i++)
            //{
            //    if (Data[i] == t)
            //    {
            //        return (true,i+1);
            //    }
            //}
            //return (false,0);
            #endregion
            #region While
            //int i = 0;
            //while (i<this.Length&&Data[i]!=t)
            //{
            //    i++;
            //}
            //if (i >= this.Length)
            //{
            //    return (false,0);
            //}
            //else
            //{
            //    return (true,i+1);
            //}
            #endregion
            return (false, 0);
        }

        public void ListInsert(int index, T t)
        {
            if (this.Length == Data.Length)
            {
                Console.WriteLine("线性表已满");
                return;
            }
            if (index < 1 || index > this.Length + 1)
            {
                Console.WriteLine("index超出数组范围");
                return;
            }
            else
            {
                for (int i = this.Length; i > index - 1; i--)
                {
                    Data[i] = Data[i - 1];
                }
                Data[index - 1] = t;
                this.Length++;
            }
        }

        public T ListDelete(int index)
        {
            if (index < 1 || index > this.Length)
            {
                Console.WriteLine("index超出数组范围");
                return default(T);
            }
            else
            {
                T t = Data[index - 1];
                for (int i = index - 1; i < this.Length - 1; i++)
                {
                    Data[i] = Data[i + 1];
                }
                this.Length--;
                return t;
            }
        }

        public void DelElem(T t)
        {
            int k = 0;
            for (int i = 0; i < this.Length; i++)
            {
                //if (Data[i] != t)
                //{
                //    Data[k] = Data[i];
                //    k++;
                //}
            }
            this.Length = k;
        }
    }
}
