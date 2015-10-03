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
using System.Windows.Forms;

namespace The_Maze
{
    class Player
    {
        /*
         * Variables
         */
        #region Variables

        public char PlayerChar = '@';
        public int PlayerScore = 0;
        public int PlayerHealth = 0;
        public int PlayerLives = -1;//-1 = unlimited
        public int PlayerX = 0;
        public int PlayerY = 0;
        private string LastKeyPress = "";

        #endregion
        /*
         * Functions
         */
        #region Functions

        public void MovePlayer(Player player, string key, Map map)
        {
            switch (key)
            {
                case "UpArrow":
                    if (map.MapChar[PlayerY - 1, PlayerX] != map.WallChar)
                    {
                        if (LastKeyPress == "DownArrow")
                        {
                            map.MapChar[PlayerY, PlayerX] = ' ';
                            map.MapChar[PlayerY - 1, PlayerX] = PlayerChar;
                            PlayerY -= 2;
                        }
                        else
                        {
                            map.MapChar[PlayerY, PlayerX] = ' ';
                            map.MapChar[PlayerY - 1, PlayerX] = PlayerChar;
                            PlayerY--;
                        }
                        LastKeyPress = "UpArrow";
                    }
                    break;
                case "DownArrow":
                    if (map.MapChar[PlayerY + 1, PlayerX] != map.WallChar)
                    {
                        if (LastKeyPress == "UpArrow")
                        {
                            map.MapChar[PlayerY, PlayerX] = ' ';
                            map.MapChar[PlayerY + 1, PlayerX] = PlayerChar;
                            PlayerY++;
                        }
                        else
                        {
                            map.MapChar[PlayerY, PlayerX] = ' ';
                            map.MapChar[PlayerY + 1, PlayerX] = PlayerChar;
                            PlayerY++;
                        }
                        LastKeyPress = "DownArrow";
                    }
                    break;
                case "LeftArrow":
                    if (map.MapChar[PlayerY, PlayerX - 1] != map.WallChar)
                    {
                        if (LastKeyPress == "RightArrow")
                        {
                            map.MapChar[PlayerY, PlayerX] = ' ';
                            map.MapChar[PlayerY, PlayerX - 1] = PlayerChar;
                            PlayerX -= 2;
                        }
                        else
                        {
                            map.MapChar[PlayerY, PlayerX] = ' ';
                            map.MapChar[PlayerY, PlayerX - 1] = PlayerChar;
                            PlayerX--;
                        }
                        LastKeyPress = "LeftArrow";
                    }
                    break;
                case "RightArrow":
                    if (map.MapChar[PlayerY, PlayerX + 1] != map.WallChar)
                    {
                        if (LastKeyPress == "LeftArrow")
                        {
                            map.MapChar[PlayerY, PlayerX + 1] = ' ';
                            map.MapChar[PlayerY, PlayerX + 2] = PlayerChar;
                            PlayerX += 2;
                        }
                        else
                        {
                            map.MapChar[PlayerY, PlayerX] = ' ';
                            map.MapChar[PlayerY, PlayerX + 1] = PlayerChar;
                            PlayerX++;
                        }
                        LastKeyPress = "RightArrow";
                    }
                    break;
            }

            if (PlayerX == map.ExitX && PlayerY == map.ExitY)
            {
                Console.Beep(3000, 50);
                Console.Beep(2500, 50);
                Console.Beep(3000, 50);
                Console.Beep(2000, 50);
                Console.Beep(3000, 50);
                Console.Beep(1500, 50);
                map.MapNo++;
                if (map.MapNo == 4)
                {
                    MessageBox.Show("That is the end!", "The Maze", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(1);
                }
                Console.Clear();
                Array.Clear(map.MapChar, 0, map.MapChar.Length);
                map.LoadMap(player, player.PlayerChar);
            }
            else if (map.LifeObjects[PlayerY, PlayerX] == map.LifeChar)
            {
                PlayerLives += map.LifeValue;
                map.LifeObjects[PlayerY, PlayerX] = ' ';
                Console.Beep(2000, 50);
                Console.Beep(3000, 50);
            }
            else if (map.CashObjects[PlayerY, PlayerX] == map.CashChar)
            {
                PlayerScore += map.CashValue;
                map.CashObjects[PlayerY, PlayerX] = ' ';
                Console.Beep(2000, 50);
                Console.Beep(3000, 50);
            }
        }

        #endregion
    }
}
