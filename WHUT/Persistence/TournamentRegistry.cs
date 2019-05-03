using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WHUT.Domain;

namespace WHUT.Business
{
    public class TournamentRegistry
    {
        public void SaveTournament(Tournament tournament)
        {
            XmlWriter xmlWriter = XmlWriter.Create(tournament.Name + ".xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Tournament");
            
            xmlWriter.WriteElementString("Name", tournament.Name);
            xmlWriter.WriteElementString("Location", tournament.Location);
            xmlWriter.WriteElementString("Date", tournament.Date.ToString());
            xmlWriter.WriteEndElement();

            xmlWriter.Close();
        }
    }
}
