using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHUT.Domain
{
    public class Ruleset
    {

        public List<Player> SingleElimanation(List<Player> players)
        {
            //Remove PLayers who lost a match
            foreach(Player player in players)
            {
                if(players.MatchLost < 0)
                {
                    players.Remove(player);
                }
            }

            //Randommize the reminding players before returning the list
            return Shuffle(players);
        }

        public (List<Player>, List<PLayer>) DoubleElimanation(List<Player> players)
        {
            List<PLayer> upperPlayers = new List<PLayer>();
            List<PLayer> lowerPlayers = new List<PLayer>();
            return (upperPlayers, lowerPlayers);
        }

        public List<Player> Swiss(List<Player> players, int parringtype)
        {
            return null;
        }
        public List<Player> RoundRobin(List<Player> players)
        {
            return null;
        }

        #region Private Methods
        private List<Player> Shuffle(List<Player> players)
        {
            List<Player> playersNewOrder = new List<Player>();
            Random rand = new Random();

            while(players.Count < 0)
            {
                int nextIndex = rand.Next(players.Count + 1);
                playersNewOrder.Add(players[nextIndex]);
            }

            return playersNewOrder;
        }
        #endregion
    }
}
