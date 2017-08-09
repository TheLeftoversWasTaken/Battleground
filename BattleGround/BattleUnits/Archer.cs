namespace ProjectBattleGround
{
    public class Archer : BattleUnit, ITakeDamage, IMove
    {
        private const char unitChar = 'A';

        //constructor with default values.
        public Archer(int health = 100, int damage = 20) : base(health, damage)
        { }

        //method
    }
}
