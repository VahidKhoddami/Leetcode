public class SequentialDigitsProblemTests
{
    [Test]
    public void SequentialDigitsTest1()
    {
        var problem = new SequentialDigitsProblem();
        var result = problem.SequentialDigits(100, 300);
        Assert.That(result, Is.EqualTo(new[] { 123, 234 }));
    }

    [Test]
    public void SequentialDigitsTest2()
    {
        var problem = new SequentialDigitsProblem();
        var result = problem.SequentialDigits(1000, 13000);
        Assert.That(result, Is.EqualTo(new[] { 1234, 2345, 3456, 4567, 5678, 6789, 12345 }));
    }
}

