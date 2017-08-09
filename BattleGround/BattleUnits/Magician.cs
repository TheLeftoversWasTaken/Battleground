namespace ProjectBattleGround
{
    class Magician : BattleUnit, ITakeDamage, IMove
    {
        private const char unitChar = 'M';
        //constructor with default values.
        public Magician(int health = 80, int damage = 30) : base(health, damage)
        {
        }
    }
}
