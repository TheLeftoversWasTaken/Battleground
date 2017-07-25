using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround
{
    public class Healer : BattleUnit, ITakeDamage, IMove
    {
        //fields
        private int healingPower = 15;

        //constructor
        public Healer(int health, int damage, CurrentUnitPossition possition) : base(health, damage, possition)
        {
        }

        //properties
        public int HealingPower
        {
            get
            {
                return this.healingPower;
            }
            private set
            {
                this.healingPower = value;
            }
        }
    }
}
