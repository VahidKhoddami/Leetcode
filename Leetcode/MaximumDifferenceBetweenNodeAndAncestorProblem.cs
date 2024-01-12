// Maximum Difference Between Node and Ancestor problem: https://leetcode.com/problems/maximum-difference-between-node-and-ancestor/

/*
 Problem Understanding
The task is to determine the maximum difference in value between any ancestor node and its descendant node in a binary tree. An ancestor node could be the parent, grandparent, etc., and a descendant node is any node that exists under the ancestor in the tree.

Solution Approach
Depth-First Search (DFS) Iteratively:

The non-recursive solution employs an iterative Depth-First Search (DFS) using a stack. DFS is suitable because it allows us to explore each path from the root to the leaf nodes, keeping track of the minimum and maximum values encountered on each path.
Tracking Minimum and Maximum Values:

As we traverse each node, we maintain the minimum (min) and maximum (max) values found on the path from the root to that node. This is crucial because the maximum difference for any node might be with an ancestor that isn't its immediate parent.
Calculating Max Difference at Each Node:

At each node, the algorithm calculates the potential maximum differences: one with the minimum value seen so far (Math.Abs(node.val - min)) and another with the maximum value (Math.Abs(node.val - max)).
The larger of these two differences is compared with the current maxDifference, and maxDifference is updated if a larger difference is found.
Stack Usage:

The stack stores each node along with the minimum and maximum values encountered along the path to that node.
This approach simulates recursive traversal but avoids the overhead and potential stack overflow issues of actual recursion.
Ensuring All Nodes Are Checked:

Every node in the tree is visited, and for each node, the algorithm checks whether it creates a larger difference with the recorded min or max values than what has been seen before.
This ensures that the maximum difference is not missed.
Why This Approach Works
Complete Path Analysis: By maintaining min and max values for each path and updating them as we traverse the tree, every possible ancestor-descendant difference is considered.

Global Maximum Tracking: The maxDifference variable is updated globally throughout the traversal. It always stores the maximum difference encountered at any point, ensuring that the final answer is the largest possible difference in the tree.

Efficiency: The iterative approach with DFS ensures that each node is visited exactly once, and comparisons are made only where necessary, resulting in efficient execution with O(N) complexity, where N is the number of nodes.

In summary, this approach guarantees that the maximum difference between an ancestor and a descendant node is found by exhaustively and efficiently examining the differences along every path in the tree.
 */
public class MaximumDifferenceBetweenNodeAndAncestorProblem
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

    public int MaxAncestorDiff(TreeNode root)
    {
        if (root == null) return 0;

        int maxDifference = 0;
        Stack<(TreeNode node, int min, int max)> stack = new Stack<(TreeNode node, int min, int max)>();
        stack.Push((root, root.val, root.val));

        while (stack.Any())
        {
            var (node, min, max) = stack.Pop();

            // Update the maxDifference based on the current node's value
            maxDifference = Math.Max(maxDifference, Math.Max(Math.Abs(node.val - min), Math.Abs(node.val - max)));

            // Update min and max for the current path
            int currentMin = Math.Min(min, node.val);
            int currentMax = Math.Max(max, node.val);

            if (node.left != null) stack.Push((node.left, currentMin, currentMax));
            if (node.right != null) stack.Push((node.right, currentMin, currentMax));
        }

        return maxDifference;

    }
}
