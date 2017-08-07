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
        public UserGoblin( ) : base()
        {
        }

        public override void BuildUserArmy()
        {
            this.UserArmy.Add(new Archer());
            this.UserArmy.Add(new Healer());
            this.UserArmy.Add(new Knight());
            this.UserArmy.Add(new Magician(health: 100));
        }
    }
}
