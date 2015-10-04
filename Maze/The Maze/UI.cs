/*
 * ********************************************
 * The Maze- A 2D console maze game in C#!
 * ********************************************
 * Created By: Antony Lloyd
 * http://only-antony.com
 * 
 * If any of this code is used, please give credit!
 * 
 * THIS CODE IS NOT YET COMPLETE AND IT IS BUGGY. FOR A LIST OF BUGS VISIT https://bitbucket.org/OnlyAntony/the-maze
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace The_Maze
{
    class UI
    {
        /*
         * Classes
         */

        /*
         * Variables
         */
        #region Variables

        //Main Menu List
        public string[] mMenuList = new string[]
        {
            "New Game", "Load Game", "Credits", "Exit"
        };

        #endregion

        static Timer timer = new Timer();

        public Thread Timer = new Thread(timer.ReduceTime);
        /*
         * Functions
         */
        #region Functions

        public void GameUI(Player player)
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Cash:    |   Lives: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(6, 0);
            Console.Write("£{0}", player.PlayerScore);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(20, 0);
            Console.Write("♥{0}", player.PlayerLives);
            Console.SetCursorPosition(30, 0);
            Console.Write("Time: {0}", timer.Time);
        }
        public void MainMenuList(int selectedID)
        {
           for(int i = 0; i < mMenuList.Length; i++)
           {
               if(i == selectedID)
               {
                   Console.ForegroundColor = ConsoleColor.Yellow;
               }
               else
               {
                   Console.ForegroundColor = ConsoleColor.Cyan;
               }
               Console.SetCursorPosition(0, 4 + i);
               Console.WriteLine(mMenuList[i]);
           }
           Console.SetCursorPosition(0, Console.WindowHeight-1);
           Console.ForegroundColor = ConsoleColor.DarkGray;
           Console.Write("The Maze - game recasted by team Jeandan!");
        }

        #endregion
    }
}
