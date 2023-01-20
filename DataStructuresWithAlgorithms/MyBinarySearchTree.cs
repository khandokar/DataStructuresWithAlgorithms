using System;

namespace DataStructuresWithAlgorithms
{
  public class MyBinarySearchTree
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
    
    public MyBinarySearchTree()
    {
      root = null;
    }

    /**
    * Prints the values in the nodes of the tree
    * in sorted order.
*/
    public void PrintTree()
    {
      if (root == null)
      {
        Console.WriteLine("Empty tree");
      }
      else
      {
        PrintTree(root);
        Console.WriteLine("\n");
      }
    }

    private void PrintTree(TreeNode t)
    {
      if (t != null)
      {
        PrintTree(t.Left);
        Console.Write(t.Val);
        Console.Write(" ");
        PrintTree(t.Right);
      }
    }

    public void Insert(int x)
    {
      if (root == null)
      {
        root = new TreeNode(x, null, null);
        return;
      }
      TreeNode n = root;
      bool inserted = false;
      while (!inserted)
      {
        if (x.CompareTo(n.Val) < 0)
        {
          //space found on the Left
          if (n.Left == null)
          {
            n.Left = new TreeNode(x, null, null);
            inserted = true;
          }
          //keep looking
          else
          {
            n = n.Left;
          }
        }
        else if (x.CompareTo(n.Val) > 0)
        {
          //space found on the Right
          if (n.Right == null)
          {
            n.Right = new TreeNode(x, null, null);
            inserted = true;
          }
          //keep looking
          else
          {
            n = n.Right;
          }
        }
      }
    }

    public void Remove(int value)
    {
      this.root = Remove(this.root, value);
    }

    public TreeNode Find(int value)
    {
      return this.Find(value, this.root);
    }

    public TreeNode InvertTree(TreeNode root)
    {
      if (root == null) return null;
      TreeNode n = root;

      TreeNode tmp = n.Left;
      n.Left = n.Right;
      n.Right = tmp;

      n.Left = InvertTree(n.Left);
      n.Right = InvertTree(n.Right);

      return n;
    }
   
    private TreeNode Remove(TreeNode parent, int key)
    {
      if (parent == null) return parent;

      if (key < parent.Val)
      {
        parent.Left = Remove(parent.Left, key);
      }
      else if (key > parent.Val)
      {
        parent.Right = Remove(parent.Right, key);
      } 
      else
      {
        // if value is same as parent's value, then this is the node to be deleted 
        // node with only one child or no child  
        if (parent.Left == null)
        {
          return parent.Right;
        }
        else if (parent.Right == null)
        {
          return parent.Left;
        }

        // node with two children: Get the inorder successor (smallest in the Right subtree)  
        parent.Val = MinValue(parent.Right);

        // Delete the inorder successor  
        parent.Right = Remove(parent.Right, parent.Val);
      }

      return parent;
    }

    private TreeNode Find(int value, TreeNode parent)
    {
      if (parent != null)
      {
        if (value == parent.Val) return parent;
        if (value < parent.Val)
          return Find(value, parent.Left);
        else
          return Find(value, parent.Right);
      }

      return null;
    }
   
    private int MinValue(TreeNode node)
    {
      int minv = node.Val;

      while (node.Left != null)
      {
        minv = node.Left.Val;
        node = node.Left;
      }

      return minv;
    }
  }
}
