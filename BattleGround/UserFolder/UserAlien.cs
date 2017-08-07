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
        public UserAlien() : base()
        {
            
        }

        public override void BuildUserArmy()
        {
            this.UserArmy.Add(new Archer());
            this.UserArmy.Add(new Healer(healingPower: 40));
            this.UserArmy.Add(new Knight());
            this.UserArmy.Add(new Magician());
        }
    }
}
