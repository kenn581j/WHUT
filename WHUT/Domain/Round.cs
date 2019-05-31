using System;
using System.Collections.Generic;

namespace WHUT.Domain
{
    public class Round
    {
        public List<Match> matches = new List<Match>();

        public void AddMatch(Match match)
        {
            matches.Add(match);
        }

        public void RemoveMatch(Match match)
        {
            matches.Remove(match);
        }
    }
}