using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround
{
    public class Healer : BattleUnit, IHealer
    {
        //fields
        private int healingPower;

        //constructor
        public Healer(int health, int damage, CurrentUnitPossition possition,int healingPower) : base(health, damage, possition)
        {
            this.HealingPower = healingPower;
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
