// Maximum Length of a Concatenated String With Unique Characters Problem Url: https://leetcode.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters
public class MaxLengthOfConcatenatedStringsWithUniqueCharsProblem
{
    public int MaxLength(IList<string> arr)
    {
      
        var result = 0;
        var dp = new List<int> { 0 };
        foreach (var s in arr)
        {
            var a = 0;
            var dup = false;
            var bits = 0;
            foreach (var c in s)
            {
                bits |= 1 << (c - 'a');
                if (((a >> (c - 'a')) & 1) == 1)
                {
                    dup = true;
                }
                a |= 1 << (c - 'a');
            }
            if (dup)
            {
                continue;
            }
            for (var i = dp.Count - 1; i >= 0; --i)
            {
                if ((dp[i] & bits) > 0)
                {
                    continue;
                }
                dp.Add(dp[i] | bits);
                result = Math.Max(result, BitCount(dp[i] | bits));
            }
        }
        return result;

    }

    private int BitCount(int n)
    {
        var count = 0;
        while (n > 0)
        {
            n &= n - 1;
            ++count;
        }
        return count;
    }
    
}

