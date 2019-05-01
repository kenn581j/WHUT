using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHUT.Domain
{
    public class Tournament
    {
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
