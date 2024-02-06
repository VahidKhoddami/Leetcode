
public class GroupAnagramsMProblemTests
{

    [Test]
    public void GroupAnagrams_WhenCalled_ReturnsGroupedAnagrams()
    {
        //Arrange
        var groupAnagramsMProblem = new GroupAnagramsMProblem();
        var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

        //Act
        var result = groupAnagramsMProblem.GroupAnagrams(strs);

        //Assert
        Assert.That(result, Is.EqualTo(new List<IList<string>>()
        {
            new List<string>() { "eat", "tea", "ate" },
            new List<string>() { "tan", "nat" },
            new List<string>() { "bat" }
        }));
    }

    [Test]
    public void GroupAnagrams_WhenCalled_ReturnsGroupedAnagrams2()
    {
        //Arrange
        var groupAnagramsMProblem = new GroupAnagramsMProblem();
        var strs = new string[] { "" };

        //Act
        var result = groupAnagramsMProblem.GroupAnagrams(strs);

        //Assert
        Assert.That(result, Is.EqualTo(new List<IList<string>>()
        {
            new List<string>() { "" }
        }));
    }

    [Test]
    public void GroupAnagrams_WhenCalled_ReturnsGroupedAnagrams3()
    {
        //Arrange
        var groupAnagramsMProblem = new GroupAnagramsMProblem();
        var strs = new string[] { "a" };

        //Act
        var result = groupAnagramsMProblem.GroupAnagrams(strs);

        //Assert
        Assert.That(result, Is.EqualTo(new List<IList<string>>()
        {
            new List<string>() { "a" }
        }));
    }

    [Test]
    public void GroupAnagrams_WhenCalled_ReturnsGroupedAnagrams4()
    {
        //Arrange
        var groupAnagramsMProblem = new GroupAnagramsMProblem();
        var strs = new string[] { "bdddddddddd", "bbbbbbbbbbc" };

        //Act
        var result = groupAnagramsMProblem.GroupAnagrams(strs);

        //Assert
        Assert.That(result, Is.EqualTo(new List<IList<string>>()
        {
            new List<string>() { "bdddddddddd" },
            new List<string>() { "bbbbbbbbbbc" }
        }));
    }

}

