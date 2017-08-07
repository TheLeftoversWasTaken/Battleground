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
        private UserRace userRace;

        //constructors
        public User(UserRace userRace)
        {
            this.UserRace = UserRace;
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

        public UserRace UserRace
        {
            get
            {
                return this.userRace;
            }
            set
            {
                this.userRace = value;
            }
        }

        //methods

        public abstract void BuildUserArmy();
    }
}
