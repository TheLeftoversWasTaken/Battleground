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
            Console.Clear();
            IUser redUser = CreatePlayer("RED PLAYER");
            Console.Clear();
            IUser blueUser = CreatePlayer("BLUE PLAYER");
            IPlayer redPlayer = new RedPlayer(redUser);
            IPlayer bluePlayer = new BluePlayer(blueUser);
            BattleField battleField = new BattleField(redPlayer, bluePlayer);
            Console.Clear();
            CurrentInterface.SelectBattleUnit(redPlayer, bluePlayer, battleField, "Red Payer");
            int selectedUnit = ReturnSelectedUnit(redPlayer, bluePlayer, battleField, "Red Payer",redPlayer);
            Console.WriteLine(selectedUnit);


            Console.ReadLine();
        }

        //selects a Unit
        private static int ReturnSelectedUnit(IPlayer redPlayer,IPlayer bluePlayer,BattleField battleField, string userName,IPlayer selectedPlayer)
        {
            string userInput = Console.ReadLine();
            int selectedUnit;
            int.TryParse(userInput,out selectedUnit);
            while ((userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4") && selectedPlayer.PlayerArmy[selectedUnit].Health!=0)
            {
                Console.Clear();
                CurrentInterface.SelectBattleUnit(redPlayer, bluePlayer, battleField,userName, "This is not a unit or the selected unit has no hp");
                userInput = Console.ReadLine();
            }
            return selectedUnit-1;
        }
        
        //checks if an army is dead
        private static bool CheckIfArmyIsDead(IPlayer player)
        {
            bool emtyArmy = true;
            int deadUnits = 0;
            foreach(IBattleUnit unit in player.PlayerArmy)
            {
                if (unit.Health == 0)
                {
                    deadUnits++;
                }
            }
            if (deadUnits == player.PlayerArmy.Count)
            {
                emtyArmy = false;
            }
            return emtyArmy;
        }

        // prints the battlefield 
        private static void PrintGameInterface(BattleField battleField, IPlayer redPlayer, IPlayer bluePlayer)
        {
            battleField = new BattleField(redPlayer, bluePlayer);
            Console.Clear();
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
                Console.Clear();
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
