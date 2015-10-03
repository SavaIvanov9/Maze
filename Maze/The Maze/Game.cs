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
using System.IO;
using System.Threading;

namespace The_Maze
{
    class Game
    {
        /*
         * Classes
         */
        #region Classes

        static Map map = new Map();
        static Input input = new Input();
        static Player player = new Player();
        static UI ui = new UI();
        static Menu menu = new Menu();
        static ConsolePrompt console = new ConsolePrompt();

        //Thread UI = new Thread(ui.GameUI);

        #endregion
        /*
         * Variables
         */
        #region Variables
        #region Game Variables
        //Critical Game Variables
        public static bool GameOver = false;
        public static int WindowWidth = 100;
        public static int WindowHeight = 100;
        public static int WindowBufferWidth = WindowWidth;
        public static int WindowBufferHeight = WindowHeight;
        public static string PlayerName = "Unnamed";
        private static string SaveFileDir = @"Data\Save\" + PlayerName + ".sav";
        //Other Variables
        public static string WindowTitle = "The Maze";

        #endregion
        #endregion
        /*
         * Main Game Loop
         */
        #region Game Loop

        public void GameLoop()
        {
            Console.Title = WindowTitle;
            WindowInitalize(70, 30, 0, 0);
            menu.MainMenu();
            //Game initalize
            player.PlayerLives = 3;
            map.LoadMap(player, player.PlayerChar);
            Console.Clear();
            ui.Timer.Start();

            while (GameOver == false)
            {
                ui.GameUI(player);
                map.DrawMap(player.PlayerChar);
                input.GetInput(player, console, map);
            }
        }

        #endregion
        /*
         * Game Functions
         */
        #region Functions

        public static bool WindowInitalize(int width, int height, int backBufferWidth, int backBufferHeight)
        {
            WindowWidth = width;
            Console.WindowWidth = WindowWidth;
            WindowHeight = height;
            Console.WindowHeight = WindowHeight;
            if (backBufferWidth == 0 && backBufferHeight == 0)
            {
                WindowBufferWidth = WindowWidth;
                WindowBufferHeight = WindowHeight;
            }
            else
            {
                WindowBufferWidth = backBufferWidth;
                WindowBufferHeight = backBufferHeight;
            }
            Console.SetBufferSize(WindowBufferWidth, WindowBufferHeight);
            return true;
        }

        #endregion
    }
}
