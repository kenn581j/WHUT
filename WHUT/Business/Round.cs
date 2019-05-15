using System;
using System.Collections.Generic;
using WHUT.Domain;

namespace WHUT.Business
{
    public class Round
    {
        private List<Match> matches = new List<Match>();

        public void AddMatch(Match match)
        {
            matches.Add(match);

        }
    }
}