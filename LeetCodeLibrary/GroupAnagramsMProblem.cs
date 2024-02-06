// Group Anagrams (Medium) problem from LeetCode url: https://leetcode.com/problems/group-anagrams/
/*
 # Intuition
This problem can be solved using sorting, which results in a time complexity of O(m.nlogn). However, to achieve a time complexity of O(m.n), we implement a solution using a dictionary with keys that represent a string of concatenated frequencies for each character.
# Approach
1. For each string in the list `strs`, we first create a key.
2. To create each key, we initially generate a list of 26 items (keeping only lowercase characters) and then iterate through each character in the string, incrementing the count of each character in the list. (The position of each character is based on its ASCII code.)
3. For each key, if it does not exist in the dictionary, we add it; otherwise, we append the current string to the list associated with that key in the dictionary.
# Complexity
- Time complexity: O(m.n), `m` is the length of the input `str` array and `n` is the length of the longest string in the `str` array

- Space complexity: O(m), , `m` is the length of the input `str` array
 */
public class GroupAnagramsMProblem
{

    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dict = new Dictionary<string, IList<string>>();

        foreach (var s in strs)
        {
            var key = GetKey(s);

            if (!dict.ContainsKey(key))
                dict[key] = new List<string>();
            dict[key].Add(s);
        }

        return dict.Values.ToList();
    }

    private string GetKey(string str)
    {
        var counter = new int[26];
        var first = 'a';

        foreach (char c in str)
            counter[c - first]++;

        return string.Join("-", counter);
    }

}

