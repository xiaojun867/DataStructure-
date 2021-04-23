using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Tree
{
    public class ThrBinaryTree
    {
        /// <summary>
        /// 中序
        /// </summary>
        /// <param name="node"></param>
        public void Middle(ThrBinaryNode node, ThrBinaryNode pre)
        {
            if (node == null)
            {
                return;
            }
            Middle(node.LThrBinaryNode,pre);


        }
    }
    public class ThrBinaryNode
    {
        public string Data { get; set; }
        public ThrBinaryNode LThrBinaryNode { get; set; }
        public ThrBinaryNode RThrBinaryNode { get; set; }
        public int LTag { get; set; }
        public int RTag { get; set; }
    }
}
