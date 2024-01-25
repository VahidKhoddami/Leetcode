
public class LongestCommonSubsequenceProblemTests
{
    [Test]
    public void LongestCommonSubsequenceProblem_Test1()
    {
        var longestCommonSubsequenceProblem = new LongestCommonSubsequenceProblem();
        Assert.That(longestCommonSubsequenceProblem.LongestCommonSubsequence("abcde", "ace"), Is.EqualTo(3));
    }
}

