﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHUT.Domain
{
    public class Tournament
    {
        public List<Round> rounds = new List<Round>();

        //Stub liste
        private List<Player> participants = new List<Player> {
                new Player("Kenneth Mortensen", "Odense", "Zarbags's Gitz"),
                new Player("Mike Larsen", "Danmark", "Godsworn Hunt"),
                new Player("Lau Steffensen", "Danmark", "Chosen Axes"),
                new Player("Kim", "Danmark", "Stormsire's Cursebreakers"),
                new Player("Libak", "Danmark", "Stormsire's Cursebreakers")
                };

        public List<Player> Participants
        {
            get { return participants; }
            set { participants = value; }
        }
        public string TournamentType
        {
            get;
            set;
        }
        public string Name { get; private set; }
        public string Location { get; private set; }
        public DateTime Date { get; private set; }


        public Tournament (string name) : this(name, "No location yet") { }

        public Tournament (string name, string location) : this(name, location, DateTime.Parse("01/01/2000")) { }

        public Tournament(string name, string location, DateTime date)
        {
            Name = name;
            Location = location;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Name} {Location} {Date}";
        }
    }
}
