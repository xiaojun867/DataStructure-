using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinerList
{
    /// <summary>
    /// 有序表
    /// </summary>
    public class OrderedList
    {
        public void ListInsert(SequenceList<int> list, int e)
        {
            int i = 0;
            while (list[i] < e && i < list.Length)
            {
                i++;
            }
            for (int j = list.Length; j > i; j--)
            {
                list[j] = list[j - 1];
            }
            list[i] = e;
        }
        public void ListInsert(SingleLinkedList<int> list, int e)
        {
            var pre = list.Head;
            while (pre.Next != null && pre.Next.Data < e)
            {
                pre = pre.Next;
            }

            var p = new Node<int>(e);
            p.Next = pre.Next;
            pre.Next = p;
        }
        /// <summary>
        /// 二路归并
        /// </summary>
        /// <param name="listA"></param>
        /// <param name="listB"></param>
        /// <param name="listC"></param 
        public void UnionList(SequenceList<int> listA, SequenceList<int> listB, SequenceList<int> listC)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            while (a < listA.Length && b < listB.Length)
            {
                if (listA[a] < listB[b])
                {
                    listC[c] = listA[a];
                    a++;
                    c++;
                }
                else
                {
                    listC[c] = listB[b];
                    b++;
                    c++;
                }
            }
            while (a < listA.Length)
            {
                listC[c] = listA[a];
                a++;
                c++;
            }
            while (b < listB.Length)
            {
                listC[c] = listB[b];
                b++;
                c++;
            }

        }
        public void UnionList(SingleLinkedList<int> listA, SingleLinkedList<int> listB, SingleLinkedList<int> listC)
        {
            var pA = listA.Head.Next;
            var pB = listB.Head.Next;
            var pC = listC.Head;
            var r = pC;
            while (pA != null && pB != null)
            {
                if (pA.Data < pB.Data)
                {
                    var q = pA.Next;

                    pA.Next = r.Next;
                    r.Next = pA;

                    r = pA;
                    pA = q;
                }
                else
                {
                    var q = pB.Next;

                    pB.Next = r.Next;
                    r.Next = pB;

                    r = pB;
                    pB = q;
                }
            }
            while (pA != null)
            {
                var q = pA.Next;
                pA.Next = r.Next;
                r.Next = pA;
                r = pA;
                pA = q;
            }
            while (pB != null)
            {
                var q = pB.Next;
                pB.Next = r.Next;
                r.Next = pB;
                r = pB;
                pB = q;
            }
        }
        public int M_Search(SingleLinkedList<int> listA, SingleLinkedList<int> listB)
        {
            int n = (listA.ListLength() + listB.ListLength()) / 2;
            var pA = listA.Head.Next;
            var pB = listB.Head.Next;
            int k = 0;
            int result = 0;
            while (k < n)
            {
                while (pA != null && pB != null)
                {
                    k++;
                    if (pA.Data < pB.Data)
                    {
                        if (k == n)
                        {
                            result = pA.Data;
                            return result;
                        }
                        pA = pA.Next;

                    }
                    else
                    {
                        if (k == n)
                        {
                            result = pB.Data;
                            return result;
                        }
                        pB = pB.Next;
                    }
                }
                while (pA != null)
                {
                    k++;
                    if (k == n)
                    {
                        result = pA.Data;
                        return result;
                    }
                    pA = pA.Next;
                }
                while (pB != null)
                {
                    k++;
                    if (k == n)
                    {
                        result = pB.Data;
                        return result;
                    }
                    pB = pB.Next;
                }
            }



            return result;
        }
        public int M_Search(SequenceList<int> listA, SequenceList<int> listB)
        {
            int n = (listA.Length + listB.Length) / 2;
            int k = 0;
            int a = 0;
            int b = 0;
            while (a < listA.Length & b < listB.Length)
            {
                k++;
                if (listA[a] < listB[b])
                {
                    if (k == n)
                    {
                        return listA[a];
                    }
                    a++;
                }
                else
                {
                    if (k == n)
                    {
                        return listB[b];
                    }
                    b++;
                }
            }
            while (a < listA.Length)
            {
                k++;
                if (k == n)
                {
                    return listA[a];
                }
                a++;
            }
            while (b < listB.Length)
            {
                k++;
                if (k == n)
                {
                    return listB[b];
                }
                b++;
            }
            return 0;
        }
        public void DelRepetData(SequenceList<int> list)
        {
            int k = 1;
            for (int i = 1; i < list.Length; i++)
            {
                if (list[i] != list[i - 1])
                {
                    list[k] = list[i];
                    k++;
                }
            }
            list.Length = k;
        }
        public void InterSect(SingleLinkedList<int> listA, SingleLinkedList<int> listB, SingleLinkedList<int> listC)
        {
            var pA = listA.Head.Next;
            var pB = listB.Head.Next;
            var r = listC.Head;
            while (pA != null && pB != null)
            {
                if (pA.Data < pB.Data)
                {
                    pA = pA.Next;
                }
                if (pA.Data > pB.Data)
                {
                    pB = pB.Next;
                }
                if (pA.Data == pB.Data)
                {
                    var s = new Node<int>();
                    s.Data = pA.Data;

                 
                    r.Next = s;
                    r = s;

                    pA = pA.Next;
                    pB = pB.Next;
                }
            }
            r.Next = null;
        }
    }
}
