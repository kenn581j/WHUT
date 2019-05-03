using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHUT.Business;
using WHUT.Domain;
using System.Xml;



namespace WHUT.Persistence
{
    public class PlayerRegistry
    {
        public void SavePlayer(Player player)
        {
            XmlWriter xmlWriter = XmlWriter.Create(player.Name + ".xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Player");
          
            xmlWriter.WriteStartElement("Player Name", player.Name);
            xmlWriter.WriteElementString("Club", player.Club);
            xmlWriter.WriteElementString("Warband", player.Warband);

            xmlWriter.WriteEndElement();
            xmlWriter.Close();

        }
    }
}
