using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.String
{
    public class SequenceString
    {
        private char[] Data { get; set; }
        public int Length { get; set; }
        public SequenceString(int maxSize)
        {
            Data = new char[maxSize];
        }

        public char this[int index] { get { return Data[index]; } set { Data[index] = value; } }

        public void strAssign(params char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Data[i] = arr[i];
                Length++;
            }
        }
        public void strCopy(string t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Data[i] = t[i];
            }
            Length = t.Length;
        }
        public int StrCompare(string s, string t)
        {
            int result = 0;
            int comLen = s.Length > t.Length ? t.Length : s.Length;
            for (int i = 0; i < comLen; i++)
            {
                if (s[i] > t[i])
                {
                    result = 1;
                    break;
                }
                else if (s[i] < t[i])
                {
                    result = -1;
                    break;
                }
            }
            if (result == 0)
            {
                if (s.Length == t.Length)
                {
                    result = 0;
                }
                else if (s.Length > t.Length)
                {
                    result = 1;
                }
                else if (s.Length < t.Length)
                {
                    result = -1;
                }
            }
            return result;
        }
        /// <summary>
        /// love ove
        /// </summary>
        /// <param name="S"></param>
        /// <param name="T"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public int Index(string s, string t, int pos)
        {
            s = s.Substring(pos);
            bool b = true;
            int result = 0;
            if (s.Length >= t.Length)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    int k = i;
                    for (int j = 0; j < t.Length; j++)
                    {
                        if (s[k] != t[j])
                        {
                            b = false;
                            break;
                        }
                        else
                        {
                            b = true;
                            if (j == 0)
                            {
                                result = k;
                            }
                            k++;

                        }
                    }
                    if (b)
                    {
                        break;
                    }
                }
            }
            return result + pos;
        }
        //ovove ove
        public int Index2(string s, string t)
        {
            int i = 0;
            int j = 0;
            int result = -1;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                {
                    ++i;
                    ++j;
                }
                else
                {
                    i = i - j + 1;
                    j = 0;
                    result = i;
                }
            }
            //if (j >= t.Length)
            //{
            //    return i - t.Length;
            //}
            //else
            //{
            //    return -1;
            //}
            return result;
        }

    }
}
