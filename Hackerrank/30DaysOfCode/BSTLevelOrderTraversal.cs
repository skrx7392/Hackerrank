using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class BSTLevelOrderTraversal
    {
        static TreeNode insert(TreeNode root, int data)
        {
            if (root == null)
            {
                return new TreeNode(data);
            }
            else
            {
                TreeNode cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        static void bSTLevelOrderTraversal(String[] args)
        {
            TreeNode root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);

        }

        static void levelOrder(TreeNode root)
        {
            Queue<TreeNode> bstQueue = new Queue<TreeNode>();
            bstQueue.Enqueue(root);
            while(bstQueue.Count>0)
            {
                TreeNode node = bstQueue.Dequeue();
                if(node.left != null)
                    bstQueue.Enqueue(node.left);
                if(node.right != null)
                    bstQueue.Enqueue(node.right);
                Console.Write(node.data + " ");
            }
        }
    }
}