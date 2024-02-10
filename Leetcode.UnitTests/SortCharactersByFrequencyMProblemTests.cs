public class SortCharactersByFrequencyMProblemTests
{
    [Test]
    public void FrequencySortTest1()
    {
        var s = "tree";
        var problem = new SortCharactersByFrequencyMProblem();
        var result = problem.FrequencySort(s);
        Assert.That(result, Is.AnyOf("eert", "eetr"));
    }
    [Test]
    public void FrequencySortTest2()
    {
        var s = "cccaaa";
        var problem = new SortCharactersByFrequencyMProblem();
        var result = problem.FrequencySort(s);
        Assert.That(result, Is.AnyOf("aaaccc", "cccaaa"));
    }
    [Test]
    public void FrequencySortTest3()
    {
        var s = "Aabb";
        var problem = new SortCharactersByFrequencyMProblem();
        var result = problem.FrequencySort(s);
        Assert.That(result, Is.AnyOf("bbAa", "bbaA"));
    }
}

