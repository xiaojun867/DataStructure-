using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Tree
{
    /// <summary>
    /// 二叉树
    /// </summary>
    public class BinaryTree
    {
        public static BTNode node = new BTNode();
        public void CreateBTreeByPreOrde(BTNode node)
        {
            string input = Console.ReadLine();
            
            if (input == "#")
            {
                node = null;
            }
            else
            {
                node = new BTNode();
                node.Data = input;
                CreateBTreeByPreOrde(node.LBtNode);
                CreateBTreeByPreOrde(node.RBtNode);
            }
        }

        /// <summary>
        /// 前序遍历
        /// </summary>
        public void PreOrderTraverse(BTNode node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.Data);
            PreOrderTraverse(node.LBtNode);
            PreOrderTraverse(node.RBtNode);
        }

        /// <summary>
        /// 中序遍历
        /// </summary>
        /// <param name="node"></param>
        public void MiddleOrder(BTNode node)
        {
            if (node == null)
            {
                return;
            }
            MiddleOrder(node.LBtNode);
            Console.WriteLine(node.Data);
            MiddleOrder(node.RBtNode);
        }

        /// <summary>
        /// 后序遍历
        /// </summary>
        public void PostScript(BTNode node)
        {
            if (node == null)
            {
                return;
            }
            PostScript(node.LBtNode);
            PostScript(node.RBtNode);
            Console.WriteLine(node.Data);
        }

    }

    public class BTNode
    {
        public string Data { get; set; }
        public BTNode LBtNode { get; set; }
        public BTNode RBtNode { get; set; }
    }
}
