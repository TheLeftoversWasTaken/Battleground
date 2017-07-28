using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectBattleGround.UserFolder.UserContracts;

namespace ProjectBattleGround.UserFolder
{
    public class User : IUser
    {
        //fields
        private IList<IBattleUnit> userArmy;
        private UserType userType=UserType.Alien;

        //constructors
        public User(UserType userType)
        {
            this.UserType = UserType;
            this.userArmy = new List<IBattleUnit>();
        }

        public User(UserType userType,IList<IBattleUnit> userArmy) 
            : this(userType)
        {
            this.UserArmy = userArmy;
        }  //am not sure how it will be implemented so i made 2 constructors

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

        public UserType UserType
        {
            get
            {
                return this.userType;
            }
            set
            {
                this.userType = value;
            }
        }

        public void AddToUserArmy(IBattleUnit battleUnit)
        {
            userArmy.Add(battleUnit);
        }

        public void RemoveUnitFromUserArmy(IBattleUnit battleUnit)
        {
            throw new NotImplementedException();
        }

        //methods

    }
}
