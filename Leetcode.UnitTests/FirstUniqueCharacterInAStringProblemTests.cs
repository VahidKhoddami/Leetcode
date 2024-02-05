public class FirstUniqueCharacterInAStringProblemTests
{
    [Test]
    public void FirstUniqChar_WhenCalled_ReturnsFirstUniqueCharacterIndex()
    {
        //Arrange
        var firstUniqueCharacterInAStringProblem = new FirstUniqueCharacterInAStringProblem();
        var s = "leetcode";

        //Act
        var result = firstUniqueCharacterInAStringProblem.FirstUniqChar(s);

        //Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void FirstUniqChar_WhenCalled_ReturnsFirstUniqueCharacterIndex2()
    {
        //Arrange
        var firstUniqueCharacterInAStringProblem = new FirstUniqueCharacterInAStringProblem();
        var s = "loveleetcode";

        //Act
        var result = firstUniqueCharacterInAStringProblem.FirstUniqChar(s);

        //Assert
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void FirstUniqChar_WhenCalled_ReturnsFirstUniqueCharacterIndex3()
    {
        //Arrange
        var firstUniqueCharacterInAStringProblem = new FirstUniqueCharacterInAStringProblem();
        var s = "aabb";

        //Act
        var result = firstUniqueCharacterInAStringProblem.FirstUniqChar(s);

        //Assert
        Assert.That(result, Is.EqualTo(-1));
    }
}

