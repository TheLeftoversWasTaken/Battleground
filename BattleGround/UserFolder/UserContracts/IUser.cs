using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround.UserFolder.UserContracts
{
    public interface IUser
    {
        UserRace UserRace { get; }
        IList<IBattleUnit> UserArmy { get; }
        void BuildUserArmy();
        
    }
}
