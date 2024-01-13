// Minimum number of steps to make two strings anagram: https://leetcode.com/problems/minimum-number-of-steps-to-make-two-strings-anagram/
// Given two equal-size strings s and t. In one step you can choose any character of t and replace it with another character.
// Return the minimum number of steps to make t an anagram of s.
// An Anagram of a string is a string that contains the same characters with a different (or the same) ordering.

/*
 Intuition
The intuition is that we need to count the number of each character in t, and then for each character in s, we check if the count of that character in t is less than or equal to 0, meaning that we need to replace that character, so the minimum steps will increase, and then we decrement the number of the corresponding character in t by one.

Approach
Initialization:
minSteps is initialized to 0, representing the minimum steps needed.
tCharCount is an array of size 26 to store the count of each character in string t.
Count Characters in t:
The first loop iterates through each character in string t, incrementing the corresponding count in tCharCount.
Check and Update Counts in s:
The second loop iterates through each character in string s.
For each character in s, it checks if there are no occurrences in t (count < 1). If true, minSteps is incremented.
The count of the character in tCharCount is decremented regardless of the condition, indicating usage of that character from t.

Complexity
Time complexity: O(n), where n is the length of the strings s and t.
Space complexity: O(1) as the size of the tCharCount array is constant (26 characters).
 */

public class MinimumNumberOfStepsToMakeTwoStringsAnagramProblem
{
    public int MinSteps(string s, string t)
    {
        var minSteps = 0;   
        var tCharCount=new int[26];

        foreach(char c in t)
        {
            tCharCount[c-97]++;
        }

        foreach (char c in s)
        {
            if (tCharCount[c-97]<1)
                minSteps++;

            tCharCount[c - 97]--;
        }

        return minSteps;

    }
}