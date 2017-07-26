using System;

namespace ProjectBattleGround
{
    public abstract class BattleUnit:IBattleUnit
    {
        //fields
        private int health;
        private int damage;
        private CurrentUnitPossition possition;

        //constructor
        public BattleUnit(int health,int damage, CurrentUnitPossition possition)
        {
            this.Health = health;
            this.Damage = damage;
            this.Possition = possition;
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
        public CurrentUnitPossition Possition
        {
            get
            {
                return this.possition;
            }
            set
            {
                this.possition = value;
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
