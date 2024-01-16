// Find Players with Zero or One Losses problem: https://leetcode.com/problems/find-players-with-zero-or-one-losses/


public class FindPlayersWithZeroOrOneLossesProblem
{
    public IList<IList<int>> FindWinners(int[][] matches)
    {
        var justWinners = new HashSet<int>();
        var lostOneMatch = new HashSet<int>();
        var others = new HashSet<int>();

        foreach (var match in matches)
        {
            var winner = match[0];
            var loser = match[1];
            if (!lostOneMatch.Contains(winner)
                && !others.Contains(winner))
            {
                justWinners.Add(match[0]);
            }
            else if (lostOneMatch.Contains(winner) || others.Contains(winner))
            {
                if (justWinners.Contains(winner))
                {
                    justWinners.Remove(winner);
                }
            }
            if (justWinners.Contains(loser))
            {
                justWinners.Remove(loser);
            }
            if (!lostOneMatch.Contains(loser)
                && !others.Contains(loser))
            {
                lostOneMatch.Add(loser);
            }
            else if (lostOneMatch.Contains(loser))
            {
                lostOneMatch.Remove(loser);
                others.Add(loser);
            }

        }

        var winners = justWinners.ToList();
        winners.Sort();
        var losers = lostOneMatch.ToList();
        losers.Sort();

        return new List<IList<int>> { winners, losers };

    }

}