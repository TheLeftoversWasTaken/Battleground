using System;
using ProjectBattleGround.BattleField;
using ProjectBattleGround.Players.Contracts;



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
        public static void GameStartScreen(IPlayer redPlayer,IPlayer bluePlayer)
        {
            string startScreen = String.Format(@"  ____________________                        	 ___1_______2_______3_______4_______5_______6_______7_______8___
 |     RED PLAYER     |                         |       |       |       |       |       |       |       |       |
 | Knight-{0}HP/{9}DMG |                        A|   {8}   |   {8}   |   {8}   |   {8}   |   {8}   |   {8}   |       |       |
 | Archer-{1}HP/{10}DMG |                         |_______|_______|_______|_______|_______|_______|_______|_______|
 | Healer-{2}HP/{11}DMG |                         |       |       |       |       |       |       |       |       |
 | Mage  -{3}HP/{12}DMG |                        B|       |       |       |       |       |       |       |       |
 |--------------------|                         |_______|_______|_______|_______|_______|_______|_______|_______|
 |     BLUE PLAYER    |                         |       |       |       |       |       |       |       |       |
 | Knight-{4}HP/{13}DMG |                        C|       |       |       |       |       |       |       |       |
 | Archer-{5}HP/{14}DMG |                         |_______|_______|_______|_______|_______|_______|_______|_______|
 | Healer-{6}HP/{15}DMG |
 | Mage  -{7}HP/{16}DMG |
 |____________________|



    _____________________________________________________________________________________________________________",
    redPlayer.PlayerArmy.UserArmy[2].ReturnHealthInANumberOfSpaces(3),
    redPlayer.PlayerArmy.UserArmy[0].ReturnHealthInANumberOfSpaces(3),
    redPlayer.PlayerArmy.UserArmy[1].ReturnHealthInANumberOfSpaces(3),
    redPlayer.PlayerArmy.UserArmy[3].ReturnHealthInANumberOfSpaces(3),
    bluePlayer.PlayerArmy.UserArmy[2].ReturnHealthInANumberOfSpaces(3),
    bluePlayer.PlayerArmy.UserArmy[0].ReturnHealthInANumberOfSpaces(3),
    bluePlayer.PlayerArmy.UserArmy[1].ReturnHealthInANumberOfSpaces(3),
    bluePlayer.PlayerArmy.UserArmy[3].ReturnHealthInANumberOfSpaces(3),
    " ",
    redPlayer.PlayerArmy.UserArmy[2].ReturnDamagePointsInANumberOfSpaces(2),
    redPlayer.PlayerArmy.UserArmy[0].ReturnDamagePointsInANumberOfSpaces(2),
    redPlayer.PlayerArmy.UserArmy[1].ReturnDamagePointsInANumberOfSpaces(2),
    redPlayer.PlayerArmy.UserArmy[3].ReturnDamagePointsInANumberOfSpaces(2),
    bluePlayer.PlayerArmy.UserArmy[2].ReturnDamagePointsInANumberOfSpaces(2),
    bluePlayer.PlayerArmy.UserArmy[0].ReturnDamagePointsInANumberOfSpaces(2),
    bluePlayer.PlayerArmy.UserArmy[1].ReturnDamagePointsInANumberOfSpaces(2),
    bluePlayer.PlayerArmy.UserArmy[3].ReturnDamagePointsInANumberOfSpaces(2)
);
            Console.Write(startScreen);
        }
        

    }
}
