// Binary tree right side view: https://leetcode.com/problems/binary-tree-right-side-view/

using System.Drawing;
/*
Intuition
Breadth-First Search (BFS) Approach: 
This algorithm uses a queue data structure to implement a breadth-first search (BFS) traversal of the tree, which is necessary to identify the rightmost element at each level.


Approach
The algorithm processes nodes level by level. The outer while loop continues as long as there are nodes in the queue. Inside this loop, the algorithm processes each level of the tree.
To capture the right most element For each level of the tree, the algorithm iterates through all the nodes at that level ("for" loop with l=queue.Count). The rightmost element is identified as the last element in the current level (if (i == l - 1)). This is because in BFS, nodes are enqueued and dequeued in a left-to-right order.
To traverse the tree level by level, inside the loop, child nodes of the current node (node.left and node.right) are enqueued if they are not null.

Complexity
Time complexity: O(n), where n is the number of nodes in the binary tree where n is the number of nodes in the binary tree because each node in the tree is visited exactly once
Space complexity: O(n), size of the queue can grow up to the maximum number of nodes at any level in the given binary tree
    */
public class BinaryTreeRightSideViewProblem
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
    public IList<int> RightSideView(TreeNode root)
    {
        var output = new List<int>();
        if (root == null)
        {
            return output;
        }
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var l = queue.Count;
            for (int i = 0; i < l; i++)
            {
                var node = queue.Dequeue();
                if (i == l - 1)
                {
                    output.Add(node.val);
                }
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
        }
        return output;
    }
}
