
public class OutOfBoundaryPathsProblemTests
{
    [Test]

    public void FindPathsTest_Test1()
    {
        var sut = new OutOfBoundaryPathsProblem();
        var result = sut.FindPaths(2, 2, 2, 0, 0);
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void FindPathsTest_Test2()
    {
        var sut = new OutOfBoundaryPathsProblem();
        var result = sut.FindPaths(8, 50, 23, 5, 26);
        Assert.That(result, Is.EqualTo(914783380));
    }
}

