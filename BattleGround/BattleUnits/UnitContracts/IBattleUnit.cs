using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround
{
    public interface IBattleUnit : IHeal, IMove, ITakeDamage
    {
        int Health { get; }
        int Damage { get; }
    }
}
