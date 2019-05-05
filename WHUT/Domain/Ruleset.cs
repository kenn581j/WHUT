using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHUT.Domain
{
    public class Ruleset
    {        
        public bool PlayerMetAlready { get; private set; } // Midlertidlig bool property

        #region SingleElimination Methods

        public List<Player> SingleElimination(List<Player> players)
        {
            //Remove PLayers who lost a match
            foreach(Player player in players)
            {
                if(players.Count < 0)
                {
                    players.Remove(player);
                }
            }

            //Randommize the reminding players before returning the list
            return Shuffle(players);
        }

        #endregion

        #region DoubleElimination Methods

        public (List<Player>, List<Player>) DoubleElimination(List<Player> upperPlayers, List<Player> lowerPlayers)
        {           
            //Move all players with 1 loss to lower bracket
            foreach(Player player in upperPlayers)
            {
                if (player.Losses < 0)
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

        #endregion

        #region Swiss Methods

        public List<Player> Swiss(List<Player> players, int parringtype)
        {
            SwissSort(players);
            
            Player firstPlayer = null;
            Player secondPlayer = null;

            for (int i = 0; i < players.Count; i++)
            {
                int j = 1;

                if (firstPlayer == players.Last())
                {
                    secondPlayer = Bye();
                }

                if (PlayerMetAlready == true)
                {
                    j += 1;
                }
                
                firstPlayer = players[i];
                secondPlayer = players[i + j];
            }

            return players;
        }



        public List<Player> GWSwiss(List<Player> players, int parringtype)
        {
            SwissSort(players);

            //players.GroupBy(
            //    x => x.Name,
            //    x => x.Score,
            //    (key, group) => new { Score = key, Player = group.ToList() });

            //players.GroupJoin(players,
            //    score => score,
            //    player => player,
            //    (score, playerCollection) =>
            //        new
            //            {
            //                ScoreGroup = score.Score,
            //                players = playerCollection.Select(player => player.Name)
            //            });

            return players;
        }

        #endregion

        #region RoundRobin Methods

        public List<Player> RoundRobin(List<Player> players)
        {
            return null;
        }

        #endregion

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
        private Player Bye()
        {
            throw new NotImplementedException();
        }

        private bool CheckIfFirstRound(List<Player> players)
        {
            return false;
        }

        private void SwissSort(List<Player> players)
        {
            if (CheckIfFirstRound(players))
            {
                Shuffle(players);
            }
            else
            {
                players.OrderBy(x => x.Score).ThenBy(x => x.TiebreakerLoss).ThenBy(x => x.TiebreakerGloryDiff); // Sorting the list with LINQ methods to pair players according to Swiss rules
            }
        }
        #endregion
    }
}
