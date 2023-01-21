using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresWithAlgorithms
{ 
  public class TreeNode
  {
    // Constructors
    public TreeNode(int? val = 0)
    {
      this.Val = val;
      this.Left = null;
      this.Left = null;
    }

    public TreeNode(int? val = 0, TreeNode left = null, TreeNode right = null)
    {
      this.Val = val;
      this.Left = left;
      this.Left = right;
    }

    public int? Val;
    public TreeNode Left;
    public TreeNode Right;
  }
}
