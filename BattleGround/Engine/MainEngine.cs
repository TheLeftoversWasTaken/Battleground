using ProjectBattleGround.UserFolder;
using ProjectBattleGround.UserFolder.UserContracts;
using ProjectBattleGround.UserInterfaceBuilder;
using System;

namespace ProjectBattleGround.Engine
{
    public static class MainEngine
    {
        //starts the game
        public static void StartGame()
        {
            CurrentInterface.BuildStartScreen();
            Console.ReadLine();
            Console.Clear();
            IUser redUser= CreatePlayer("RED PLAYER");
            Console.Clear();
            IUser blueUser = CreatePlayer("BLUE PLAYER");
            Console.Clear();
            CurrentInterface.GameStartScreen(redUser,blueUser);
            Console.ReadLine();
            redUser.UserArmy[2].TakeDamage(blueUser.UserArmy[2]);
            Console.Clear();
            CurrentInterface.GameStartScreen(redUser, blueUser);
            Console.ReadLine();
        }

        //creates the user that is selected by the player and returns it
        public static IUser CreatePlayer(string outputMessage)
        {
            CurrentInterface.ChooseARace(outputMessage);
            IUser createdUser = ChooseAPlayerType(outputMessage);
            return createdUser;
        }

        //loops until the player chooses a correct type and returns a user form the selected class
        public static IUser ChooseAPlayerType(string playerName)
        {
            string userInput = Console.ReadLine();
            IUser createdUser;
            while(userInput!="1" && userInput != "2" && userInput != "3" && userInput != "4")
            {
                Console.Clear();
                CurrentInterface.ChooseARace(playerName, true);
                userInput=Console.ReadLine();
            }
            switch (userInput)
            {
                case "1":
                    createdUser = new UserAlien();
                    createdUser.BuildUserArmy();
                    break;
                case "2":
                    createdUser = new UserCat();
                    createdUser.BuildUserArmy();
                    break;
                case "3":
                    createdUser = new UserDoge();
                    createdUser.BuildUserArmy();
                    break;
                case "4":
                    createdUser = new UserGoblin();
                    createdUser.BuildUserArmy();
                    break;
                default:
                    throw new Exception("Fatal Error!");
            }
            return createdUser;
        }
    }
}
