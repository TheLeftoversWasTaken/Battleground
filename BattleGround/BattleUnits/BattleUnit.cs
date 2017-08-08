﻿using System;

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

        //doesnt do anything yet
        public void Move()
        {

        }

        //this unit receives dmg
        public void TakeDamage(IBattleUnit damageDealer)
        {
            this.Health = this.Health - damageDealer.Damage;
        }

        //this unit takes dmg
        public void Heal(IHealer healerUnit)
        {
            this.health = this.health + healerUnit.HealingPower;
        }

        //returns the health of a unit within n size of spaces
        public string ReturnHealthInANumberOfSpaces(int numberOfSpaces)
        {
            string thisUnitHealth = this.Health.ToString();
            int lenght = thisUnitHealth.Length;
            for (int i = lenght; i < numberOfSpaces; i++)
            {
                thisUnitHealth = " " + thisUnitHealth;
            }
            return thisUnitHealth;
        }


    }
}
