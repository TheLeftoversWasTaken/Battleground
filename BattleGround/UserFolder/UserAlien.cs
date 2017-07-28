using ProjectBattleGround.UserFolder.UserContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround.UserFolder
{
    class UserAlien : User, IUser
    {
        public UserAlien(UserRace userType) : base(userType)
        {
            
        }

        public override string UserArmyRace()
        {
            throw new NotImplementedException();
        }
    }
}
