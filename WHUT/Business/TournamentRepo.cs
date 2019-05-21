using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml;
using WHUT.Business;
using WHUT.UI;

namespace WHUT.Business
{
    public class TournamentRepo
    {
        private Tournament tournament = new Tournament();

        public List<Player> Participants()
        {
            List<Player> participants = tournament.GetParticipants;
            
            return participants;
        }

        public void NewRound()
        {
            List<Player> participants = tournament.GetParticipants;
            Round newRound = new Round();
            int j = 0;
            for (int i = 0; i < participants.Count / 2; i++)
            {
                Match match = new Match(participants[j], participants[++j]);
                j++;
                newRound.AddMatch(match);
            }

            tournament.Rounds.Add(newRound);
        }
        public void RemoveParticipant(string participant)
        {
            Player player = tournament.GetParticipants.Find(playerName => playerName.Name == participant.ToString());
            tournament.GetParticipants.Remove(player);
            AddRound(newRound);
        }

        public void AddRound(Round round)
        {
            rounds.Add(round);
        }
    }
}
