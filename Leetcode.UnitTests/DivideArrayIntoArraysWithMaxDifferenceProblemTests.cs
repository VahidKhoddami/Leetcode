
public class DivideArrayIntoArraysWithMaxDifferenceProblemTests
{
    [Test]
    public void DivideArrayTest_Test1()
    {
        var sut = new DivideArrayIntoArraysWithMaxDifferenceProblem();
        var result = sut.DivideArray(new int[] { 1, 3, 4, 8, 7, 9, 3, 5, 1 }, 2);
        Assert.That(result, Is.EqualTo(new int[][] { new int[] { 1, 1, 3 }, new int[] { 3, 4, 5 }, new int[] { 7,8,9} }));
    }

    [Test]
    public void DivideArrayTest_Test2()
    {
        var sut = new DivideArrayIntoArraysWithMaxDifferenceProblem();
        var result = sut.DivideArray(new int[] { 1, 3, 3, 2, 7, 3 }, 3);
        Assert.That(result, Is.EqualTo(new int[][] { }));
    }
}

