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
            for (int i = 0; i < redPlayer.PlayerArmy.UserArmy.Count; i++)
            {
                int x = redPlayer.PlayerArmy.UserArmy[i].UnitPossition.VerticalPossition;
                int y = redPlayer.PlayerArmy.UserArmy[i].UnitPossition.HorizontalPossition;
                this.battleField[x, y] = redPlayer.PlayerArmy.UserArmy[i].UnitChar;
            }

            for (int i = 0; i < bluePlayer.PlayerArmy.UserArmy.Count; i++)
            {
                int x = bluePlayer.PlayerArmy.UserArmy[i].UnitPossition.VerticalPossition;
                int y = bluePlayer.PlayerArmy.UserArmy[i].UnitPossition.HorizontalPossition;
                this.battleField[x, y] = bluePlayer.PlayerArmy.UserArmy[i].UnitChar;
            }
        }
    }
}
