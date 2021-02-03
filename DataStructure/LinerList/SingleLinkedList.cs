using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinerList
{
    public class SingleLinkedList<T>
    {
        private int _count;
        private Node<T> Head = new Node<T>();
        public int Count { get { return _count; } }
        public void CreatListF(params T[] arrT)
        {
            for (int i = 0; i < arrT.Length; i++)
            {
                Node<T> node = new Node<T>(arrT[i]);
                node.Next = Head.Next;
                Head.Next = node;
                _count++;
            }

        }
        public void CreatListL(params T[] arrT)
        {
            Node<T> point = Head;
            for (int i = 0; i < arrT.Length; i++)
            {
                Node<T> node = new Node<T>(arrT[i]);
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
                Node<T> nodeNew = new Node<T>(t);
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

        }
        /// <summary>
        /// 逆置
        /// </summary>
        /// <param name="list"></param>
        public void Reverse(SingleLinkedList<T> list)
        {
            
        }
    }
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T t)
        {
            Data = t;
            Next = null;
        }
        public Node()
        {
            Data = default(T);
            Next = null;
        }
    }

}
