using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround
{
    class Magician : BattleUnit, ITakeDamage, IMove
    {
        public Magician(int health, int damage, CurrentUnitPossition possition) : base(health, damage, possition)
        {
        }
    }
}
