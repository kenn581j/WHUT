using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHUT.Domain
{
    public class Match
    {
        public Player FirstOpponent { get; set; }
        public Player SecondOpponent { get; set; }
        public Player Winner { get; set; } = null;
    }
}
