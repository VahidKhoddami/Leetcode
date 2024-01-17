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
//var maximumDifferenceBetweenNodeAndAncestor = new MaximumDifferenceBetweenNodeAndAncestorProblem();
//var root = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(8);
//root.left = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(3);
//root.left.left = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(1);
//root.left.right = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(6);
//root.left.right.left = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(4);
//root.left.right.right = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(7);
//root.right = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(10);
//root.right.right = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(14);
//root.right.right.left = new MaximumDifferenceBetweenNodeAndAncestorProblem.TreeNode(13);
//Console.WriteLine(maximumDifferenceBetweenNodeAndAncestor.MaxAncestorDiff(root));

//Determine if string halves are alike: https://leetcode.com/problems/determine-if-string-halves-are-alike/
//var determineIfStringHalvesAreAlike = new DetermineIfStringHalvesAreAlikeProblem();
//Console.WriteLine(determineIfStringHalvesAreAlike.HalvesAreAlike_BetterApproach("book"));

//Minimum number of steps to make two strings anagram: https://leetcode.com/problems/minimum-number-of-steps-to-make-two-strings-anagram/
//var minimumNumberOfStepsToMakeTwoStringsAnagram = new MinimumNumberOfStepsToMakeTwoStringsAnagramProblem();
//Console.WriteLine(minimumNumberOfStepsToMakeTwoStringsAnagram.MinSteps("leetcode", "practice"));

//Determine if two strings are close: https://leetcode.com/problems/determine-if-two-strings-are-close/
//var determineIfTwoStringsAreClose = new DetermineIfTwoStringsAreCloseProblem();
//Console.WriteLine(determineIfTwoStringsAreClose.CloseStrings("abc", "bca"));//True
//Console.WriteLine(determineIfTwoStringsAreClose.CloseStrings("abcd", "bca"));//False
//Console.WriteLine(determineIfTwoStringsAreClose.CloseStrings("abcd", "bcaf"));//False
//Console.WriteLine(determineIfTwoStringsAreClose.CloseStrings("cabbba", "abbccc"));//True
//Console.WriteLine(determineIfTwoStringsAreClose.CloseStrings("svotbsgqiqmeqjwdqqtkucrzqphqxqtqqlyfan", "aapyhufaaaalkqsvtjnaaoewxkrgsbsazadmci"));//True

//Find players with zero or one losses: https://leetcode.com/problems/find-players-with-zero-or-one-losses/
//var findPlayersWithZeroOrOneLosses = new FindPlayersWithZeroOrOneLossesProblem();
//var input = new int[][] { new int[] { 1, 3 }, new int[] { 2, 3 }, new int[] { 3, 6 }, new int[] { 5, 6 }, new int[] { 5, 7 }, 
//    new int[] { 4, 5 }, new int[] { 4, 8 }, new int[] { 4, 9 }, new int[] { 10, 4 }, new int[] { 10, 9 } };
//var output = findPlayersWithZeroOrOneLosses.FindWinners(input);
//foreach (var item in output)
//{
//    Console.WriteLine(item);
//}

//Insert Delete GetRandom O(1): https://leetcode.com/problems/insert-delete-getrandom-o1/
var randomizedSet = new RandomizedSet();
Console.WriteLine(randomizedSet.Insert(1));
Console.WriteLine(randomizedSet.Remove(2));
Console.WriteLine(randomizedSet.Insert(2));
Console.WriteLine(randomizedSet.GetRandom());
Console.WriteLine(randomizedSet.Remove(1));
Console.WriteLine(randomizedSet.Insert(2));
Console.WriteLine(randomizedSet.GetRandom());
















