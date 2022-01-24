using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_组合模式.Example_1
{
    public class TreeNode
    {
        public int NodeId { get; set; }
        public string NodeName { get; set; }

        public List<TreeNode> Children { get; set; }

        public TreeNode() 
        { 
            Children = new List<TreeNode>(); 
        }

        //public TreeNode(string nodeName) : this() => NodeName = nodeName;

        public TreeNode(int nodeId, string nodeName) : this() => SetTreeNode(nodeId, nodeName);


        public void SetTreeNode(int nodeId, string nodeName)
        {
            NodeId = nodeId;
            NodeName = nodeName;
        }

        public void AddChildNode(TreeNode node)
        {
            Children.Add(node);
        }

        public void RemoveChildNode(TreeNode node)
        {
            Children.Remove(node);
        }
    }
}
