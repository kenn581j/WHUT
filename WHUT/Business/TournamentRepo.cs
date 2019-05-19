using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHUT.Business;

namespace WHUT.Business
{
    public class TournamentRepo
    {
        private Tournament tournament;
        private TournamentRegistry tournamentRegistry = new TournamentRegistry();
        

        public void NewTournament(string name, string location, DateTime date)
        {
            tournament = new Tournament(name, location, date);
            tournamentRegistry.SaveTournament(tournament);
        }

        public void NewRound()
        {
            List<Player> participants = tournament.GetParticipants();
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

        public void LoadTournament(string tournamentName)
        {
            tournamentRegistry.LoadTournament(tournamentName);

        }
    }
}
