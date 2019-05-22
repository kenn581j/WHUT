using System;
using System.Collections.Generic;

namespace WHUT.Domain
{
    public class Round
    {
        private List<Match> matches = new List<Match>();

        public List<Match> AddMatch(Match match)
        {
            matches.Add(match);
            return matches;
        }

        public void RemoveMatch(Match match)
        {
            matches.Remove(match);
        }
    }
}