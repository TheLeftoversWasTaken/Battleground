using ProjectBattleGround.UserFolder;
using ProjectBattleGround.UserFolder.UserContracts;
using ProjectBattleGround.UserInterfaceBuilder;
using System;
using ProjectBattleGround.Players.Contracts;
using ProjectBattleGround.Players;
using ProjectBattleGround.BattleFieldGenerator;

namespace ProjectBattleGround.Engine
{
    public static class MainEngine
    {
        //starts the game
        public static void StartGame()
        {
            CurrentInterface.BuildStartScreen();
            Console.ReadLine();
            IPlayer redPlayer = new RedPlayer(CreatePlayer("RED PLAYER"));
            IPlayer bluePlayer = new BluePlayer(CreatePlayer("BLUE PLAYER"));
            BattleField battleField = new BattleField(redPlayer, bluePlayer);
            CurrentInterface.SelectBattleUnit(redPlayer, bluePlayer, battleField, "Red Player");
            int selectedUnit = ReturnSelectedUnit(redPlayer, bluePlayer, battleField, "Red Player",redPlayer);

        }
        //selects a Unit and these methods take a lot of arguments cuz they use the gameStartScreen interface and it takes 3 arguments on its own
        private static int ReturnSelectedUnit(IPlayer redPlayer, IPlayer bluePlayer, BattleField battleField, string userName, IPlayer selectedPlayer)
        {
            string userInput = Console.ReadLine();
            int selectedUnit;
            int.TryParse(userInput, out selectedUnit);
            while (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4")
            {
                CurrentInterface.SelectBattleUnit(redPlayer, bluePlayer, battleField, userName, "This is not a Unit");
                userInput = Console.ReadLine();
                int.TryParse(userInput, out selectedUnit);
            }
            selectedUnit = selectedUnit - 1;
            if (selectedPlayer.PlayerArmy[selectedUnit].Health==0)
            {
                CurrentInterface.SelectBattleUnit(redPlayer, bluePlayer, battleField, userName, "This Unit has no HP");
                selectedUnit = ReturnSelectedUnit(redPlayer, bluePlayer, battleField, userName, selectedPlayer);
            }
            return selectedUnit;
        }
        
        // prints the battlefield 
        private static void PrintGameInterface(BattleField battleField, IPlayer redPlayer, IPlayer bluePlayer)
        {
            battleField = new BattleField(redPlayer, bluePlayer);
            CurrentInterface.GameStartScreen(redPlayer, bluePlayer, battleField);
            Console.ReadLine();
        }

        //creates the user that is selected by the player and returns it
        private static IUser CreatePlayer(string outputMessage)
        {
            CurrentInterface.ChooseARace(outputMessage);
            IUser createdUser = ChooseAPlayerType(outputMessage);
            return createdUser;
        }

        //loops until the player chooses a correct type and returns a user form the selected class
        private static IUser ChooseAPlayerType(string playerName)
        {
            string userInput = Console.ReadLine();
            IUser createdUser;
            while (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4")
            {
                CurrentInterface.ChooseARace(playerName, true);
                userInput = Console.ReadLine();
            }
            switch (userInput)
            {
                case "1":
                    createdUser = new UserAlien();
                    break;
                case "2":
                    createdUser = new UserCat();
                    break;
                case "3":
                    createdUser = new UserDoge();
                    break;
                case "4":
                    createdUser = new UserGoblin();
                    break;
                default:
                    throw new Exception("Fatal Error!");
            }
            return createdUser;
        }
    }
}
