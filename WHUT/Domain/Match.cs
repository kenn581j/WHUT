using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHUT.Domain
{
    public class Match
    {
        public Player FirstPlayer { get; set; }
        public Player SecondPlayer { get; set; }
        public Player Winner { get; set; } = null;

        public Match(Player firstPlayer, Player secondPlayer)
        {
            FirstPlayer = firstPlayer;
            SecondPlayer = secondPlayer;
        }

        public override string ToString()
        {
            return $"{FirstPlayer} Versus {SecondPlayer}";
        }
    }
}
