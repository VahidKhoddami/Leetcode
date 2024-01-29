
public class KInversePairsArrayProblemTests
{
    [Test]
    public void KInversePairsTest_Test1()
    {
        var sut = new KInversePairsArrayProblem();
        var result = sut.KInversePairs(3, 0);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void KInversePairsTest_Test2()
    {
        var sut = new KInversePairsArrayProblem();
        var result = sut.KInversePairs(3, 1);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void KInversePairsTest_Test3()
    {
        var sut = new KInversePairsArrayProblem();
        var result = sut.KInversePairs(1000, 1000);
        Assert.That(result, Is.EqualTo(663677020));
    }
}

