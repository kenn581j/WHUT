using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHUT.Persistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WHUT.Domain;
using WHUT.Application;

namespace WHUTTestProject
{ 
    class PersistenceTests
    {
        TournamentRegistry tournamentRegistry;
        Tournament tournament;

        [TestInitialize]
        public void TestInitialize()
        {
            tournamentRegistry = new TournamentRegistry();
            tournament = new Tournament("Testing", "UCL", DateTime.Parse("10/10/2010"))
            {
                TournamentType = "Swiss",
                Participants = new List<Player> {
                new Player("Kenneth Mortensen", "Odense", "Zarbags's Gitz", 0, 6, 0, 73),
                new Player("Mike Larsen", "Danmark", "Godsworn Hunt", 1, 0, 4, -32),
                new Player("Lau Steffensen", "Danmark", "Chosen Axes", 0, 3, 2, -9),
                new Player("Kim", "Danmark", "Stormsire's Cursebreakers", 1, 6, 1, 7),
                new Player("Libak", "Danmark", "Stormsire's Cursebreakers", 0, 6, 0, 30)
                }
            };
        }

        [TestMethod]
        public void TournamentSaveLoadTest()
        {
            tournamentRegistry.SaveTournament(tournament);
            Tournament reloadedTournament = tournamentRegistry.LoadTournament("Testing");

            Assert.AreEqual(tournament, reloadedTournament);
        }
    }
}
