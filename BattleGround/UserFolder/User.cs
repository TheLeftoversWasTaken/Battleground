using ProjectBattleGround.UserFolder.UserContracts;
using System.Collections.Generic;

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
