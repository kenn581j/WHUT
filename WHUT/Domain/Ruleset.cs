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
            //Check to see if it's the first round of play
            if (CheckIfFirstRound(players))
            {
                return Shuffle(players);
            }

            //Remove Players who lost a match
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
            //Check to see if it's the first round of play
            if (lowerPlayers == null)
            {
                return Shuffle(upperPlayers);
            }

            //Move all players with 1 loss to lower bracket
            foreach (Player player in upperPlayers)
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

            return (Shuffle(upperPlayers), Shuffle(lowerPlayers));
        }

        public List<Player> Swiss(List<Player> players, int parringtype)
        {
            return null;
        }
        public List<Player> RoundRobin(List<Player> players)
        {
            //Check to see if it's the first round of play
            if (CheckIfFirstRound(players))
            {
                //Mangler at added en dumme spiller hvis der er ulige antal
                Shuffle(players);
            }
            else
            {
                //Push all players one space in the list while keeping player one in place. Ex. 1-2-3-4 to 1-4-2-3

            }
            //Pair players so player one meets the last player in the list and player two the second last. Ex 1-2-3-4-5-6. 1 vs 6, 2 vs 4.... 
            List<Player> pairedPlayers = new List<Player>();
            for (int i = 0; i < players.Count / 2; i++)
            {
                pairedPlayers.Add(players[i]);
                pairedPlayers.Add(players[players.Count - i]);
            }
            

            return null;
        }

        #region Private Methods
        private List<Player> Shuffle(List<Player> players)
        {
            List<Player> playersShuffled = new List<Player>();
            Random rand = new Random();

            for (int i = 0; i < players.Count; i++)
            {
                int nextIndex = rand.Next(players.Count + 1);
                playersShuffled.Add(players[nextIndex]);
            }

            return playersShuffled;
        }
        private bool CheckIfFirstRound(List<Player> players)
        {
            int result = 0;
            players.ForEach(x => result += x.Score);

            if(result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
