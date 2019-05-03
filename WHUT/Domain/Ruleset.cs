using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHUT.Domain
{
    public class Ruleset
    {

        public List<Player> SingleElimination(List<Player> players)
        {
            //Remove PLayers who lost a match
            foreach(Player player in players)
            {
                if(player.Losses > 0)
                {
                    players.Remove(player);
                }
            }

            //Randommize the reminding players before returning the list
            return Shuffle(players);
        }

        public (List<Player>, List<Player>) DoubleElimination(List<Player> upperPlayers, List<Player> lowerPlayers)
        {           
            //Move all players with 1 loss to lower bracket
            foreach(Player player in upperPlayers)
            {
                if (player.Losses > 0)
                {
                    lowerPlayers.Add(player);
                    upperPlayers.Remove(player);
                }
            }
            //Remove all players with 2 losses in lower bracket
            foreach(Player player in lowerPlayers)
            {
                if (player.Losses > 1)
                {
                    lowerPlayers.Remove(player);
                }
            }

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
            List<Player> playersShuffled = new List<Player>();
            Random rand = new Random();

            while(players.Count < 0)
            {
                int nextIndex = rand.Next(players.Count + 1);
                playersShuffled.Add(players[nextIndex]);
            }

            return playersShuffled;
        }
        #endregion
    }
}
