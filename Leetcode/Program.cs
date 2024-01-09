// Candy problem: https://leetcode.com/problems/candy/
//var candy = new CandyProblem();
//Console.WriteLine(candy.Candy(new int[] { 3, 2, 1, 4, 5 }).ToString());

//Single Nnumber problem: https://leetcode.com/problems/single-number/
//var singleNumber = new SingleNumberProblem();
//Console.WriteLine(singleNumber.SingleNumber(new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 4 }).ToString());

// Gas station problem: https://leetcode.com/problems/gas-station/
var gasStation = new GasStationProblem();
Console.WriteLine(gasStation.CanCompleteCircuit(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 1, 2 }).ToString());
