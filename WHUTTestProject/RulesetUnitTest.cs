using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WHUT.Domain;
using System.Collections.Generic;

namespace WHUTTestProject
{
    [TestClass]
    public class RulesetUnitTest
    {
        Ruleset ruleset;
        List<Player> participants;

        [TestInitialize]
        public void TestInitialize()
        {
            ruleset = new Ruleset();
            participants = new List<Player> {
                new Player("Kenneth Mortensen", "Odense", "Zarbags's Gitz", 0, 6, 0, 73),
                new Player("Mike Larsen", "Danmark", "Godsworn Hunt", 1, 0, 4, -32),
                new Player("Lau Steffensen", "Danmark", "Chosen Axes", 0, 3, 2, -9),
                new Player("Kim", "Danmark", "Stormsire's Cursebreakers", 1, 6, 1, 7),
                new Player("Libak", "Danmark", "Stormsire's Cursebreakers", 0, 6, 0, 30)
                };
        }
            
        [TestMethod]
        public void SingleEliTest()
        {
            List<Player> participantsRemaining = new List<Player> {
                new Player("Kenneth Mortensen", "Odense", "Zarbags's Gitz", 0, 6, 0, 73),
                new Player("Lau Steffensen", "Danmark", "Chosen Axes", 0, 3, 2, -9),
                new Player("Libak", "Danmark", "Stormsire's Cursebreakers", 0, 6, 0, 30)
                };

            List<Player>participantsAfterSingleEli = ruleset.SingleElimination(participants);

            Assert.AreEqual(participantsRemaining, participantsAfterSingleEli);

        }

        [TestMethod]
        public void DoubleEliTest()
        {
            //Find måde at teste tuple
        }

        [TestMethod]
        public void SwissTest()
        {
            List<Player> participantsProperOrder = new List<Player> {
                new Player("Kenneth Mortensen", "Odense", "Zarbags's Gitz", 0, 6, 0, 73),
                new Player("Libak", "Danmark", "Stormsire's Cursebreakers", 0, 6, 0, 30),
                new Player("Kim", "Danmark", "Stormsire's Cursebreakers", 1, 6, 1, 7),
                new Player("Lau Steffensen", "Danmark", "Chosen Axes", 0, 3, 2, -9),
                new Player("Mike Larsen", "Danmark", "Godsworn Hunt", 1, 0, 4, -32)
                };

            List<Player> participantsAfterSwiss = ruleset.Swiss(participants);

            Assert.AreEqual(participantsProperOrder, participantsAfterSwiss);

        }

    }
}

