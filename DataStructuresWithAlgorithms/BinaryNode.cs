using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{ 
  public class BinaryNode
  {
    // Constructors
    public BinaryNode(int theElement)
    {
      this.element = theElement;
      this.left = null;
      this.right = null;
    }

    public BinaryNode(int element, BinaryNode left, BinaryNode right)
    {
      this.element = element;
      this.left = left;
      this.right = right;
    }

    public int element; // The data in the node
    public BinaryNode left; // Left child
    public BinaryNode right; // Right child
  }
}
