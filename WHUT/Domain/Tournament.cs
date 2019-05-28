using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHUT.Domain
{
    public class Tournament
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }

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
