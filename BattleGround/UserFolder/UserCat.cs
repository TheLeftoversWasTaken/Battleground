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
        public UserCat() : base()
        {

        }

        public override void BuildUserArmy()
        {

            this.UserArmy.Add(new Archer(damage: 30));
            this.UserArmy.Add(new Healer());
            this.UserArmy.Add(new Knight());
            this.UserArmy.Add(new Magician());

        }
    }
}
