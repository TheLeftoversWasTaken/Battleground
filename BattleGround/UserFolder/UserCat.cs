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

        public override void BuildUserArmy()
        {

            this.UserArmy.Add(new Archer(damage: 30));
            this.UserArmy.Add(new Knight());
            this.UserArmy.Add(new Magician());
            this.UserArmy.Add(new Healer());
        }
    }
}
