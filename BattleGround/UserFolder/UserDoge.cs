using ProjectBattleGround.UserFolder.UserContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround.UserFolder
{
    class UserDoge : User, IUser
    {
        public UserDoge( ) : base()
        {

        }

        public override void BuildUserArmy()
        {
            this.UserArmy.Add(new Knight(health: 225));
            this.UserArmy.Add(new Archer());
            this.UserArmy.Add(new Magician());
            this.UserArmy.Add(new Healer()); ;
        }
    }
}
