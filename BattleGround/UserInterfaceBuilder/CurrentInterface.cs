using System;
using ProjectBattleGround.UserFolder.UserContracts;


namespace ProjectBattleGround.UserInterfaceBuilder
{
    public class CurrentInterface
    {
        // writes a big a** game on the console.
        public static void GameNameGraphics()
        {
            string buildGameNameGraphic = String.Format(@"         GGGGGGGGGGGGG                    AAAAAAAAA              MMMMMMMM           MMMMMMMM          EEEEEEEEEEEEEE
       GGGGGGGGGGGGGGGGG                AAAAAAAAAAAAA            MMMMMMMMM         MMMMMMMMM          EEEEEEEEEEEEEE
      GGGGG        GGGGG               AAAAA     AAAAA           MMMMMMMMMM       MMMMMMMMMM          EEEEE
      GGGGG                           AAAAA       AAAAA          MMMMM  MMMM     MMMM  MMMMM          EEEEEEEEEEEEEE
      GGGGG     GGGGGGG              AAAAAAAAAAAAAAAAAAA         MMMMM   MMMMMMMMMMM   MMMMM          EEEEEEEEEEEEEE
      GGGGG         GGGG            AAAAAAAAAAAAAAAAAAAAA        MMMMM     MMMMMMM     MMMMM          EEEEE
       GGGGGGGGGGGGGGGGG           AAAAA             AAAAA       MMMMM      MMMMM      MMMMM          EEEEEEEEEEEEEE
         GGGGGGGGGGGGG            AAAAAA             AAAAAA      MMMMM       MMM       MMMMM          EEEEEEEEEEEEEE");
            Console.Write(buildGameNameGraphic);
        }

        //creates the start screen using GameNameGraphics
        public static void BuildStartScreen()
        {
            CurrentInterface.GameNameGraphics();
            string buildStartScreen = String.Format(@"








                                                        START GAME");
            Console.Write(buildStartScreen);

        }

        // wrongChoice indicates if there has been a wrong choice from the user if used with true will put a wrong choice indicator on the screen
        public static void ChooseARace(string player,bool wrongChoice=false)
        {
            CurrentInterface.GameNameGraphics();
            string mistakeMesage;
            if (wrongChoice)
            {
                mistakeMesage = "WRONG INPUT";
            }
            else
            {
                mistakeMesage = "";
            }
            string chooseRace = String.Format(@"





       1-ALIEN                          2-CAT                            3-DOGE                       4-GOBLIN

                                                       {0}

                                                 {1} SELECT RACE:",
                                                     mistakeMesage,
                                                     player);
            Console.Write(chooseRace);
        }

        // the uppe user interface with a battle board and a stats window (still has a long way to go. remove this part of note whe done please)
        public static void GameStartScreen(IUser redPlayer,IUser bluePlayer)
        {
            string startScreen = String.Format(@"  ___________________                        	    _______________________________________________________________
 |    RED PLAYER     |                             |1      |2      |3      |4      |5      |6      |7      |8      |
 |    Knight- {1}    |                             |   {0}   |   {0}   |   {0}   |   {0}   |   {0}   |   {0}   |       |       |
 |    Archer- {2}    |                             |_______|_______|_______|_______|_______|_______|_______|_______|
 |    Healer- {3}    |                             |9      |10     |11     |12     |13     |14     |15     |16     |
 |    Mage-   {4}    |                             |       |       |       |       |       |       |       |       |
 |-------------------|                             |_______|_______|_______|_______|_______|_______|_______|_______|
 |    BLUE PLAYER    |                             |17     |18     |19     |20     |21     |22     |23     |24     |
 |    Knight- {5}    |                             |       |       |       |       |       |       |       |       |
 |    Archer- {6}    |                             |_______|_______|_______|_______|_______|_______|_______|_______|
 |    Healer- {7}    |
 |    Mage-   {8}    |
 |___________________|



    _____________________________________________________________________________________________________________",
    " ",
    redPlayer.UserArmy[2].ReturnHealthInANumberOfSpaces(3),
    redPlayer.UserArmy[0].ReturnHealthInANumberOfSpaces(3),
    redPlayer.UserArmy[1].ReturnHealthInANumberOfSpaces(3),
    redPlayer.UserArmy[3].ReturnHealthInANumberOfSpaces(3),
    bluePlayer.UserArmy[2].ReturnHealthInANumberOfSpaces(3),
    bluePlayer.UserArmy[0].ReturnHealthInANumberOfSpaces(3),
    bluePlayer.UserArmy[1].ReturnHealthInANumberOfSpaces(3),
    bluePlayer.UserArmy[3].ReturnHealthInANumberOfSpaces(3)
);
            Console.Write(startScreen);
        }
        
    }
}
