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
        public BTNode Create(string str)
        {
            str = "A(B(D(,G)),C(E,F))";
            char[] arrChar = str.ToCharArray();
            BTNode node = new BTNode();
            for (int i = 0; i < arrChar.Length; i++)
            {


            }
        }
    }
    public class BTNode
    {
        public string Data { get; set; }
        public BTNode LBtNode { get; set; }
        public BTNode RBtNode { get; set; }
    }
}
