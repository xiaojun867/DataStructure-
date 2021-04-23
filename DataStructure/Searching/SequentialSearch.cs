using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Searching
{
    public class SequentialSearch
    {
        
        /// <summary>
        /// 顺序表顺序查找
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public int SeqSearch(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// 有序表-折半查找
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public int BinarySearch(int[] arr, int key)
        {
            int mid = 0;
            int low = 0; ;
            int high = arr.Length - 1;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (key < arr[mid])
                {
                    high = mid - 1;
                }
                else if (key > arr[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }

        /// <summary>
        /// 有序表-折半递归查找
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="key"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public int BinarySearch_Rec(int[] arr, int key, int low, int high)
        {
            int mid = 0;
            int result = 0;
            if (low < high)
            {
                result = -1;
            }
            else
            {
                mid = (low + high) / 2;
                if (arr[mid] == key)
                {
                    result = mid;
                }
                else if (arr[mid] < key)
                {
                    low = mid + 1;
                    result = BinarySearch_Rec(arr, key, low, high);
                }
                else if (key < arr[mid])
                {
                    high = mid - 1;
                    result = BinarySearch_Rec(arr, key, low, high);
                }
            }
            return result;
        }





    }
}
