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

            xmlWriter.WriteStartElement(tournament.Name);
            xmlWriter.WriteAttributeString("Date", tournament.Date.ToString(), "Location");
            xmlWriter.WriteString(tournament.Location);
            xmlWriter.WriteEndElement();

            xmlWriter.Close();
        }
    }
}
