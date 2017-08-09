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
        private IList<IBattleUnit> playerArmy;

        public Player(IUser playerArmy)
        {
            this.PlayerArmy = playerArmy.UserArmy;
            Console.WriteLine("player");
        }

        public IList<IBattleUnit> PlayerArmy { get; private set; }
    }
}
