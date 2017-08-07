namespace ProjectBattleGround
{
    class Knight : BattleUnit, IMove, ITakeDamage
    {
        //constructor with default values.
        public Knight(int health = 200, int damage = 50) : base(health, damage)
        {
        }
    }
}
