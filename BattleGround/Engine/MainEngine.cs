using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectBattleGround.UserFolder;
using ProjectBattleGround.UserFolder.UserContracts;
using ProjectBattleGround.UserInterfaceBuilder;

namespace ProjectBattleGround.Engine
{
    public static class MainEngine
    {
        public static void StartGame()
        {
            CurrentInterface.BuildStartScreen();
            Console.ReadLine();
            Console.Clear();
            CurrentInterface.ChooseARace("RED PLAYER ");
            IUser redUser= CreatePlayer("RED PLAYER");
            Console.WriteLine(redUser.UserRace);
        }
        public static IUser CreatePlayer(string playerName)
        {
            string userInput = Console.ReadLine();
            while(userInput!="1" && userInput != "2" && userInput != "3" && userInput != "4")
            {
                Console.Clear();
                CurrentInterface.ChooseARace(playerName, true);
                userInput=Console.ReadLine();
            }
            return null;
        }
    }
}
