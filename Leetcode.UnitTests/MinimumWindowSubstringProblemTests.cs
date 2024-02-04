public class MinimumWindowSubstringProblemTests
{
    [Test]
    public void MinWindow_Example1()
    {
        var s = "ADOBECODEBANC";
        var t = "ABC";
        var problem = new MinimumWindowSubstringProblem();
        var result = problem.MinWindow(s, t);
        Assert.That(result, Is.EqualTo("BANC"));
    }

    [Test]
    public void MinWindow_Example2()
    {
        var s = "a";
        var t = "a";
        var problem = new MinimumWindowSubstringProblem();
        var result = problem.MinWindow(s, t);
        Assert.That(result, Is.EqualTo("a"));
    }

    [Test]
    public void MinWindow_Example3()
    {
        var s = "a";
        var t = "aa";
        var problem = new MinimumWindowSubstringProblem();
        var result = problem.MinWindow(s, t);
        Assert.That(result, Is.EqualTo(""));
    }

}

