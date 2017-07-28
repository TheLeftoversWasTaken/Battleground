using ProjectBattleGround.UserFolder.UserContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround.UserFolder
{
    class UserCat : User, IUser
    {
        public UserCat(UserRace userRace) : base(userRace)
        {

        }

        public override string UserArmyRace()
        {
            throw new NotImplementedException();
        }
    }
}
