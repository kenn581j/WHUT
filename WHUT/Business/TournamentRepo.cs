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

        //Stub liste
        private List<Player> participants = new List<Player> {
                new Player("Kenneth Mortensen", "Odense", "Zarbags's Gitz", 6, 0, 73),
                new Player("Mike Larsen", "Danmark", "Godsworn Hunt", 0, 4, -32),
                new Player("Lau Steffensen", "Danmark", "Chosen Axes", 3, 2, -9),
                new Player("Kim", "Danmark", "Stormsire's Cursebreakers", 6, 1, 7),
                new Player("Libak", "Danmark", "Stormsire's Cursebreakers", 6, 0, 30)
                };

        public void NewTournament(string name, string location, DateTime date)
        {
            tournament = new Tournament(name, location, date);
            tournamentRegistry.SaveTournament(tournament);
        }

        /* Skal lægges i round klassen måske? 
        public List<Match> Matching()
        {
            Ruleset ruleset = new Ruleset();
            ruleset.Swiss(participants);
            List<Match> matches = new List<Match>();

            int j = 0;
            for (int i = 0; i < participants.Count / 2; i++)
            {
                matches.Add(new Match(participants[j], participants[++j]));
                j++;
            }
            return matches;
        }
        */

    }
}
