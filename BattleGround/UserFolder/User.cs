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
            this.userArmy = new List<IBattleUnit>();
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

        public virtual void BuildUserArmy()
        {
            string race = UserArmyRace();

            switch (race)
            {
                case "Doge":
                    break;

                case "Cat":
                    // implement specific attributes for class units
                    break;

                case "Alien":
                    // implement specific attributes for class units
                    break;

                case "Goblin":
                    // implement specific attributes for class units
                    break;
                default:
                    break;
            }
        }

        public abstract string UserArmyRace();
    }
}
