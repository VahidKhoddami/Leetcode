// Minimum Absolute Difference in BST problem Url: https://leetcode.com/problems/minimum-absolute-difference-in-bst/
/*
 Intuition
BST In-Order Traversal:

A BST, by definition, has the property that for any given node, all values in the left subtree are smaller, and all values in the right subtree are larger.
When you perform an in-order traversal (left, root, right) on a BST, it yields the nodes in ascending order of their values. This is crucial because the smallest difference between any two nodes will be among those that are closest to each other in value, which in a BST are adjacent in in-order traversal.
Approach
Iterative In-Order Traversal:

Stack Utilization: The stack is used to simulate the recursive in-order traversal of a binary search tree (BST). In-order traversal visits nodes in ascending order of their values for a BST.
Traversal Process: The process starts at the root node and initially traverses to the leftmost node, pushing each visited node onto the stack. After reaching the leftmost node, nodes are popped from the stack, their values are processed, and then the process moves to the right subtree.
Maintaining Previous Value:

prev Variable: As each node is visited in order (ascending values), the prev variable keeps track of the value of the previously visited node.
Initial Value of prev: Initially, prev is set to -1, indicating that no node has been visited yet. This value is updated with each visited node.
Calculating the Minimum Difference:

Difference Calculation: For each visited node (after the first), the code calculates the difference between its value (current.val) and the value of the previous node (prev).
Updating Minimum Difference: If this difference is smaller than the current minimum (output), output is updated. This update ensures that output always holds the smallest difference encountered so far.
Early Termination:

Zero Difference Check: If at any point the difference is 0, the function returns immediately, as 0 is the smallest possible difference, and no further traversal can find a smaller difference.
Why It Finds the Minimum Difference:

Sorted Node Values: In a BST, an in-order traversal visits nodes in a sorted (ascending) order. The closest values (and therefore the smallest differences) will always be found between adjacent nodes in this order.
Adjacent Node Comparison: By comparing each node with its immediate predecessor (which in a sorted order is the closest smaller value), the algorithm effectively checks all possible pairs for the smallest difference.
Optimality: Since every node is compared exactly once with its closest smaller neighbor, all possible differences are considered. The algorithm thus guarantees finding the minimum difference.
Complexity
Time complexity: O(n), where n is the number of nodes in the tree. Each node is visited exactly once.
Space complexity: O(n) in the worst case (a completely unbalanced tree), as it might require storing all nodes in the stack at once. However, for a balanced tree, the space complexity would be O(log n).
 */

public class MinimumAbsoluteDifferenceInBSTProblem
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

    public int GetMinimumDifference(TreeNode root)
    {
        int output = int.MaxValue;
        int prev = -1;

        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;

        while (current != null || stack.Count>0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }
            current = stack.Pop();

            if (prev != -1)
            {
                output = Math.Min(output, current.val - prev);
                if (output == 0) return 0; // Early termination
            }
            prev = current.val;

            current = current.right;
        }

        return output;
    }
}