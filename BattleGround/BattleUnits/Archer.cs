﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround
{
    public class Archer : BattleUnit, ITakeDamage, IMove
    {

        //constructor from base
        public Archer(int health = 100, int damage = 20) : base(health, damage)
        { }

        //method
        public override void TakeDamage(IBattleUnit damageDealer)
        {
            base.TakeDamage(damageDealer);
        }

        

    }
}
