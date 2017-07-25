using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentUnitPossition something = new CurrentUnitPossition(5, 5);
            Archer archer = new Archer(15,13,something);
            Console.WriteLine(archer.Health);
            Archer archer2 = new Archer(14, 2, something);
            archer.TakeDamage(archer2);
            Console.WriteLine(archer.Health);
            archer2.TakeDamage(archer);
            Healer healer = new Healer(10, 10, something);
            archer.Heal(healer);
            Console.WriteLine(archer.Health);
        }
    }
}
