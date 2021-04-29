using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Searching
{
    public class TreeSearch
    {
        #region 二叉排序树
        public bool SearchBST(BiTree T, BiTree p, BiTree f, int key)
        {
            if (T == null)
            {
                p = T;
                return false;
            }
            else if (key == T.Data)
            {
                p = T;
                return true;
            }
            else if (key < T.Data)
            {
                return SearchBST(T.LBiTree, p, T, key);
            }
            else
            {
                return SearchBST(T.RBiTree, p, T, key);
            }
        }

        public bool InsertBST(BiTree T, int key)
        {
            BiTree p = null;
            if (!SearchBST(T, p, null, key))
            {
                BiTree node = new BiTree();
                node.Data = key;
                node.LBiTree = node.RBiTree = null;
                if (p == null)
                {
                    T = node;
                }
                else if (key < p.Data)
                {
                    p.LBiTree = node;
                }
                else if (key > p.Data)
                {
                    p.RBiTree = node;
                }
                return true;
            }
            else
            {
                return false;
            }


        }


        public bool DeleteBST(BiTree T, int key)
        {
            if (T == null)
            {
                return false;
            }
            else
            {
                if (key == T.Data)
                {
                    return Delete(T);

                }
                else if (key < T.Data)
                {
                    return DeleteBST(T.LBiTree, key);
                }
                else
                {
                    return DeleteBST(T.RBiTree, key);
                }

            }
        }
        public bool Delete(BiTree p)
        {
            BiTree q, s = null;
            if (p.RBiTree == null)
            {
                q = p;
                p = p.LBiTree;
                q = null;
            }
            else if (p.LBiTree == null)
            {
                q = p;
                p = p.RBiTree;
                q = null;
            }
            else
            {
                q = p;
                s = p.LBiTree;
                while (s.RBiTree != null)
                {
                    q = s;
                    s = s.RBiTree;
                }
                p.Data = s.Data;
                if (q != p)
                {
                    q.RBiTree = s.LBiTree;
                }
                else
                {
                    q.LBiTree = s.LBiTree;
                }
                s = null;
            }
            return true;
        }
        #endregion


        #region 平衡二叉树 AVL??????????????
        public void R_Rotate(BalanceBitree P)
        {
            BalanceBitree L = P.LBitree;
            P.LBitree = L.RBitree;
            L.RBitree = P;
            P = L;
        }
        public void L_Rotate(BalanceBitree P)
        {
            BalanceBitree L = P.RBitree;
            P.RBitree = L.LBitree;
            L.LBitree = P;
            P = L;
        }




        #endregion

        #region 多路查找树
        //2-3树
        //2-3-4树
        //B树
        //B+树
        #endregion
    }

    public class BalanceBitree
    {
        public int Data { get; set; }
        public int Bf { get; set; }
        public BalanceBitree LBitree { get; set; }
        public BalanceBitree RBitree { get; set; }
    }
    public class BiTree
    {
        public int Data { get; set; }
        public BiTree LBiTree { get; set; }
        public BiTree RBiTree { get; set; }
    }
}
