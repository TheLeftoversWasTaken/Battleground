using System;

namespace ProjectBattleGround
{
    public abstract class BattleUnit : IBattleUnit
    {
        //fields
        private int health;
        private int damage;

        //constructor
        public BattleUnit(int health, int damage)
        {
            this.Health = health;
            this.Damage = damage;
        }

        //properties
        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value;
            }
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }
            private set
            {
                this.damage = value;
            }
        }

        //methods
        public virtual void Move()
        {

        }

        public virtual void TakeDamage(IBattleUnit damageDealer)
        {
            this.Health = this.Health - damageDealer.Damage;
        }

        public virtual void Heal(IHealer healerUnit)
        {
            this.health = this.health + healerUnit.HealingPower;
        }

    }
}
