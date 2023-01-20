using System;
using System.Collections.Generic;

namespace DataStructuresWithAlgorithms
{
  internal class MyBinaryTree
  {
    /** The tree root. */
    private TreeNode root;

    public TreeNode Root
    {
      get
      {
        return root;
      }
    }

    public MyBinaryTree()
    {
      root = null;
    }

    public void Insert(int key)
    {
      if (root == null)
      {
        root = new TreeNode(key);
        return;
      }
      Queue<TreeNode> q = new Queue<TreeNode>();
      q.Enqueue(root);

      // Do level order traversal until we find
      // an empty place.
      while (q.Count != 0)
      {
        TreeNode temp = q.Dequeue();

        if (temp.Left == null)
        {
          temp.Left = new TreeNode(key);
          break;
        }
        else
        {
          q.Enqueue(temp.Left);
        }

        if (temp.Right == null)
        {
          temp.Right = new TreeNode(key);
          break;
        }
        else
          q.Enqueue(temp.Right);
      }
    }

    public int MaxDepth(TreeNode root)
    {
      if (root == null) return 0;
      return 1 + Math.Max(MaxDepth(root.Left), MaxDepth(root.Right));
    }

  }
}
