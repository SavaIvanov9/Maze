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
    class Input
    {
        /*
         * Functions
         */
        #region Functions

        public void GetInput(Player player, ConsolePrompt console, Map map)
        {
            ConsoleKeyInfo KeyInput = Console.ReadKey(true);
            if (KeyInput.Key == ConsoleKey.UpArrow)
            {
                player.MovePlayer(player, "UpArrow", map);
            }
            else if (KeyInput.Key == ConsoleKey.DownArrow)
            {
                player.MovePlayer(player, "DownArrow", map);
            }
            else if (KeyInput.Key == ConsoleKey.LeftArrow)
            {
                player.MovePlayer(player, "LeftArrow", map);
            }
            else if (KeyInput.Key == ConsoleKey.RightArrow)
            {
                player.MovePlayer(player, "RightArrow", map);
            }
            else if (KeyInput.Key == ConsoleKey.F1)
            {
                console.ConsolePrmpt(map, player);
            }
        }
        public void MainMenuList(Menu menu, UI ui, ConsolePrompt console, Map map)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            switch(key.Key)
            {
                case ConsoleKey.DownArrow:
                    if (menu.mMenuListSelectedId < ui.mMenuList.Length - 1)
                        menu.mMenuListSelectedId++;
                    else
                        menu.mMenuListSelectedId = 0;
                    break;
                case ConsoleKey.UpArrow:
                    if (menu.mMenuListSelectedId > 0)
                        menu.mMenuListSelectedId--;
                    else
                        menu.mMenuListSelectedId = ui.mMenuList.Length - 1;
                    break;
                case ConsoleKey.LeftArrow:

                    break;
                case ConsoleKey.RightArrow:

                    break;
                case ConsoleKey.Enter:
                    switch(menu.mMenuListSelectedId)
                    {
                        case 0:
                            menu.exitMenu = true;
                            break;
                        case 1:
                            // Load game
                            break;
                        case 2:
                            // Credits
                            break;
                        case 3:
                            Environment.Exit(1);
                            break;
                    }
                    break;
                case ConsoleKey.F1:
                    console.ConsolePrmpt(map, null);
                    break;
            }
        }

        #endregion
    }
}
