public class SequentialDigitsProblem
{

    public IList<int> SequentialDigits(int low, int high)
    {
        var result = new List<int>();
        var lowLength = low.ToString().Length;
        var highLength = high.ToString().Length;

        for (var i = lowLength; i <= highLength; i++)
        {
            for (var j = 1; j <= 9 - i + 1; j++)
            {
                var number = int.Parse(string.Join("", Enumerable.Range(j, i)));
                if (number >= low && number <= high)
                    result.Add(number);
            }
        }

        return result;
    }
}

