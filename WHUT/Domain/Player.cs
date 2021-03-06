﻿using System;
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
        

        public Player(string name) : this(name, "No club")
        {
            
        }
        public Player(string name, string club) : this (name, club, "No warband selected")
        {
            
        }
        public Player(string name, string club, string warband)
        {
            Name = name;
            Club = club;
            Warband = warband;
        }


        //Pt indeholder konstruktør score og tiebreakers pga. stub listen
        public Player(string name, string club, string warband, int losses , int score, int tieBreakerByLoss, int tieBreakerGloryDiff)
        {
            Name = name;
            Club = club;
            Warband = warband;
            Losses = losses;
            Score = score;
            TiebreakerLoss = tieBreakerByLoss;
            TiebreakerGloryDiff = tieBreakerGloryDiff;
        }

        public override string ToString()
        {
            return $"{Name} {Club} {Warband}";
        }

    }
}
