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
    }
}
