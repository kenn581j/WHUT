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
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int TiebreakerLoss {get; set;}
        public int TiebreakerGloryDiff {get; set;}

        public Player(string name, string club, string warband)
        {
            Name = name;
            Club = club;
            Warband = warband;

        }

        //Pt indeholder konstruktør score og tiebreakers pga. stub listen
        public Player(string name, string club, string warband, int score, int tieBreakerByLoss, int tieBreakerGloryDiff)
        {
            Name = name;
            Club = club;
            Warband = warband;
            Score = score;
            TiebreakerLoss = tieBreakerByLoss;
            TiebreakerGloryDiff = tieBreakerGloryDiff;  
        }

        public Player(string name, string club, string warband, int score, int losses)
        {
            Name = name;
            Club = club;
            Warband = warband;
            Losses = losses;
            Score = score;
        }
        



        public override string ToString()
        {
            return $"{Name} {Club} {Warband}";
            //Så behøver du ikke at lave en lang streng :> 
        }

    }
}
