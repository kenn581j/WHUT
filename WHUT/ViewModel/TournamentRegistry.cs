using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WHUT.Model;

namespace WHUT.ViewModel
{
    public class TournamentRegistry
    {
        public void SaveTournament(Tournament tournament)
        {
            XmlWriter saveTournament = XmlWriter.Create(tournament + ".xml");
            
            saveTournament.WriteStartDocument();
            saveTournament.WriteStartElement("Tournaments");

            saveTournament.WriteStartElement(tournament.Name);
            saveTournament.WriteAttributeString("Date", tournament.Date.ToString(), "Location");
            saveTournament.WriteString(tournament.Location);
            saveTournament.WriteEndElement();

            saveTournament.Close();
        }
    }
}
