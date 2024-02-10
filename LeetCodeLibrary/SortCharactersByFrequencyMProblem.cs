using System.Text;

public class SortCharactersByFrequencyMProblem
{
    public string FrequencySort(string s)
    {
        var freq = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (!freq.ContainsKey(c))
                freq.Add(c, 0);

            freq[c]++;
        }

        var freqInv = new Dictionary<int, string>();
        var max = 0;
        foreach (var entry in freq)
        {
            var cnt = entry.Value;
            max = Math.Max(cnt, max);
            if (!freqInv.ContainsKey(cnt))
                freqInv.Add(cnt, "");

            freqInv[cnt] += String.Join("", Enumerable.Repeat(entry.Key, cnt));
        }

        var sorted = new StringBuilder();
        for (int i = max; i > 0; i--)
            if (freqInv.ContainsKey(i))
                sorted.Append(freqInv[i]);

        return sorted.ToString();
    }
    //public string FrequencySort(string s)
    //{
    //    var lst = new int[256];
    //    var first = 'a';

    //    foreach (char c in s)
    //        lst[c - first]++;

    //    var result = new StringBuilder();
    //    while (result.Length < s.Length)
    //    {
    //        var max = 0;
    //        var maxIndex = 0;
    //        for (int i = 0; i < lst.Length; i++)
    //        {
    //            if (lst[i] > max)
    //            {
    //                max = lst[i];
    //                maxIndex = i;
    //            }
    //        }

    //        if (max > 0)
    //        {
    //            for (int i = 0; i < max; i++)
    //                result.Append((char)(maxIndex + first));
    //            lst[maxIndex] = 0;
    //        }
    //    }

    //    return result.ToString();
    //}   
}

