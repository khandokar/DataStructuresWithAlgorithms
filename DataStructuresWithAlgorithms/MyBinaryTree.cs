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

    public void Insert(int? val)
    {
      if (root == null)
      {
        root = new TreeNode(val);
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
          temp.Left = new TreeNode(val);
          break;
        }
        else
        {
          q.Enqueue(temp.Left);
        }

        if (temp.Right == null)
        {
          temp.Right = new TreeNode(val);
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

    public int MaxDepthBFS(TreeNode root)
    {
      if(root == null) return 0;
      int depth = 0;

      Queue<TreeNode> q = new Queue<TreeNode>();
      q.Enqueue(root);

      while (q.Count != 0)
      {
        int count = q.Count;

        for (int i = 0; i < count; i++)
        {
          TreeNode tn = q.Dequeue();
          if (tn.Left != null) 
          {
            q.Enqueue(tn.Left);
          }
          if (tn.Right != null)
          {
            q.Enqueue(tn.Right);
          }
        }
        depth++;
      }
      return depth;
    }

    public int MaxDepthDFS(TreeNode root)
    {
      //PreOrder DFS
      if (root == null) return 0;
      int depth = 0;

      Stack<KeyValuePair<TreeNode,int>> q = new Stack<KeyValuePair<TreeNode, int>>();
      q.Push(new KeyValuePair<TreeNode, int>(root, 1));

      while (q.Count != 0)
      {
        KeyValuePair<TreeNode, int> kv = q.Pop();
        if(kv.Key != null)
        {
          depth = Math.Max(depth, kv.Value);
          q.Push(new KeyValuePair<TreeNode, int>(kv.Key.Left, kv.Value + 1));
          q.Push(new KeyValuePair<TreeNode, int>(kv.Key.Right, kv.Value + 1));
        }
      }
      return depth;
    }

    public bool IsSameTree(TreeNode p, TreeNode q)
    {
      if (p == null && q == null) return true;
      if (p == null || q == null || p.Val != q.Val) return false;

      return IsSameTree(p.Left,q.Left) && IsSameTree(p.Right, q.Right);
    }

    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
      if (subRoot == null) return true;
      if (root == null) return false;

      if(IsSameTree(root, subRoot)) return true;

      return (IsSubtree(root.Left, subRoot) || IsSubtree(root.Right, subRoot));
    }
  }
}
