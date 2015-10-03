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

namespace The_Maze
{
    class Menu
    {
        /*
         * Classes
         */
        #region Classes

        UI ui = new UI();
        Game game = new Game();
        Input input = new Input();
        ConsolePrompt console = new ConsolePrompt();
        Map map = new Map();

        #endregion
        /*
         * Variables
         */
        #region Variables

        public bool exitMenu = false;
        //Main Menu List
        public int mMenuListSelectedId = 0;

        #endregion
        /*
         * Functions
         */
        #region Functions

        public void MainMenu()
        {
            while (exitMenu == false)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("The Maze");
                ui.MainMenuList(mMenuListSelectedId);
                input.MainMenuList(this, ui, console, map);
            }
        }

        #endregion
    }
}
