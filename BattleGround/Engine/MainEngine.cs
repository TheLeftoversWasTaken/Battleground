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
            CurrentInterface.GameStartScreen(redPlayer, bluePlayer, battleField);
            //Console.ReadLine();
            // testing if stuff changes-----
            bool redTeamTurn = true;
            while (true)
            {
                //Cheking is Red team still alive
                if (redPlayer.PlayerArmy[0].Health == 0 &&
                    redPlayer.PlayerArmy[1].Health == 0 &&
                    redPlayer.PlayerArmy[2].Health == 0 &&
                    redPlayer.PlayerArmy[3].Health == 0)
                {
                    Console.WriteLine("Congratulations !!!");
                    Console.WriteLine("Blue Team Wins !!!");
                    break;
                }
                //Checking is Blue team still alive
                if (bluePlayer.PlayerArmy[0].Health == 0 &&
                   bluePlayer.PlayerArmy[1].Health == 0 &&
                   bluePlayer.PlayerArmy[2].Health == 0 &&
                   bluePlayer.PlayerArmy[3].Health == 0)
                {
                    Console.WriteLine("Congratulations !!!");
                    Console.WriteLine("Red Team Wins !!!");
                    break;
                }
                if (redTeamTurn)
                {
                    Console.WriteLine();
                    Console.WriteLine("Red Team turn:");
                    Console.WriteLine("Choose your unit: 1.Archer 2.Healer 3.Knight 4.Magician");
                    int currentUnit = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("1.Move");
                    Console.WriteLine("2.Attack");
                    string command = Console.ReadLine();
                    if (command == "1")//moving
                    {
                        bool upIsEmpty = battleField.IsPossitionEmpty(redPlayer.PlayerArmy[currentUnit].UnitPossition.VerticalPossition + 1, redPlayer.PlayerArmy[currentUnit].UnitPossition.HorizontalPossition, redPlayer, bluePlayer);
                        bool forwardIsEmpty = battleField.IsPossitionEmpty(redPlayer.PlayerArmy[currentUnit].UnitPossition.VerticalPossition, redPlayer.PlayerArmy[currentUnit].UnitPossition.HorizontalPossition + 1, redPlayer, bluePlayer);
                        bool downIsEmpty = battleField.IsPossitionEmpty(redPlayer.PlayerArmy[currentUnit].UnitPossition.VerticalPossition - 1, redPlayer.PlayerArmy[currentUnit].UnitPossition.HorizontalPossition, redPlayer, bluePlayer);
                        if (redPlayer.PlayerArmy[currentUnit].UnitPossition.VerticalPossition <= 1 || !upIsEmpty)
                        {

                            Console.WriteLine("You can`t move up,because it`s out of the board or the field is not empty.");
                        }
                        else
                        {
                            Console.WriteLine("1.Up");
                        }
                        if (redPlayer.PlayerArmy[currentUnit].UnitPossition.HorizontalPossition <= 8 || !forwardIsEmpty)
                        {
                            Console.WriteLine("You can`t move forward,because it`s out of the board or the field is not empty.");
                        }
                        else
                        {
                             Console.WriteLine("2.Forward");
                        }
                        
                        Console.WriteLine("3.Down");
                        int currentmoving = int.Parse(Console.ReadLine());
                        if (currentmoving == 1)
                        {
                            int newPosition = redPlayer.PlayerArmy[currentUnit].UnitPossition.VerticalPossition + 1;
                            redPlayer.PlayerArmy[currentUnit].CurrentPossition(newPosition, redPlayer.PlayerArmy[currentUnit].UnitPossition.HorizontalPossition);
                            ConsolePrint(battleField, redPlayer, bluePlayer);
                        }//up
                        if (currentmoving == 2)
                        {
                            int newPosition = redPlayer.PlayerArmy[currentUnit].UnitPossition.HorizontalPossition + 1;
                            redPlayer.PlayerArmy[currentUnit].CurrentPossition(redPlayer.PlayerArmy[currentUnit].UnitPossition.VerticalPossition, newPosition);
                            ConsolePrint(battleField, redPlayer, bluePlayer);
                        }//forward
                        if (currentmoving == 3)
                        {
                            int newPosition = redPlayer.PlayerArmy[currentUnit].UnitPossition.VerticalPossition - 1;
                            redPlayer.PlayerArmy[currentUnit].CurrentPossition(newPosition, redPlayer.PlayerArmy[currentUnit].UnitPossition.HorizontalPossition);
                            ConsolePrint(battleField, redPlayer, bluePlayer);
                        }//down
                    }

                    if (command == "1")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Do you want to attack ? (Y/N)");
                        char attackturn = char.Parse(Console.ReadLine());


                    }
                    redTeamTurn = false;
                }
                if (!redTeamTurn)//Blue team turn
                {
                    Console.WriteLine("Blue Team turn:");


                    redTeamTurn = true;
                }
            }
            redPlayer.PlayerArmy[2].CurrentPossition(1, 3);//moving
            bluePlayer.PlayerArmy[0].CurrentPossition(0, 5);//moving
            redPlayer.PlayerArmy[2].TakeDamage(bluePlayer.PlayerArmy[0]);//red knight takes dmg from blue archer
            bluePlayer.PlayerArmy[3].Heal(bluePlayer.PlayerArmy[1] as Healer); // blue magician is healed by blue healer
            battleField = new BattleField(redPlayer, bluePlayer);
            Console.Clear();
            CurrentInterface.GameStartScreen(redPlayer, bluePlayer, battleField);
            Console.ReadLine();
            //------
        }
        public static void ConsolePrint(BattleField battleField, IPlayer redPlayer, IPlayer bluePlayer)
        {
            battleField = new BattleField(redPlayer, bluePlayer);
            Console.Clear();
            CurrentInterface.GameStartScreen(redPlayer, bluePlayer, battleField);
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
