using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using WHUT.Business;

namespace WHUT.Business
{
    public class TournamentRegistry
    {
        private string path = @"C:\Users\Jimmy\Documents\Tournaments\";
        public void SaveTournament(Tournament tournament)
        {
            if (Directory.Exists(path) == false)
            {
                DirectoryInfo tournamentsFolder = Directory.CreateDirectory(path);
            }
            XDocument saveTournament = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Tournament",

                    new XElement("Name", tournament.Name),
                    new XElement("Location", tournament.Location),
                    new XElement("Date", tournament.Date)
                    )

                );
            saveTournament.Save(path + tournament.Name + ".xml");
            
            
            /* 
            XmlWriter xmlWriter = XmlWriter.Create(tournament.Name + ".xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Tournament");
            
            xmlWriter.WriteElementString("Name", tournament.Name);
            xmlWriter.WriteElementString("Location", tournament.Location);
            xmlWriter.WriteElementString("Date", tournament.Date.ToString());
            xmlWriter.WriteEndElement();

            xmlWriter.Close();
            */
        }

        public XDocument LoadTournament(string tournament)
        {
            XDocument doc = XDocument.Load(tournament);
            //try { doc.Load(path + tournament + ".xml"); }
            //catch
            //{
            //    doc = null;
            //}
            return doc;
        }
    }
}
