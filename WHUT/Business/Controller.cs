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
        private TournamentRegistry tournamentRegistry;
        private PlayerRegistry playerRegistry;
        private PlayerRepo playerRepo;

        public bool LoadTournament(string tournamentName)
        {
            bool result;
            tournamentRegistry = new TournamentRegistry();
            Tournament tournamentLoaded = tournamentRegistry.LoadTournament(tournamentName);
            
            if (tournamentLoaded != null)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
