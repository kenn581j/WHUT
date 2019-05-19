﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHUT.Business;
using WHUT.Persistence;


namespace WHUT.Business
{
    public class PlayerRepo
    {
        private Player player;
        private PlayerRegistry playerRegistry = new PlayerRegistry();

        public void RegisterPlayer(string name, string club, string warband)
        {
            player = new Player(name, club, warband);
            playerRegistry.SavePlayer(player);

        }

    }      
}
