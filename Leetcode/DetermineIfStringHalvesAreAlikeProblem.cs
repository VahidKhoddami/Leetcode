// Determine if String Halves Are Alike Url: https://leetcode.com/problems/determine-if-string-halves-are-alike/
/*
 Intuition
The solution follows a straightforward approach aligned with the problem description.

Approach
The code incorporates several good practices:

Use of HashSet for Vowels:

Advantage: The use of a HashSet for storing vowels is efficient for checking membership, as it has constant time complexity for lookups.
Comparison: Compared to using a list or an array, a HashSet provides faster lookups when checking if a character is a vowel.
Substring Slicing:

Advantage: Concise use of substring slicing syntax (e.g., s[..mid] and s[mid..]) enhances code readability.
Comparison: Compared to manually calculating indices or using substring methods, the slicing syntax is more expressive and easier to understand.
Complexity
Time complexity: O(n)
Space complexity: O(1)
 */

public class DetermineIfStringHalvesAreAlikeProblem
{
    public bool HalvesAreAlike(string s)
    {
        var vowels =new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        var halfIndex = s.Length / 2;
        var rVowelsCnt = 0;
        var lVowelsCnt = 0;

       for (int r=0,l=s.Length-1; r < halfIndex; r++,l--)
        {
            if (vowels.Contains(s[r]))
                rVowelsCnt++;
            if (vowels.Contains(s[l]))
                lVowelsCnt++;
        }

        return lVowelsCnt == rVowelsCnt;
    }

    public bool HalvesAreAlike_BetterApproach(string s)
    {
        var vowels = new HashSet<char> ( "aeiouAEIOU" );
        
        var mid=s.Length/2;
        var lVowelsCnt = s[..mid].Count(vowels.Contains);
        var rVowelsCnt = s[mid..].Count(vowels.Contains);

        return lVowelsCnt == rVowelsCnt;
    }
}