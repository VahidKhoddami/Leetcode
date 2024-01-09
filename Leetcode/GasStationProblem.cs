// Gas station problem: https://leetcode.com/problems/gas-station/
/*
Intuition
A real-world analogy would be a road trip with multiple potential starting points (gas stations). If at any point you run out of fuel before reaching the next station, it's clear that starting from any previous station wouldn't have worked either, since they had even less fuel. So, you would try starting again from the next station.

Approach
Start from the first station and keep track of the remaining gas in the tank as well as the total gas used.
At each station, add gas[i] to the tank and subtract cost[i] (the cost to move to the next station).
If at any point the gas in the tank becomes negative, it means you cannot travel further from the current starting station.
Record the next station as the new starting point. Reset the remaining gas to zero since you are starting afresh.

Complexity
Time complexity: O(n)
Space complexity: O(1)
 */
public class GasStationProblem
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var output= 0;
        var l = gas.Length;
        var remainingGas = 0;
        var totalGasUsed = 0;
        for (int i = 0; i < l; i++)
        {
            remainingGas += gas[i] - cost[i];
            totalGasUsed += gas[i] - cost[i];
            if (remainingGas < 0)
            {
                remainingGas = 0;
                output = i+1;
            }
        }
        return totalGasUsed >= 0 ? output : -1;
    }
}