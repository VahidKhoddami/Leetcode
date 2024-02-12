public class MajorityElementEProblemTests
{
    [Test]
    public void MajorityElement_WhenCalled_ReturnsMajorityElement()
    {
        //Arrange
        var majorityElementEProblem = new MajorityElementEProblem();
        var nums = new int[] { 3, 2, 3 };

        //Act
        var result = majorityElementEProblem.MajorityElement(nums);

        //Assert
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void MajorityElement_WhenCalled_ReturnsMajorityElement2()
    {
        //Arrange
        var majorityElementEProblem = new MajorityElementEProblem();
        var nums = new int[] { 2, 2, 1, 1, 1, 2, 2 };

        //Act
        var result = majorityElementEProblem.MajorityElement(nums);

        //Assert
        Assert.That(result, Is.EqualTo(2));
    }
}

