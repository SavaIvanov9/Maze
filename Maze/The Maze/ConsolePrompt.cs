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
    class ConsolePrompt
    {
        /*
         * Variables
         */
        #region Variables

        string Cmd = "";

        #endregion
        /*
         * Functions
         */
        #region Functions

        public void ConsolePrmpt(Map map, Player player)
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 2);
            Console.Write(@"\>");
            Cmd = Console.ReadLine();
            switch (Cmd)
            {
                case "list campaign":
                    map.ListMaps("campaign");
                    break;
                case "list custom":

                    break;
                case "give cash":
                    player.PlayerScore += 100;
                    break;
                case "give life":
                    player.PlayerLives++;
                    break;
            }
            Console.Clear();
        }

        #endregion
    }
}
