using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinerList
{
    public class OrderedList
    {

        public void ListInsert(SequenceList<int> list, int e)
        {
            int i = 0;
            while (list.Data[i] < e && i < list.Length)
            {
                i++;
            }
            for (int j = list.Length; j > i; j--)
            {
                list.Data[j] = list.Data[j - 1];
            }
            list.Data[i] = e;
       
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
            while(a < listA.Length)
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

    }
}
