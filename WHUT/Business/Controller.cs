using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WHUT.Domain;
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
    }
}
