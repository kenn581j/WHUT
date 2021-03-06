﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHUT.Application;
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
          
            xmlWriter.WriteElementString("PlayerName",player.Name);
            xmlWriter.WriteElementString("Club", player.Club);
            xmlWriter.WriteElementString("Warband", player.Warband);

            xmlWriter.WriteEndElement();
            xmlWriter.Close(); 

        
        }

        //Test commit
    }
}
