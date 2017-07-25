using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround
{
    public struct CurrentUnitPossition
    {
        //constructors
        public CurrentUnitPossition(int horizontalPossition, int diagonalPossition)
        {
            this.HorizontalPossition = horizontalPossition;
            this.DiagonalPossition = diagonalPossition;
        }

        //properties
        public int HorizontalPossition
        {
            get;set;
        }
        public int DiagonalPossition
        {
            get;set;
        }
    }
}
