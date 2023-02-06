using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresWithAlgorithms
{
    internal class MyBinaryTree
    {
        /** The tree root. */
        private TreeNode root;
        private int maxPathSum;
        private List<string> data;
        private int i;

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
            if (root == null) return 0;
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

            Stack<KeyValuePair<TreeNode, int>> q = new Stack<KeyValuePair<TreeNode, int>>();
            q.Push(new KeyValuePair<TreeNode, int>(root, 1));

            while (q.Count != 0)
            {
                KeyValuePair<TreeNode, int> kv = q.Pop();
                if (kv.Key != null)
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

            return IsSameTree(p.Left, q.Left) && IsSameTree(p.Right, q.Right);
        }

        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (subRoot == null) return true;
            if (root == null) return false;

            if (IsSameTree(root, subRoot)) return true;

            return (IsSubtree(root.Left, subRoot) || IsSubtree(root.Right, subRoot));
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> od = new List<IList<int>>();
            if (root == null) return od;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int length = queue.Count;
                List<int> list = new List<int>();
                for (int i = 0; i < length; i++)
                {
                    TreeNode td = queue.Dequeue();
                    if (td.Val.HasValue)
                    {
                        list.Add(td.Val.Value);
                        if (td.Left != null)
                        {
                            queue.Enqueue(td.Left);
                        }
                        if(td.Right != null)
                        {
                            queue.Enqueue(td.Right);
                        }
                    }
                }
                od.Add(list);
            }

            return od;
        }

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder == null || inorder == null) return null;
            if (preorder.Length == 0 || inorder.Length == 0) return null;

            TreeNode root = new TreeNode(preorder[0]);
            int indexOfMid = Array.IndexOf(inorder, preorder[0]);

            root.Left = BuildTree(preorder.Take(new Range(1, indexOfMid + 1)).ToArray(), inorder.Take(new Range(0, indexOfMid)).ToArray());
            root.Right = BuildTree(preorder.Take(new Range(indexOfMid + 1, preorder.Length)).ToArray(), inorder.Take(new Range(indexOfMid + 1, preorder.Length)).ToArray());

            return root;

        }

        public int MaxPathSum(TreeNode root)
        {
            maxPathSum = int.MinValue;
            PathSum(root);
            return maxPathSum;
        }

        public string Serialize(TreeNode root)
        {
            data = new List<string>();
            PreOrder(root);
            return String.Join(",", data);
        }

        public TreeNode Deserialize(string d)
        {
            data = d.Split(",").ToList<string>();
            i = 0;
            return DoDeserialize();
        }

        private TreeNode DoDeserialize()
        {
            if(data[i] == "N")
            {
                i++;
                return null;
            }
            TreeNode t = new TreeNode(Convert.ToInt32(data[i]));
            i++;
            t.Left = DoDeserialize();
            t.Right = DoDeserialize();
            return t;
        }

        private void PreOrder(TreeNode t)
        {
            if (t == null)
            {
                data.Add("N");
                return;
            }
            else
            {
                data.Add(t.Val.Value.ToString());
                PreOrder(t.Left);
                PreOrder(t.Right);
            }
        }

        private int PathSum(TreeNode t)
        {
            if(t == null) return 0;
            int left = Math.Max(0, PathSum(t.Left));
            int right = Math.Max(0, PathSum(t.Right));
            maxPathSum = Math.Max(maxPathSum, left + right + (t.Val.HasValue ? t.Val.Value : 0));
            return Math.Max(left, right) + (t.Val.HasValue ? t.Val.Value : 0);
        }
    }
}
