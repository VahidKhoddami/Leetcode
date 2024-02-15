public class RearrangeArrayElementsbySignMProblemTests
{
    [Test]
    public void RearrangeArray_WhenCalled_ReturnsRearrangedArray()
    {
        //Arrange
        var rArray = new RearrangeArrayElementsbySignMProblem();
        var nums = new int[] { 3, 1, -2, -5, 2, -4 };

        //Act
        var result = rArray.RearrangeArray(nums);

        //Assert
        Assert.That(result, Is.EqualTo(new int[] { 3, -2, 1, -5, 2, -4 }));
    }

    [Test]
    public void RearrangeArray_WhenCalled_ReturnsRearrangedArray2()
    {
        //Arrange
        var rArray = new RearrangeArrayElementsbySignMProblem();
        var nums = new int[] { -1, 1 };

        //Act
        var result = rArray.RearrangeArray(nums);

        //Assert
        Assert.That(result, Is.EqualTo(new int[] { 1, -1 }));
    }
}

