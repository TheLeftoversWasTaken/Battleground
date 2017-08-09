﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectBattleGround.UserFolder.UserContracts;

namespace ProjectBattleGround.Players
{
    public class BluePlayer : Player
    {
        public BluePlayer(IUser playerArmy) : base(playerArmy)
        {
            this.PlayerArmy.UserArmy[0].CurrentPossition(0, 7); // Archer
            this.PlayerArmy.UserArmy[1].CurrentPossition(1, 7); //Healer
            this.PlayerArmy.UserArmy[2].CurrentPossition(1, 6); //Knight
            this.PlayerArmy.UserArmy[3].CurrentPossition(2, 7);    //Magician
        }
    }
}
