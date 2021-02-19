using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinerList
{
    /// <summary>
    /// 单链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleLinkedList<T>
    {
        public int _count;
        public LinkedListNode<T> Head = new LinkedListNode<T>();
        public int Count { get { return _count; } }
        public void CreatListF(params T[] arrT)
        {
            for (int i = 0; i < arrT.Length; i++)
            {
                LinkedListNode<T> node = new LinkedListNode<T>(arrT[i]);
                node.Next = Head.Next;
                Head.Next = node;
                _count++;
            }

        }
        public void CreatListL(params T[] arrT)
        {
            LinkedListNode<T> point = Head;
            for (int i = 0; i < arrT.Length; i++)
            {
                LinkedListNode<T> node = new LinkedListNode<T>(arrT[i]);
                point.Next = node;
                point = node;
                _count++;
            }

        }
        public void InitList()
        {
            this.Head.Next = null;
        }

        public void DestroyList()
        {
            var pre = Head;
            var p = Head.Next;
            while (p != null)
            {
                pre = null;
                pre = p;
                p = pre.Next;
            }
            pre = null;
        }

        public bool ListEmpty()
        {
            return Head.Next == null;
        }
        public int ListLength()
        {
            int result = 0;
            var p = Head;
            while (p.Next != null)
            {
                result++;
                p = p.Next;
            }
            return result;
        }
        public void DispList()
        {
            var p = Head.Next;
            while (p != null)
            {
                Console.WriteLine(p.Data);
                p = p.Next;
            }
        }
        public T GetElem(int index)
        {
            int i = 0;
            var p = Head;
            while (i < index && p != null)
            {
                i++;
                p = p.Next;
            }
            if (p == null)
            {
                return default(T);
            }
            return p.Data;
        }
        public int LocateElem(T t)
        {
            int i = 0;
            var p = Head;
            #region me
            while (p != null)
            {
                i++;
                p = p.Next;
                if (object.Equals(p.Data, t))
                {
                    break;
                }
            }
            #endregion
            #region teacher
            //while (p != null &&object.Equals(p.Data,t))
            //{
            //    p = p.Next;
            //    i++;
            //}
            #endregion

            if (p == null)
            {
                return 0;
            }
            return i;
        }
        public void ListInsert(int index, T t)
        {
            int i = 0;
            var p = Head;
            while (i < index - 1 && p != null)
            {
                p = p.Next;
                i++;
            }
            if (p == null)
            {
                return;
            }
            else
            {
                LinkedListNode<T> nodeNew = new LinkedListNode<T>(t);
                nodeNew.Next = p.Next;
                p.Next = nodeNew;
            }
        }
        public void ListDelete(int index)
        {
            int i = 0;
            var p = Head;
            while (i < index - 1 && p != null)
            {
                i++;
                p = p.Next;
            }
            if (p == null)
            {
                return;
            }
            else
            {
                var q = p.Next;
                if (q == null)
                {
                    return;
                }
                p.Next = q.Next;
                q = null;
            }
        }

        /// <summary>
        /// 获取单链表中最大的节点
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int GetMaxNode(SingleLinkedList<int> list)
        {
            var maxNode = list.Head.Next;
            var p = list.Head.Next;
            while (p != null)
            {
                if (maxNode.Data < p.Data)
                {
                    maxNode = p;
                }
                p = p.Next;
            }
            return maxNode.Data;
        }
        /// <summary>
        /// 删除单链表中最大的节点
        /// </summary>
        public void DelMaxNode(SingleLinkedList<int> list)
        {
            var pre = list.Head;
            var p = list.Head.Next;
            var maxNodePre = pre;
            var maxNode = p;
            while (p != null)
            {
                if (maxNode.Data < p.Data)
                {
                    maxNode = p;
                    maxNodePre = pre;
                }
                pre = p;
                p = p.Next;
            }
            maxNodePre.Next = maxNode.Next;
            maxNode = null;
        }

        /// <summary>
        /// 递增排序
        /// </summary>
        /// <param name="list"></param>
        public void Sort(SingleLinkedList<int> list)
        {
            var p = list.Head.Next.Next;
            var pre = list.Head.Next;
            list.Head.Next.Next = null;
            var q = new LinkedListNode<int>();
            while (p != null)
            {
                q = p.Next;
                pre = list.Head;
                while (pre.Next != null && pre.Next.Data < p.Data)
                {
                    pre = pre.Next;
                }
                p.Next = pre.Next;
                pre.Next = p;
                p = q;
            }

        }
        /// <summary>
        /// 逆置
        /// </summary>
        /// <param name="list"></param>
        public void Reverse(SingleLinkedList<T> list)
        {
            var p = list.Head.Next;
            var pre = list.Head;
            list.Head.Next = null;
            var q = new LinkedListNode<T>();
            while (p != null)
            {
                q = p.Next;
                p.Next = pre.Next;
                pre.Next = p;
                p = q;
            }
        }


        /// <summary>
        /// 重组
        /// </summary>
        /// <param name="list"></param>
        public void Split(SingleLinkedList<T> list)
        {
            var p = list.Head.Next;
            var list1 = list.Head;
            var point = list1;
            var list2 = new LinkedListNode<T>();

            while (p != null)
            {
                point.Next = p;
                point = p;

                p = p.Next;
                var q = p.Next;

                list2.Next = p;

                p = q;
            }
            point.Next = null;
            while (list1 != null)
            {
                Console.WriteLine($"List1:{list1.Data}");
                list1 = list1.Next;
            }
            while (list2 != null)
            {
                Console.WriteLine($"List2:{list2.Data}");
                list2 = list2.Next;
            }

        }

        /// <summary>
        /// 荷兰国旗问题
        /// </summary>
        /// <param name="list"></param>
        public void Move(SingleLinkedList<int> list)
        {
            var p = list.Head.Next;
            #region 尾插法
            //var list1 = list.Head;
            //var r1 = list1;

            //Node<int> list2 = null;
            //var r2 = list2;
            //Node<int> list3 = null;
            //var r3 = list3;


            //while (p != null)
            //{
            //    var q = p.Next;
            //    if (p.Data == 0)
            //    {
            //        r1.Next = p;
            //        r1 = p;
            //    }
            //    else if (p.Data == 1)
            //    {
            //        if (list2 == null)
            //        {
            //            list2 = p;
            //            r2 = p;
            //        }
            //        else
            //        {
            //            r2.Next = p;
            //            r2 = p;
            //        }
            //    }
            //    else
            //    {
            //        if (list3 == null)
            //        {
            //            list3 = p;
            //            r3 = p;
            //        }
            //        else
            //        {
            //            r3.Next = p;
            //            r3 = p;
            //        }
            //    }
            //    p = q;
            //}
            //r1.Next = r2.Next = r3.Next = null;
            //r1.Next = list2;
            //r2.Next = list3;
            #endregion
        }
    }
    public class LinkedListNode<T>
    {
        public T Data { get; set; }
        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode(T t)
        {
            Data = t;
            Next = null;
        }
        public LinkedListNode()
        {
            Data = default(T);
            Next = null;
        }
    }

}
