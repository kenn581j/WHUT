using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHUT.Domain
{
    public class Tournament
    {

        //Stub liste
        private List<Player> participants = new List<Player> {
                new Player("Kenneth Mortensen", "Odense", "Zarbags's Gitz", 6, 0, 73),
                new Player("Mike Larsen", "Danmark", "Godsworn Hunt", 0, 4, -32),
                new Player("Lau Steffensen", "Danmark", "Chosen Axes", 3, 2, -9),
                new Player("Kim", "Danmark", "Stormsire's Cursebreakers", 6, 1, 7),
                new Player("Libak", "Danmark", "Stormsire's Cursebreakers", 6, 0, 30)
                };

        public List<Player> GetParticipants()
        {
            new List<Player>(participants); //Henter stubkoden, skal senere skiftes til en xmlreader? 
            return participants;
        }

        public string Name { get; private set; }
        public string Location { get; private set; }
        public DateTime Date { get; private set; }

        public Tournament(string name, string location, DateTime date)
        {
            Name = name;
            Location = location;
            Date = date;
        }

        public override string ToString()
        {
            return Name + Location + Date;
        }
    }
}
