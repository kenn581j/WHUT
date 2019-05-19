using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WHUT.Business;

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

        public XmlDocument LoadTournament(string tournament)
        {
            Tournament t = new Tournament();
            tournament = t.Name;

            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            try { doc.Load(tournament + ".xml"); }
            catch (System.IO.FileNotFoundException)
            {
                doc.LoadXml("<?xml version=\"1.0\"?> \n" +
                "<books xmlns=\"http://www.contoso.com/books\"> \n" +
                "  <book genre=\"novel\" ISBN=\"1-861001-57-8\" publicationdate=\"1823-01-28\"> \n" +
                "    <title>Pride And Prejudice</title> \n" +
                "    <price>24.95</price> \n" +
                "  </book> \n" +
                "  <book genre=\"novel\" ISBN=\"1-861002-30-1\" publicationdate=\"1985-01-01\"> \n" +
                "    <title>The Handmaid's Tale</title> \n" +
                "    <price>29.95</price> \n" +
                "  </book> \n" +
                "</books>");
            }

            return doc;
        }
    }
}
