public class PartitionArrayForMaximumSumProblemTests
{
    [Test]
    public void MaxSumAfterPartitioningTest1()
    {
        var problem = new PartitionArrayForMaximumSumProblem();
        var result = problem.MaxSumAfterPartitioning(new[] { 1, 15, 7, 9, 2, 5, 10 }, 3);
        Assert.That(result,Is.EqualTo(84));
    }

    [Test]
    public void MaxSumAfterPartitioningTest2()
    {
        var problem = new PartitionArrayForMaximumSumProblem();
        var result = problem.MaxSumAfterPartitioning(new[] { 1, 4, 1, 5, 7, 3, 6, 1, 9, 9, 3 }, 4);
        Assert.That(result, Is.EqualTo(83));
    }
}

