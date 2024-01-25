
using static PseudoPalindromicPathsInABinaryTreeProblem;

public class PseudoPalindromicPathsInABinaryTreeProblemTests
{
    [Test]
    public void PseudoPalindromicPathsInABinaryTreeProblem_Test1()
    {
        var pseudoPalindromicPathsInABinaryTreeProblem = new PseudoPalindromicPathsInABinaryTreeProblem();
        Assert.That(pseudoPalindromicPathsInABinaryTreeProblem.PseudoPalindromicPaths(new TreeNode(2, new TreeNode(3, new TreeNode(3), new TreeNode(1)), new TreeNode(1, null, new TreeNode(1)))), Is.EqualTo(2));
    }

    [Test]
    public void PseudoPalindromicPathsInABinaryTreeProblem_Test2()
    {
        var pseudoPalindromicPathsInABinaryTreeProblem = new PseudoPalindromicPathsInABinaryTreeProblem();
        //[2,1,1,1,3,null,null,null,null,null,1]
        Assert.That(pseudoPalindromicPathsInABinaryTreeProblem.PseudoPalindromicPaths(new TreeNode(2, new TreeNode(1, new TreeNode(1), new TreeNode(3,null,new TreeNode(1))), new TreeNode(1))), Is.EqualTo(1));
    }
}

