// Cheapest Flights Within K Stops (Medium) Url: https://leetcode.com/problems/cheapest-flights-within-k-stops/
//Solve using Bellman-Ford algorithm
public class CheapestFlightsWithinKStopsMProblem
{
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        var prices = new long[n];
        for (int i = 0; i < n; i++)
        {
            prices[i] = int.MaxValue;
        }
        prices[src] = 0;
        for (int i = 0; i <= k; i++)
        {
            var temp = new long[n];
            Array.Copy(prices, temp, n);
            foreach (var flight in flights)
            {
                temp[flight[1]] = Math.Min(temp[flight[1]], prices[flight[0]] + flight[2]);
            }
            prices = temp;
        }
        return prices[dst] == int.MaxValue ? -1 : (int)prices[dst];
    }
}

