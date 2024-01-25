//Pseudo-Palindromic Paths in a Binary Tree Url:https://leetcode.com/problems/pseudo-palindromic-paths-in-a-binary-tree/
/*

 */


using System.ComponentModel;

public class PseudoPalindromicPathsInABinaryTreeProblem
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public int PseudoPalindromicPaths(TreeNode root)
    {
        var palindromePaths = 0;
        var nodes = new Stack<(TreeNode,HashSet<int>)>();

        nodes.Push((root, new HashSet<int>()));
        
        while (nodes.Count > 0)
        {
            var (node,values) = nodes.Pop();

            if (!values.Add(node.val))
                values.Remove(node.val);

            if (node.left == null && node.right == null)
            {

                if (values.Count <= 1)
                    palindromePaths++;


            }
            if (node.left != null)
            {
                nodes.Push((node.left,new HashSet<int>(values)));
            }
            if (node.right != null)
            {
                nodes.Push((node.right, new HashSet<int>(values)));
            }
        }

        return palindromePaths;
    }

 
}

