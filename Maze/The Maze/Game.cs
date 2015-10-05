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


            //Console.WriteLine(@"You have code (string something = 2 + 3 + ""word"" ;). What console will be print!");
            //Console.WriteLine("1. 7word");
            //Console.WriteLine("2. 23word");
            //Console.WriteLine("3. 2 + 3 + word");
            //Console.Write("Enter your choice: ");
            //int firstChoice = int.Parse(Console.ReadLine());

            //switch (firstChoice)
            //{
            //    case 1:
            //        Console.WriteLine("Correct! Right is your way");
            //        break;
            //    case 2:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    case 3:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    default:
            //        Console.WriteLine("Error! Please try again");
            //        break;
            //}

            //Console.WriteLine("What is string?");
            //Console.WriteLine("1. This is ring street");
            //Console.WriteLine("2. Array of chars");
            //Console.WriteLine("3. Method in C#");
            //Console.Write("Enter your choice: ");
            //int secondChoice = int.Parse(Console.ReadLine());

            //switch (secondChoice)
            //{
            //    case 1:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    case 2:
            //        Console.WriteLine("Correct! Right is your way");
            //        break;
            //    case 3:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    default:
            //        Console.WriteLine("Error! Please try again");
            //        break;
            //}

            //Console.WriteLine("What is diference between Array and List Methods?");
            //Console.WriteLine("1. They don't have diference");
            //Console.WriteLine("2. Array have resizable holds, List have fix holds");
            //Console.WriteLine("3. List have resizable holds, Array have fix holds");
            //Console.Write("Enter your choice: ");
            //int thirdChoice = int.Parse(Console.ReadLine());

            //switch (thirdChoice)
            //{
            //    case 1:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    case 2:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    case 3:
            //        Console.WriteLine("Correct! Right is your way");
            //        break;
            //    default:
            //        Console.WriteLine("Error! Please try again");
            //        break;
            //}

            //Console.WriteLine("What is diference between matrix[,] and matrix[,,]");
            //Console.WriteLine("1. The matrices have point inside");
            //Console.WriteLine("2. matrix[,] - have one dimension, matrix[,,] have two dimensions");
            //Console.WriteLine("3. matrix[,] - have two dimensions, matrix[,,] have three dimensions");
            //Console.Write("Enter your choice: ");
            //int fourthChoice = int.Parse(Console.ReadLine());

            //switch (fourthChoice)
            //{
            //    case 1:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    case 2:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    case 3:
            //        Console.WriteLine("Correct! Right is your way");
            //        break;
            //    default:
            //        Console.WriteLine("Error! Please try again");
            //        break;
            //}

            //Console.WriteLine("What is jagged arrays?");
            //Console.WriteLine("1. Arrays of arrays, each element is an array itself");
            //Console.WriteLine("2. Arrays who help to code football game");
            //Console.WriteLine("3. Arrays who collect - int, string, char etc.");
            //Console.Write("Enter your choice: ");
            //int fifthChoice = int.Parse(Console.ReadLine());

            //switch (fifthChoice)
            //{
            //    case 1:
            //        Console.WriteLine("Correct! Right is your way");
            //        break;

            //    case 2:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    case 3:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    default:
            //        Console.WriteLine("Error! Please try again");
            //        break;
            //}

            //Console.WriteLine("What is desribe of words - static void FunctionalCode(int count)?");
            //Console.WriteLine("1. static voice of code who can (counting)");
            //Console.WriteLine("2. static free code for (count)");
            //Console.WriteLine("3. static return type name (parameters)");
            //Console.Write("Enter your choice: ");
            //int sixthChoice = int.Parse(Console.ReadLine());

            //switch (fifthChoice)
            //{
            //    case 1:
            //        Console.WriteLine("You must learn more C#");
            //        break;

            //    case 2:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    case 3:
            //        Console.WriteLine("Correct! Right is your way");
            //        break;

            //    default:
            //        Console.WriteLine("Error! Please try again");
            //        break;
            //}
            //Console.WriteLine("You have string word = Hello!; , what will be print console -> int num = word.lenght;");
            //Console.WriteLine("1. Will be print Hello!");
            //Console.WriteLine("2. Will be print 5");
            //Console.WriteLine("3. Will be print 6");
            //Console.Write("Enter your choice: ");
            //int seventhChoice = int.Parse(Console.ReadLine());

            //switch (seventhChoice)
            //{
            //    case 1:
            //        Console.WriteLine("You must learn more C#");
            //        break;

            //    case 2:
            //        Console.WriteLine("Correct! Right is your way");
            //        break;
            //    case 3:
            //        Console.WriteLine("You must learn more C#");
            //        break;

            //    default:
            //        Console.WriteLine("Error! Please try again");
            //        break;
            //}
            //Console.WriteLine("When you search samo letter in string and console print -1. What means this?");
            //Console.WriteLine("1. Visual Studio don't worked corred");
            //Console.WriteLine("2. In word have -1");
            //Console.WriteLine("3. In word don't have this letter");
            //Console.Write("Enter your choice: ");
            //int eightChoice = int.Parse(Console.ReadLine());

            //switch (eightChoice)
            //{
            //    case 1:
            //        Console.WriteLine("You must learn more C#");
            //        break;

            //    case 2:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    case 3:
            //        Console.WriteLine("Correct! Right is your way");
            //        break;

            //    default:
            //        Console.WriteLine("Error! Please try again");
            //        break;
            //}

            //Console.WriteLine("When we have string filename C:\\Pics\\Rila2009.jpg; string name = filename.Substring(8,8).What console will print?");
            //Console.WriteLine("1. Rila2009");
            //Console.WriteLine("2. Will print only \"R\"");
            //Console.WriteLine("3. C:\\Pics\\R");
            //Console.Write("Enter your choice: ");
            //int ninthChoice = int.Parse(Console.ReadLine());

            //switch (ninthChoice)
            //{
            //    case 1:
            //        Console.WriteLine("Correct! Right is your way");
            //        break;

            //    case 2:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    case 3:
            //        Console.WriteLine("You must learn more C#");
            //        break;

            //    default:
            //        Console.WriteLine("Error! Please try again");
            //        break;
            //}

            //Console.WriteLine("What is StingBuilder?");
            //Console.WriteLine("1. Build work process in Visual Studio");
            //Console.WriteLine("2. Console print int faster");
            //Console.WriteLine("3. Keeps a buffer memory, allocated in advance");
            //Console.Write("Enter your choice: ");
            //int tenthChoice = int.Parse(Console.ReadLine());

            //switch (tenthChoice)
            //{
            //    case 1:
            //        Console.WriteLine("You must learn more C#");
            //        break;

            //    case 2:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    case 3:
            //        Console.WriteLine("Correct! Right is your way");
            //        break;

            //    default:
            //        Console.WriteLine("Error! Please try again");
            //        break;
            //}

            //Console.WriteLine("What is Regular Expressions?");
            //Console.WriteLine("1. Regular program code ");
            //Console.WriteLine("2. Regular is a sequence of characters that forms a search pattern");
            //Console.WriteLine("3. Regular Expressions is for easy find differnt number in arrays");
            //Console.Write("Enter your choice: ");
            //int eleventhChoice = int.Parse(Console.ReadLine());

            //switch (eleventhChoice)
            //{
            //    case 1:
            //        Console.WriteLine("You must learn more C#");
            //        break;

            //    case 2:
            //        Console.WriteLine("Correct! Right is your way");
            //        break;
            //    case 3:
            //        Console.WriteLine("You must learn more C#");
            //        break;

            //    default:
            //        Console.WriteLine("Error! Please try again");
            //        break;
            //}

            //Console.WriteLine("For what is use character \\t ?");
            //Console.WriteLine("1. This is located disk on hard drive ");
            //Console.WriteLine("2. It use for matches a tab");
            //Console.WriteLine("3. This is only letter in word");
            //Console.Write("Enter your choice: ");
            //int twelfthChoice = int.Parse(Console.ReadLine());

            //switch (twelfthChoice)
            //{
            //    case 1:
            //        Console.WriteLine("You must learn more C#");
            //        break;

            //    case 2:
            //        Console.WriteLine("Correct! Right is your way");
            //        break;
            //    case 3:
            //        Console.WriteLine("You must learn more C#");
            //        break;

            //    default:
            //        Console.WriteLine("Error! Please try again");
            //        break;
            //}

            //Console.WriteLine("What is file?");
            //Console.WriteLine("1. This is my operation system");
            //Console.WriteLine("2. Code who run the programs");
            //Console.WriteLine("3. Is a resource for storing information");
            //Console.Write("Enter your choice: ");
            //int thirteenthChoice = int.Parse(Console.ReadLine());

            //switch (thirteenthChoice)
            //{
            //    case 1:
            //        Console.WriteLine("You must learn more C#");
            //        break;

            //    case 2:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    case 3:
            //        Console.WriteLine("Correct! Right is your way");
            //        break;

            //    default:
            //        Console.WriteLine("Error! Please try again");
            //        break;
            //}
            //Console.WriteLine("What is GzipStream?");
            //Console.WriteLine("1. Stream who compress and decompress data");
            //Console.WriteLine("2. Another name of rar");
            //Console.WriteLine("3. Giga zip file");
            //Console.Write("Enter your choice: ");
            //int fourteenthChoice = int.Parse(Console.ReadLine());

            //switch (fourteenthChoice)
            //{
            //    case 1:
            //        Console.WriteLine("Correct! Right is your way");
            //        break;

            //    case 2:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    case 3:
            //        Console.WriteLine("You must learn more C#");
            //        break;

            //    default:
            //        Console.WriteLine("Error! Please try again");
            //        break;
            //}

            //Console.WriteLine("What is var method");
            //Console.WriteLine("1. I can service trees");
            //Console.WriteLine("2. This is nothing");
            //Console.WriteLine("3. Can collected int, char, shtring etc.");
            //Console.Write("Enter your choice: ");
            //int fifteenthChoice = int.Parse(Console.ReadLine());

            //switch (fourteenthChoice)
            //{
            //    case 1:
            //        Console.WriteLine("Correct! Right is your way");
            //        break;

            //    case 2:
            //        Console.WriteLine("You must learn more C#");
            //        break;
            //    case 3:
            //        Console.WriteLine("You must learn more C#");
            //        break;

            //    default:
            //        Console.WriteLine("Error! Please try again");
            //        break;
            //}













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
