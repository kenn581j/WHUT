using System;
using System.IO;
using System.Xml.Linq;
using WHUT.Domain;

namespace WHUT.Business
{
    public class TournamentRegistry
    {
        private string path = @"C:\WHUT\Tournaments\";

        private void CheckForDirectory()
        {
            if (Directory.Exists(path) == false)
            {
                try
                {
                    DirectoryInfo tournamentsFolder = Directory.CreateDirectory(path);
                }
                catch (DiscAccesDeniedException eMessage)
                {
                    throw new DiscAccesDeniedException(@"Disc access denied", eMessage);
                }
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

        public Tournament LoadTournament(string tournamentName)
        {
            XDocument doc;
            try
            {
                doc = XDocument.Load(path + tournamentName + ".xml");
            }
            catch
            {
                doc = null;
            }

            Tournament tournament = new Tournament(doc.Element("Name").ToString(), doc.Element("Location").ToString(), DateTime.Parse(doc.Element("Date").ToString()));
            
            return tournament;
        }

        public class DiscAccesDeniedException : Exception
        {
            public DiscAccesDeniedException()
            {

            }

            public DiscAccesDeniedException(string eMessage) : base(eMessage)
            {

            }

            public DiscAccesDeniedException(string eMessage, Exception inner) : base(eMessage, inner)
            {

            }
        }
    }
}
