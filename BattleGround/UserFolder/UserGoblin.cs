using ProjectBattleGround.UserFolder.UserContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround.UserFolder
{
    public class UserGoblin : User, IUser
    {
        public UserGoblin(UserRace userRace) : base(userRace)
        {
        }

        public override string UserArmyRace()
        {
            return "Goblin";
        }
    }
}
