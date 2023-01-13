using System;


namespace DataStructuresWithAlgorithms
{
  public class MyBinarySearchTree
  {
    /** The tree root. */
    private BinaryNode root;
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

    private void PrintTree(BinaryNode t)
    {
      if (t != null)
      {
        PrintTree(t.left);
        Console.Write(t.element);
        Console.Write(" ");
        PrintTree(t.right);
      }
    }

    public void Insert(int x)
    {
      if (root == null)
      {
        root = new BinaryNode(x, null, null);
        return;
      }
      BinaryNode n = root;
      bool inserted = false;
      while (!inserted)
      {
        if (x.CompareTo(n.element) < 0)
        {
          //space found on the left
          if (n.left == null)
          {
            n.left = new BinaryNode(x, null, null);
            inserted = true;
          }
          //keep looking
          else
          {
            n = n.left;
          }
        }
        else if (x.CompareTo(n.element) > 0)
        {
          //space found on the right
          if (n.right == null)
          {
            n.right = new BinaryNode(x, null, null);
            inserted = true;
          }
          //keep looking
          else
          {
            n = n.right;
          }
        }
      }
    }

    public void Remove(int value)
    {
      this.root = Remove(this.root, value);
    }

    public BinaryNode Find(int value)
    {
      return this.Find(value, this.root);
    }

    private BinaryNode Remove(BinaryNode parent, int key)
    {
      if (parent == null) return parent;

      if (key < parent.element)
      {
        parent.left = Remove(parent.left, key);
      }
      else if (key > parent.element)
      {
        parent.right = Remove(parent.right, key);
      }

      // if value is same as parent's value, then this is the node to be deleted  
      else
      {
        // node with only one child or no child  
        if (parent.left == null)
          return parent.right;
        else if (parent.right == null)
          return parent.left;

        // node with two children: Get the inorder successor (smallest in the right subtree)  
        parent.element = MinValue(parent.right);

        // Delete the inorder successor  
        parent.right = Remove(parent.right, parent.element);
      }

      return parent;
    }

    private BinaryNode Find(int value, BinaryNode parent)
    {
      if (parent != null)
      {
        if (value == parent.element) return parent;
        if (value < parent.element)
          return Find(value, parent.left);
        else
          return Find(value, parent.right);
      }

      return null;
    }
   
    private int MinValue(BinaryNode node)
    {
      int minv = node.element;

      while (node.left != null)
      {
        minv = node.left.element;
        node = node.left;
      }

      return minv;
    }
  }
}
