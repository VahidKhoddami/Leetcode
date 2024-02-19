public class MeetingRooms3HProblemTests
{
    [Test]
    public void MostBooked_WhenCalled_ReturnsMostBookedRoom()
    {
        //Arrange
        var mRooms = new MeetingRooms3HProblem();
        var n = 2;
        var meetings = new int[][]
        {
            new int[] { 0, 10 },
            new int[] { 1, 5 },
            new int[] { 2, 7 },
            new int[] { 3, 4 },
        };

        //Act
        var result = mRooms.MostBooked(n, meetings);

        //Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void MostBooked_WhenCalled_ReturnsMostBookedRoom2()
    {
        //Arrange
        var mRooms = new MeetingRooms3HProblem();
        var n = 3;
        var meetings = new int[][]
        {
            new int[] { 1, 20 },
            new int[] { 2, 10 },
            new int[] { 3, 5 },
            new int[] { 6, 8 },
            new int[] { 4, 9 },
        };

        //Act
        var result = mRooms.MostBooked(n, meetings);

        //Assert
        Assert.That(result, Is.EqualTo(1));
    }
    //meetings =[[3,7],[12,19],[16,17],[1,17],[5,6]]
    [Test]
    public void MostBooked_WhenCalled_ReturnsMostBookedRoom3()
    {
        //Arrange
        var mRooms = new MeetingRooms3HProblem();
        var n = 3;
        var meetings = new int[][]
        {
            new int[] { 3, 7 },
            new int[] { 12, 19 },
            new int[] { 16, 17 },
            new int[] { 1, 17 },
            new int[] { 5, 6 },
        };

        //Act
        var result = mRooms.MostBooked(n, meetings);

        //Assert
        Assert.That(result, Is.EqualTo(1));
    }


}
