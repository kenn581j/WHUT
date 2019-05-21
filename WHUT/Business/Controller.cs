using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using WHUT.Persistence;

namespace WHUT.Business
{
    class Controller
    {

        private TournamentRegistry tournamentRegistry = new TournamentRegistry();
        private PlayerRegistry playerRegistry = new PlayerRegistry();
        private PlayerRepo playerRepo = new PlayerRepo();

        public XDocument LoadTournament(string tournamentName)
        {
            XDocument tournamentLoaded = tournamentRegistry.LoadTournament(tournamentName);

            return tournamentLoaded;
        }

        public void NewTournament(string name, string location, DateTime date)
        {
            Tournament tournament = new Tournament(name, location, date);
            tournamentRegistry.SaveTournament(tournament);
        }

        public string GetTournamentInfo(string tournamentName)
        {
            XDocument data = tournamentRegistry.LoadTournament(tournamentName);
            // https://stackoverflow.com/questions/9285708/easiest-way-to-filter-elements-out-of-an-xml-document-in-net

            return null;
        }

        public void RegisterPlayer(string name, string club, string warband)
        {
            Player player = new Player(name, club, warband);
            playerRegistry.SavePlayer(player);

        }

        internal IEnumerable<Player> GetParticipants()
        {
            throw new NotImplementedException();
        }
    }
}
