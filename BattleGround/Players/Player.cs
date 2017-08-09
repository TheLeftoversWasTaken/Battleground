using ProjectBattleGround.Players.Contracts;
using ProjectBattleGround.UserFolder.UserContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround.Players
{
    public abstract class Player : IPlayer
    {
        private IUser playerArmy;

        public Player(IUser playerArmy)
        {
            this.PlayerArmy = playerArmy;
        }

        public IUser PlayerArmy { get; private set; }
    }
}
