using ProjectBattleGround.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround.BattleField
{
    public class BattleField
    {
        private char[,] battleField = new char[3, 8];

        public BattleField(IPlayer redPlayer, IPlayer bluePlayer)
        {
            for (int i = 0; i < redPlayer.PlayerArmy.Count; i++)
            {
                int x = redPlayer.PlayerArmy[i].UnitPossition.VerticalPossition;
                int y = redPlayer.PlayerArmy[i].UnitPossition.HorizontalPossition;
                this.battleField[x, y] = redPlayer.PlayerArmy[i].UnitChar;
            }

            for (int i = 0; i < bluePlayer.PlayerArmy.Count; i++)
            {
                int x = bluePlayer.PlayerArmy[i].UnitPossition.VerticalPossition;
                int y = bluePlayer.PlayerArmy[i].UnitPossition.HorizontalPossition;
                this.battleField[x, y] = bluePlayer.PlayerArmy[i].UnitChar;
            }
        }
    }
}
