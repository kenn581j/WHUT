using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHUT.Model;

namespace WHUT.ViewModel
{
    public class TournamentViewModel
    {
        private Tournament tournament;
        private TournamentRegistry tournamentRegistry = new TournamentRegistry();

        private void NewTournament(string name, string location, DateTime date)
        {
            tournament = new Tournament(name, location, date);
            tournamentRegistry.SaveTournament(tournament);

        }
    }
}
