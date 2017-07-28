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
            CurrentInterface.GameStartScreen();

           /* CurrentInterface.BuildStartScreen();
            Console.ReadLine();
            Console.Clear();
            CurrentInterface.ChooseARace("RED PLAYER ");
            User redUser= CreatePlayer("RED PLAYER");
            Console.WriteLine(redUser.UserType);
        }
        public static User CreatePlayer(string playerName)
        {
            char userInput = char.Parse(Console.ReadLine());
            while(userInput!='1' && userInput != '2' && userInput != '3' && userInput != '4')
            {
                Console.Clear();
                CurrentInterface.ChooseARace(playerName, true);
                userInput=char.Parse(Console.ReadLine());
            }
            UserType userType;
            Console.WriteLine(userInput);
            switch (userInput)
            {
                case '1':
                    userType = UserType.Alien;
                    break;
                case '2':
                    userType = UserType.Cat;
                    break;
                case '3':
                    userType = UserType.Doge;
                    break;
                default:
                    userType = UserType.Goblin;
                    break;
            }
            User user = new User(userType);
            return user;*/
        }
    }
}
