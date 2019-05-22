using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHUT.Domain;

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
            List<Player> participants = SortParticipants(tournament.TournamentType, tournament.Participants);

            Round newRound = new Round();

            int j = 0;
            for (int i = 0; i < participants.Count / 2; i++)
            {
                Match match = new Match(participants[j], participants[++j]);
                j++;
                newRound.AddMatch(match);
            }

            AddRound(newRound);
        }
        public List<Player> SortParticipants(string tournamentType, List<Player> participants)
        {
            List<Player> sortParticipants = new List<Player>();
            Ruleset ruleset = new Ruleset();
            switch (tournamentType)
            {
                case "Monrad Swiss":
                    sortParticipants = ruleset.Swiss(participants);
                    break;
                case "Games Workshop Swiss":
                    sortParticipants = ruleset.GMSwiss(participants);
                    break;
                case "Single Elimination":
                    sortParticipants = ruleset.SingleElimination(participants);
                    break;
                case "Double Elimination":
                    sortParticipants = ruleset.DoubleElimination(participants);
                    break;
                case "Round Robin":
                    sortParticipants = ruleset.RoundRobin(participants);
                    break;
                default:
                    tournamentType = null;
                    break;
            }

            return sortParticipants;
        }
        public void AddRound(Round round)
        {
            tournament.rounds.Add(round);
        }
    }
}
