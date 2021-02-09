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
        public T[] Data { get; set; }
        private int _length;
        public int Length { get; set; }

        public T this[int index] { get { return Data[index]; } set { Data[index] = value; } }
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
            this._length = 0;
        }
        public void DestroyList()
        {
            this._length = 0;
            this.Data = null;
        }
        public bool ListEmpty()
        {
            return this._length == 0;
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
            for (int i = 0; i < this.Length; i++)
            {
                if (object.Equals(Data[i], t))
                {
                    return (true, i + 1);
                }
            }
            #endregion
            #region While
            //int i = 0;
            //while (i < this.Length &&object.Equals(Data[i], t))
            //{
            //    i++;
            //}
            //if (i >= this.Length)
            //{
            //    return (false, 0);
            //}
            //else
            //{
            //    return (true, i + 1);
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
                this._length++;
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
                this._length--;
                return t;
            }
        }

        public void DelElem1(T t)
        {
            int k = 0;
            for (int i = 0; i < this.Length; i++)
            {
                if (object.Equals(Data[i], t))
                {
                    Data[k] = Data[i];
                    k++;
                }
            }
            this._length = k;
        }
        public void DelElem2(T t)
        {
            int k = 0;
            for (int i = 0; i < this.Length; i++)
            {
                if (object.Equals(Data[i], t))
                {
                    k++;
                }
                else
                {
                    Data[i - k] = Data[i];
                }
            }
            this._length -= k;
        }
        public void Move1(params int[] arrData)
        {
            int pivot = arrData[0];
            int k = arrData.Length - 1;
            int temp = 0;
            for (int i = 0; i <= k; i++)
            {
                if (arrData[i] > pivot)
                {
                    for (int j = k; j >= i; j--)
                    {
                        k--;
                        if (arrData[j] <= pivot)
                        {
                            temp = arrData[i];
                            arrData[i] = arrData[j];
                            arrData[j] = temp;
                            break;
                        }
                    }
                }
            }
            arrData[0] = arrData[k];
            arrData[k] = pivot;
            for (int i = 0; i < arrData.Length; i++)
            {
                Console.Write(arrData[i]);
            }

        }
        public void Move2(params int[] arrData)
        {
            int pivot = arrData[0];
            int i = 0;
            int j = arrData.Length - 1;
            while (i < j)
            {
                for (; j > i; j--)
                {
                    if (arrData[j] <= pivot)
                    {
                        arrData[i] = arrData[j];
                        break;
                    }
                }
                for (; i < j; i++)
                {
                    if (arrData[i] > pivot)
                    {
                        arrData[j] = arrData[i];
                        break;
                    }
                }
            }
            if (i == j)
            {
                arrData[i] = pivot;
            }

            for (int x = 0; x < arrData.Length; x++)
            {
                Console.Write(arrData[x]);
            }
        }
        /// <summary>
        /// 荷兰国旗问题
        /// </summary>
        /// <param name="arrData"></param>
        public void Move3(params int[] arrData)
        {
            int i = -1;
            int k = arrData.Length;
            int j = 0;
            while (j < k)
            {
                if (arrData[j] == 0)
                {
                    i++;
                    swap(ref arrData[i], ref arrData[j]);
                    j++;
                }
                else if (arrData[j] == 2)
                {
                    k--;
                    swap(ref arrData[k], ref arrData[j]);
                }
                else
                {
                    j++;
                }
            }

            for (int x = 0; x < arrData.Length; x++)
            {
                Console.WriteLine(arrData[x]);
            }
        }

        public void swap(ref int a, ref int b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
