using System;
using System.Collections.Generic;
using WHUT.Business;

namespace WHUT.Business
{
    public class Round
    {
        private List<Match> matches = new List<Match>();

        public List<Match> AddMatch(Match match)
        {
            matches.Add(match);
            return matches;
        }
    }
}