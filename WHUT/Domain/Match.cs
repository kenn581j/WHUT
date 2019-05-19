using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHUT.Business
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
    }
}
