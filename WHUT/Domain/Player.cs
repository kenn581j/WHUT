using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHUT.Domain
{
   public class Player
    {
        public string Name {get; set;}
        public string Club {get; set;}
        public string Warband {get; set;}
        public int Score {get; set;}
        public int TiebreakerLoss {get; set;}
        public int TiebreakerGloryDiff {get; set;} 

        public Player(string name, string club, string warband)
        {
            Name = name;
            Club = club;
            Warband = warband; 
  
        }

        public override string ToString()
        {
            return $"{Name} {Club} {Warband}";
            //Så behøver du ikke at lave en lang streng :> 
        }

    }
}
