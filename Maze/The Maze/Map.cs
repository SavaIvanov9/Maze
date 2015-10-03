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
using System.Windows.Forms;

namespace The_Maze
{
    class Map
    {
        /*
         * Variables
         */
        #region Variables

        public int MapNo = 1;
        public char[,] MapChar;
        private char CurrentReadChar;
        private char CharToDraw;
        public char ExitChar = '%';
        public char CashChar = '£';
        public char LifeChar = '♥';
        public char WallChar = '#';
        public char[,] LifeObjects;
        public char[,] CashObjects;
        public string[] MapValues;
        private string[] MapList;
        private string MapListCmd;
        public int ExitX = 0;
        public int ExitY = 0;
        public int LifeValue = 1;
        public int CashValue = 5;
        private int MapX = 5;
        private int MapY = 5;

        #endregion
        /* 
         * Functions
         */
        #region Functions
        /*
         * Load Map
         */
        public void LoadMap(Player player, char PlayerChar)
        {
            StreamReader fileLoader = new StreamReader(@"Data\Maps\Campaign\cmap" + MapNo + ".map");
            int lineCount = File.ReadAllLines(@"Data\Maps\Campaign\cmap" + MapNo + ".map").Length;
            int colsCount = fileLoader.ReadLine().Length;
            MapChar = new char[lineCount, colsCount];
            LifeObjects = new char[lineCount, colsCount];
            CashObjects = new char[lineCount, colsCount];
            //Load file to array
            MapValues = File.ReadAllLines(@"Data\Maps\Campaign\cmap" + MapNo + ".map");
            //Check Characters
            for (int row = 0; row < MapChar.GetUpperBound(0) + 1; row++)
            {
                for (int coll = 0; coll < MapChar.GetUpperBound(1) + 1; coll++)
                {
                    CurrentReadChar = MapValues[row][coll];
                    switch (CurrentReadChar)//1 = wall, P = player, F = finish, L = life, C = cash
                    {
                        case '1':
                            MapChar[row, coll] = WallChar;
                            break;
                        case 'P':
                            MapChar[row, coll] = PlayerChar;
                            player.PlayerX = coll;
                            player.PlayerY = row;
                            break;
                        case 'F':
                            MapChar[row, coll] = ExitChar;
                            ExitX = coll;
                            ExitY = row;
                            break;
                        case 'L':
                            MapChar[row, coll] = LifeChar;
                            LifeObjects[row, coll] = LifeChar;
                            break;
                        case 'C':
                            MapChar[row, coll] = CashChar;
                            CashObjects[row, coll] = CashChar;
                            break;
                    }
                }
            } 
        }
        /*
         * Draw Map
         */
        public void DrawMap(char PlayerChar)
        {
            for (int row = 0; row < MapChar.GetUpperBound(0) + 1; row++)
            {
                for (int coll = 0; coll < MapChar.GetUpperBound(1) + 1; coll++)
                {
                    //Console.SetCursorPosition(Console.WindowWidth / 2 - MapChar.GetUpperBound(0)+coll, Console.WindowHeight /2 - MapChar.GetUpperBound(1)+row);
                    Console.SetCursorPosition(MapX + coll, MapY + row);
                    CharToDraw = MapChar[row, coll];
                    if (CharToDraw == PlayerChar)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else if(CharToDraw == WallChar)
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    else if (CharToDraw == ExitChar)
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    else if (CharToDraw == LifeChar)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else if (CharToDraw == CashChar)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(CharToDraw);
                }
                Console.WriteLine();
            }
        }
        /*
         * List Maps
         */
        public void ListMaps(string type)
        {
            if (type == "campaign")
            {
                Console.Clear();
                MapList = Directory.GetFiles(@"Data\Maps\Campaign\");
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < MapList.Length; i++)
                {
                    Console.WriteLine(MapList[i]);
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Map to load (number) or 'exit'");
                MapListCmd = Console.ReadLine();
                if (MapListCmd != "exit")
                {
                    try
                    {
                        MapNo = int.Parse(MapListCmd);
                    }
                    catch {}
                }
            }
        }

        #endregion
    }
}
