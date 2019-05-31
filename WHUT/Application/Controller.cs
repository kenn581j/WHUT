using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHUT.Domain;
using WHUT.Persistence;

namespace WHUT.Application
{
    public sealed class Controller
    {
        private static readonly Controller singletonController = new Controller();
        public Tournament tournament; //Later development will ensure the object cannot be overwritten

        public static Controller Instance
        {
            get { return singletonController; }
        }
        private Controller ()
        {
        }
        static Controller() // has a static constructor, so it executes only once
        {
        }

        public void CreateTournament(string tournamentName, string location, DateTime date)
        {
            TournamentRepo tournamentRepo = new TournamentRepo();
            tournament = tournamentRepo.NewTournament(tournamentName, location, date);
            SaveTournament(tournament);
        }

        public bool LoadTournament(string tournamentName)
        {
            TournamentRegistry tournamentRegistry = new TournamentRegistry();
            bool result;
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

        public void SaveTournament(Tournament tournament)
        {
            TournamentRegistry tournamentRegistry = new TournamentRegistry();
            tournamentRegistry.SaveTournament(tournament);
        }
    }
}
