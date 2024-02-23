public class CheapestFlightsWithinKStopsMProblemTests
{
    [Test]
    public void FindCheapestPrice_WhenCalled_ReturnsCheapestPrice1()
    {
        //Arrange
        var cFlights = new CheapestFlightsWithinKStopsMProblem();
        var n = 3;
        var flights = new int[][]
        {
            new int[] { 0, 1, 100 },
            new int[] { 1, 2, 100 },
            new int[] { 0, 2, 500 },
        };
        var src = 0;
        var dst = 2;
        var k = 1;

        //Act
        var result = cFlights.FindCheapestPrice(n, flights, src, dst, k);

        //Assert
        Assert.That(result, Is.EqualTo(200));
    }

    [Test]
    public void FindCheapestPrice_WhenCalled_ReturnsCheapestPrice2()
    {
        //Arrange
        var cFlights = new CheapestFlightsWithinKStopsMProblem();
        var n = 3;
        var flights = new int[][]
        {
            new int[] { 0, 1, 100 },
            new int[] { 1, 2, 100 },
            new int[] { 0, 2, 500 },
        };
        var src = 0;
        var dst = 2;
        var k = 0;

        //Act
        var result = cFlights.FindCheapestPrice(n, flights, src, dst, k);

        //Assert
        Assert.That(result, Is.EqualTo(500));
    }
}

