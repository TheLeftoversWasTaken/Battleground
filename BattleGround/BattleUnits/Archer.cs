using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround
{
    public class Archer : BattleUnit, ITakeDamage, IMove
    {
        //constructor from base
        public Archer(int health, int damage,CurrentUnitPossition possition) : base(health, damage, possition)
        {
        }

        //method
        public override void TakeDamage(IBattleUnit damageDealer)
        {
            Console.WriteLine('g');
            base.TakeDamage(damageDealer);
        }
    }
}
