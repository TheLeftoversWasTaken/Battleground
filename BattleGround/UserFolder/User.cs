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

        public virtual void BuildUserArmy()
        {
            string race = UserArmyRace();

            switch (race)
            {
                case "Doge":

                    this.UserArmy.Add(new Knight(health: 225));
                    this.UserArmy.Add(new Archer());
                    this.UserArmy.Add(new Magician());
                    this.UserArmy.Add(new Healer());

                    break;

                case "Cat":

                    this.UserArmy.Add(new Archer(damage: 30));
                    this.UserArmy.Add(new Knight());
                    this.UserArmy.Add(new Magician());
                    this.UserArmy.Add(new Healer());

                    break;

                case "Alien":

                    this.UserArmy.Add(new Healer(healingPower: 40));
                    this.UserArmy.Add(new Archer());
                    this.UserArmy.Add(new Knight());
                    this.UserArmy.Add(new Magician());

                    break;

                case "Goblin":

                    this.UserArmy.Add(new Magician(health: 100));
                    this.UserArmy.Add(new Healer());
                    this.UserArmy.Add(new Archer());
                    this.UserArmy.Add(new Knight());

                    break;
                default:
                    break;
            }
        }

        public abstract string UserArmyRace();
    }
}
