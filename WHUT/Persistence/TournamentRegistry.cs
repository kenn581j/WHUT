using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using WHUT.Domain;

namespace WHUT.Persistence
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
            XElement doc;
            try
            {
                doc = XElement.Load(path + tournamentName + ".xml");
            }
            catch
            {
                doc = null;
            }
            //FIX DET HER JIMMY
            IEnumerable<string> tName =
                from i in doc.Descendants("Name")
                select (string)i;
            IEnumerable<string> tLocation =
                from i in doc.Descendants("Location")
                select (string)i;
            IEnumerable<DateTime> tDate =
                from i in doc.Descendants("Date")
                select (DateTime)i;

            string name = tName.Aggregate(new StringBuilder(),
                (sb, i) => sb.Append(i),
                    sp => sp.ToString());
            string location = tLocation.Aggregate(new StringBuilder(),
                (sb, i) => sb.Append(i),
                    sp => sp.ToString());
            string date = tDate.Aggregate(new StringBuilder(),
                (sb, i) => sb.Append(i),
                    sp => sp.ToString());

            Tournament tournament = new Tournament(name, tLocation.ToString(), DateTime.Parse(date));

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
