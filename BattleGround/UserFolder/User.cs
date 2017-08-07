using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectBattleGround.UserFolder.UserContracts;

namespace ProjectBattleGround.UserFolder
{
    public abstract class User : IUser
    {
        //fields
        private IList<IBattleUnit> userArmy;
        //constructors
        public User()
        {
            this.UserArmy = new List<IBattleUnit>();
        }

        //properties
        public IList<IBattleUnit> UserArmy
        {
            get
            {
                return this.userArmy;
            }
            private set
            {
                this.userArmy = value;
            }
        }

        //methods

        public abstract void BuildUserArmy();
    }
}
