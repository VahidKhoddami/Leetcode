public class ImplementQueusUsingStacksProblemTests
{
    [Test]
    public void Test1()
    {
        var sut = new ImplementQueuUsingStackProblem.MyQueue();
        sut.Push(1);
        sut.Push(2);
        Assert.That(sut.Peek(), Is.EqualTo(1));
        Assert.That(sut.Pop(), Is.EqualTo(1));
        Assert.That(sut.Empty(), Is.False);
    }

    [Test]
    public void Test2()
    {
        var sut = new ImplementQueuUsingStackProblem.MyQueue();
        sut.Push(1);
        sut.Push(2);
        sut.Push(3);
        Assert.That(sut.Peek(), Is.EqualTo(1));
        Assert.That(sut.Pop(), Is.EqualTo(1));
        Assert.That(sut.Empty(), Is.False);
    }
}

