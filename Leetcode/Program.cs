// Candy problem: https://leetcode.com/problems/candy/
//var candy = new CandyProblem();
//Console.WriteLine(candy.Candy(new int[] { 3, 2, 1, 4, 5 }).ToString());

//Single Nnumber problem: https://leetcode.com/problems/single-number/
//var singleNumber = new SingleNumberProblem();
//Console.WriteLine(singleNumber.SingleNumber(new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 4 }).ToString());

// Gas station problem: https://leetcode.com/problems/gas-station/
//var gasStation = new GasStationProblem();
//Console.WriteLine(gasStation.CanCompleteCircuit(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 1, 2 }).ToString());

// Binary tree right side view: https://leetcode.com/problems/binary-tree-right-side-view/
//var binaryTreeRightSideView = new BinaryTreeRightSideViewProblem();
//var root = new BinaryTreeRightSideViewProblem.TreeNode(1);
//root.left = new BinaryTreeRightSideViewProblem.TreeNode(2);
//root.right = new BinaryTreeRightSideViewProblem.TreeNode(3);
//root.left.right = new BinaryTreeRightSideViewProblem.TreeNode(5);
//root.right.right = new BinaryTreeRightSideViewProblem.TreeNode(4);
//var output = binaryTreeRightSideView.RightSideView(root);
//foreach (var item in output)
//{
//    Console.WriteLine(item);
//}

//Minimum absolute difference in BST: https://leetcode.com/problems/minimum-absolute-difference-in-bst/
//var minimumAbsoluteDifferenceInBST = new MinimumAbsoluteDifferenceInBSTProblem();
//var root = new MinimumAbsoluteDifferenceInBSTProblem.TreeNode(1);
//root.right = new MinimumAbsoluteDifferenceInBSTProblem.TreeNode(3);
//root.right.left = new MinimumAbsoluteDifferenceInBSTProblem.TreeNode(2);
//Console.WriteLine(minimumAbsoluteDifferenceInBST.GetMinimumDifference(root));

//Maximum difference between node and ancestor: https://leetcode.com/problems/maximum-difference-between-node-and-ancestor/
var maximumDifferenceBetweenNodeAndAncestor = new MaximumDifferenceBetweenNodeAndAncestorProblem();
var root = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(8);
root.left = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(3);
root.left.left = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(1);
root.left.right = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(6);
root.left.right.left = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(4);
root.left.right.right = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(7);
root.right = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(10);
root.right.right = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(14);
root.right.right.left = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(13);
Console.WriteLine(maximumDifferenceBetweenNodeAndAncestor.MaxAncestorDiff(root));





