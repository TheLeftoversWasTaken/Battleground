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
            while (GamesContinue(redPlayer, bluePlayer))
            {
                if (redTeamTurn)
                {
                    Console.WriteLine();
                    Console.WriteLine("Red Team turn:");
                    int currentUnit = ChoseUnit();
                    int command = ChoseCommand();
                    if (command == 1)//moving
                    {
                        int currentmove;
                        do
                        {
                            Console.WriteLine("1.Up 2.Right 3.Down 4.Left");
                            currentmove = int.Parse(Console.ReadLine());
                            bool chekForBorderds;
                            bool isEmpty;

                            int vertical;
                            int horizontal;

                            switch (currentmove)
                            {
                                case 1://Up
                                    vertical = redPlayer.PlayerArmy[currentUnit].UnitPossition.VerticalPossition - 1;
                                    horizontal = redPlayer.PlayerArmy[currentUnit].UnitPossition.HorizontalPossition;
                                    break;
                                case 2://Forward
                                    vertical = redPlayer.PlayerArmy[currentUnit].UnitPossition.VerticalPossition;
                                    horizontal = redPlayer.PlayerArmy[currentUnit].UnitPossition.HorizontalPossition + 1;
                                    break;
                                case 3://Down
                                    vertical = redPlayer.PlayerArmy[currentUnit].UnitPossition.VerticalPossition + 1;
                                    horizontal = redPlayer.PlayerArmy[currentUnit].UnitPossition.HorizontalPossition;
                                    break;
                                case 4://left
                                    vertical = redPlayer.PlayerArmy[currentUnit].UnitPossition.VerticalPossition;
                                    horizontal = redPlayer.PlayerArmy[currentUnit].UnitPossition.HorizontalPossition - 1;
                                    break;

                                default:
                                    throw new Exception("Error command!");
                            }
                            chekForBorderds = ChekForBorder(vertical, horizontal);
                            if (chekForBorderds == true)
                            {
                                isEmpty = battleField.IsPossitionEmpty(vertical, horizontal);
                                if (isEmpty == true)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong Command");
                            }
                        } while (true);
                        redPlayer = MoveCommand(redPlayer, currentmove, currentUnit);
                        ConsolePrint(battleField, redPlayer, bluePlayer);

                    }

                    if (command == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Do you want to attack ? (Y/N)");
                        char attackturn = char.Parse(Console.ReadLine());
                        if (attackturn == 'Y')
                        {
                            command = 2;
                        }

                    }//Check for attack after move
                    if (command == 2)
                    {
                        Attack(redPlayer, bluePlayer, currentUnit);
                        ConsolePrint(battleField, redPlayer, bluePlayer);
                    }
                    redTeamTurn = false;
                }
                if (!redTeamTurn)
                {
                    Console.WriteLine();
                    Console.WriteLine("Blue Team turn:");
                    int currentUnit = ChoseUnit();
                    int command = ChoseCommand();
                    if (command == 1)//moving
                    {
                        int currentmove;
                        do
                        {
                            Console.WriteLine("1.Up 2.Right 3.Down 4.Left");
                            currentmove = int.Parse(Console.ReadLine());
                            bool chekForBorderds;
                            bool isEmpty;

                            int vertical;
                            int horizontal;

                            switch (currentmove)
                            {
                                case 1://Up
                                    vertical = bluePlayer.PlayerArmy[currentUnit].UnitPossition.VerticalPossition - 1;
                                    horizontal = bluePlayer.PlayerArmy[currentUnit].UnitPossition.HorizontalPossition;
                                    break;
                                case 2://Forward
                                    vertical = bluePlayer.PlayerArmy[currentUnit].UnitPossition.VerticalPossition;
                                    horizontal = bluePlayer.PlayerArmy[currentUnit].UnitPossition.HorizontalPossition + 1;
                                    break;
                                case 3://Down
                                    vertical = bluePlayer.PlayerArmy[currentUnit].UnitPossition.VerticalPossition + 1;
                                    horizontal = bluePlayer.PlayerArmy[currentUnit].UnitPossition.HorizontalPossition;
                                    break;
                                case 4://left
                                    vertical = bluePlayer.PlayerArmy[currentUnit].UnitPossition.VerticalPossition;
                                    horizontal = bluePlayer.PlayerArmy[currentUnit].UnitPossition.HorizontalPossition - 1;
                                    break;

                                default:
                                    throw new Exception("Error command!");
                            }
                            chekForBorderds = ChekForBorder(vertical, horizontal);
                            if (chekForBorderds == true)
                            {
                                isEmpty = battleField.IsPossitionEmpty(vertical, horizontal);
                                if (isEmpty == true)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong Command");
                            }
                        } while (true);
                        bluePlayer = MoveCommand(bluePlayer, currentmove, currentUnit);
                        ConsolePrint(battleField, bluePlayer, redPlayer);

                        if (command == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Do you want to attack ? (Y/N)");
                            char attackturn = char.Parse(Console.ReadLine());
                            if (attackturn == 'Y')
                            {
                                command = 2;
                            }

                        }//Check for attack after move
                        if (command == 2)
                        {
                            Attack(bluePlayer, redPlayer, currentUnit);
                            ConsolePrint(battleField, bluePlayer, redPlayer);
                        }//Attack
                        redTeamTurn = true;
                    }
                }
            }

            redPlayer.PlayerArmy[2].TakeDamage(bluePlayer.PlayerArmy[0]);//red knight takes dmg from blue archer

            battleField = new BattleField(redPlayer, bluePlayer);
            Console.Clear();
            CurrentInterface.GameStartScreen(redPlayer, bluePlayer, battleField);
            Console.ReadLine();
            //------
        }

        private static void Attack(IPlayer redplayer, IPlayer blueplayer, int currentunit)
        {
            if (currentunit == 1)
            {
                Console.WriteLine("Do you want to heal? (Y/N)");
                char x = char.Parse(Console.ReadLine());
                if (x == 'Y')
                {
                    Heal(redplayer);
                }
            }
            else
            {
                Console.WriteLine("Choose unit you want to attack: 1.Archer 2.Healer 3.Knight 4.Magician");
                int attackedunit = int.Parse(Console.ReadLine()) - 1;
                blueplayer.PlayerArmy[attackedunit].TakeDamage(redplayer.PlayerArmy[currentunit]);
            }

        }

        private static void Heal(IPlayer redplayer)
        {
            Console.WriteLine("Choose ally that you want to heal:  1.Archer 2.Healer 3.Knight 4.Magician");
            int x = int.Parse(Console.ReadLine()) - 1;
            redplayer.PlayerArmy[x].Heal(redplayer.PlayerArmy[1] as Healer); // blue magician is healed by blue healer

        }


        private static bool ChekForBorder(int vertical, int horizontal)
        {

            if (vertical < 0 || vertical > 2 || horizontal > 7 || horizontal < 0)
            {
                Console.WriteLine("Out of Border !!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private static int ChoseCommand()
        {
            int x;
            do
            {
                Console.WriteLine("1.Move");
                Console.WriteLine("2.Attack");
                x = int.Parse(Console.ReadLine());
                if (x < 3 && x > 0)
                {
                    return x;

                }
                else
                {
                    Console.WriteLine("Invalid Command !");
                }

            } while (true);
        }

        //Chose the unit for this turn
        private static int ChoseUnit()
        {
            int x;
            do
            {
                Console.WriteLine("Choose your unit: 1.Archer 2.Healer 3.Knight 4.Magician");
                x = int.Parse(Console.ReadLine());
            } while (x > 4 && x < 0);
            return x - 1;
        }

        //Check  2 players are alive
        private static bool GamesContinue(IPlayer redPlayer, IPlayer bluePlayer)
        {
            //Cheking is Red team still alive
            if (redPlayer.PlayerArmy[0].Health == 0 &&
                redPlayer.PlayerArmy[1].Health == 0 &&
                redPlayer.PlayerArmy[2].Health == 0 &&
                redPlayer.PlayerArmy[3].Health == 0)
            {
                Console.WriteLine("Congratulations !!!");
                Console.WriteLine("Blue Team Wins !!!");
                return false;
            }
            //Checking is Blue team still alive
            if (bluePlayer.PlayerArmy[0].Health == 0 &&
               bluePlayer.PlayerArmy[1].Health == 0 &&
               bluePlayer.PlayerArmy[2].Health == 0 &&
               bluePlayer.PlayerArmy[3].Health == 0)
            {
                Console.WriteLine("Congratulations !!!");
                Console.WriteLine("Red Team Wins !!!");
                return false;
            }
            return true;
        }

        //Reprint the console
        public static void ConsolePrint(BattleField battleField, IPlayer redPlayer, IPlayer bluePlayer)
        {
            battleField = new BattleField(redPlayer, bluePlayer);
            Console.Clear();
            CurrentInterface.GameStartScreen(redPlayer, bluePlayer, battleField);
        }

        public static IPlayer MoveCommand(IPlayer player, int currentMoving, int unit)
        {
            int newPosition;
            switch (currentMoving)
            {
                case 1://Up
                    newPosition = player.PlayerArmy[unit].UnitPossition.VerticalPossition - 1;
                    player.PlayerArmy[unit].CurrentPossition(newPosition, player.PlayerArmy[unit].UnitPossition.HorizontalPossition);
                    return player;
                case 2://Forward
                    newPosition = player.PlayerArmy[unit].UnitPossition.HorizontalPossition + 1;
                    player.PlayerArmy[unit].CurrentPossition(player.PlayerArmy[unit].UnitPossition.VerticalPossition, newPosition);
                    return player;
                case 3://Down
                    newPosition = player.PlayerArmy[unit].UnitPossition.VerticalPossition + 1;
                    player.PlayerArmy[unit].CurrentPossition(newPosition, player.PlayerArmy[unit].UnitPossition.HorizontalPossition);
                    return player;
                case 4://left
                    newPosition = player.PlayerArmy[unit].UnitPossition.HorizontalPossition - 1;
                    player.PlayerArmy[unit].CurrentPossition(player.PlayerArmy[unit].UnitPossition.VerticalPossition, newPosition);
                    return player;
                default:
                    throw new Exception("Error command!");
            }
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
