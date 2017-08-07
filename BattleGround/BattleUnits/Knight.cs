namespace ProjectBattleGround
{
    class Knight : BattleUnit, IMove, ITakeDamage
    {
        //constructor from base
        public Knight(int health = 200, int damage = 50) : base(health, damage)
        {
        }
    }
}
