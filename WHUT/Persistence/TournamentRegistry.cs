using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using WHUT.Domain;

namespace WHUT.Business
{
    public class TournamentRegistry
    {
        private string path = @"C:\Tournaments\";

        private void CheckForDirectory()
        {
            if (Directory.Exists(path) == false)
            {
                DirectoryInfo tournamentsFolder = Directory.CreateDirectory(path);
            }
        }
        public void SaveTournament(Tournament tournament)
        {
            CheckForDirectory();
            XDocument saveTournament = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Tournament",

                    new XElement("Name", tournament.Name),
                    new XElement("Location", tournament.Location),
                    new XElement("Date", tournament.Date)
                    )

                );
            saveTournament.Save(path + tournament.Name + ".xml");
        }

        public XDocument LoadTournament(string tournament)
        {
            XDocument doc;
            try
            {
                doc = XDocument.Load(path + tournament + ".xml");
            }
            catch
            {
                doc = null;
            }
            return doc;
        }
    }
}
