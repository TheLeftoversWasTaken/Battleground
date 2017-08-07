using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround
{
    class Knight : BattleUnit, IMove, ITakeDamage
    {
        //constructor from base
        public Knight(int health = 200, int damage = 50) : base(health, damage)
        {
        }
    }
}
