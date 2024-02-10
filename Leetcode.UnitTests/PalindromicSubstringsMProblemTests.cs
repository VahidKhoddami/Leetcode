public class PalindromicSubstringsMProblemTests
{
    [Test]
    public void CountSubstringsTest1()
    {
        var s = "abc";
        var problem = new PalindromicSubstringsMProblem();
        var result = problem.CountSubstrings(s);
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void CountSubstringsTest2()
    {
        var s = "aaa";
        var problem = new PalindromicSubstringsMProblem();
        var result = problem.CountSubstrings(s);
        Assert.That(result, Is.EqualTo(6));
    }
}

