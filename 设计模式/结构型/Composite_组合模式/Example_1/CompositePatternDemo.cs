using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_组合模式.Example_1
{
    public class CompositePatternDemo
    {
        public static void test()
        {
            TreeNode root = new TreeNode(0,"根节点");

            TreeNode two_level1 = new TreeNode(1,"二级节点---1");
            TreeNode two_level2 = new TreeNode(2,"三级节点---2");

            TreeNode three_level1 = new TreeNode(3,"二级节点---1");
            TreeNode three_level2 = new TreeNode(4,"二级节点---2");

            TreeNode three_level3 = new TreeNode(5,"三级节点---3");
            TreeNode three_level4 = new TreeNode(6,"三级节点---4");

            two_level1.AddChildNode(three_level1);
            two_level1.AddChildNode(three_level2);

            two_level2.AddChildNode(three_level3);
            two_level2.AddChildNode(three_level4);

            root.AddChildNode(two_level1);
            root.AddChildNode(two_level2);

            ShowTree(root,"");
        }

        private static void ShowTree(TreeNode treeNode,string line) {
            Console.WriteLine(line + treeNode.NodeId +":"+treeNode.NodeName);
            if (treeNode.Children.Count > 0) {
                foreach (var item in treeNode.Children)
                {
                    ShowTree(item, "--"+line);
                }
            }
        }
    }
}
