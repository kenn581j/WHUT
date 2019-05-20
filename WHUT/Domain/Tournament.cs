using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHUT.Business
{
    public class Tournament
    {
        public List<Round> Rounds { get; set; }

        public List<Player> tournamentScore { get; set; } = new List<Player> {
                new Player("Kenneth Mortensen", "Odense", "Zarbags's Gitz", 6, 0, 73),
                new Player("Mike Larsen", "Danmark", "Godsworn Hunt", 0, 4, -32),
                new Player("Lau Steffensen", "Danmark", "Chosen Axes", 3, 2, -9),
                new Player("Kim", "Danmark", "Stormsire's Cursebreakers", 6, 1, 7),
                new Player("Libak", "Danmark", "Stormsire's Cursebreakers", 6, 0, 30)
                };

        public List<Player> GetParticipants { get; set; } = new List<Player> {
                new Player("Kenneth Mortensen", "Odense", "Zarbags's Gitz"),
                new Player("Mike Larsen", "Danmark", "Godsworn Hunt"),
                new Player("Lau Steffensen", "Danmark", "Chosen Axes"),
                new Player("Kim", "Danmark", "Stormsire's Cursebreakers"),
                new Player("Libak", "Danmark", "Stormsire's Cursebreakers")
                };

        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }

        public Tournament(string name, string location, DateTime date)
        {
            Name = name;
            Location = location;
            Date = date;
        }

        //Midligertidlig konstruktør
        public Tournament()
        {
        }

        public override string ToString()
        {
            return Name + Location + Date;
        }
    }
}
