// Unique Number of Occurrences Problem URL: https://leetcode.com/problems/unique-number-of-occurrences/
/*
 Intuition
We can use an array or a dictionary and a hashset. I chose array, as we know that a constant array size of 2001 can be used based on the problem's contraints. We keep track of the number of each item in the arr by increasing the element in the cntArray that is located at item+1000 index. Then, we add each non-zero element of cntArray to the cntHash set, where we can keep track of unique items. If we find any item that is already in the cntArray, it means that it is repeated, and we return false; otherwise, we continue.

Complexity
Time complexity: O(n)
Space complexity: O(n)
 */

internal class UniqueNumberOfOccurrencesProblem
{
    public bool UniqueOccurrences(int[] arr)
    {
        // HashSet to store unique occurrences count
        var cntHash = new HashSet<int>();
        // Array to track occurrences of each item        
        var cntArray = new int[2001];

        // Count occurrences of each item in the array
        foreach (var item in arr)
        {
            cntArray[item + 1000]++;
        }

        // Check for unique occurrences using the cntHash set
        for (int i = 0; i < cntArray.Length; i++)
        {
            if (cntArray[i] != 0)
            {
                // If a count is already present, it indicates repetition
                if (cntHash.Contains(cntArray[i]))
                    return false;
                else
                    cntHash.Add(cntArray[i]);
            }
        }

        // All occurrences are unique
        return true;
    }

    /* Alternate solution using Dictionary
     public bool UniqueOccurrences(int[] arr)
    {
        var cntHash = new HashSet<int>();
        var arrDict = arr.Aggregate(new Dictionary<int, int>(), (dict, item) =>
        {
            if (dict.ContainsKey(item))
                dict[item]++;
            else
                dict.Add(item, 1);

            return dict;
        });

        HashSet<int> uniqueCounts = new HashSet<int>(arrDict.Values);

        return arrDict.Count == uniqueCounts.Count;
    }
     */
}