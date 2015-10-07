using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheMaze
{
    class Game
    {
        
        static void Main(string[] args)
        {
            
            
            char[,] mazeMatrix =
            {   //size of matrix we take with getLengt(0) and getLenght(1). You can input different mazes
                { '#','#','#','#','#','#','#','#','#','#' },
                { 'O','?','#',' ',' ',' ','#',' ',' ','#' },
                { '#',' ','#',' ','#',' ','#','#',' ','#' },
                { '#','?',' ',' ','#',' ',' ',' ',' ','#' },
                { '#','#','#',' ','#','#','#','#',' ','#' },
                { '#',' ',' ',' ',' ','#',' ',' ',' ','#' },
                { '#',' ','#','#',' ','#',' ','#',' ','#' },
                { '#',' ','#',' ',' ','#',' ','#','#','#' },
                { '#',' ','#',' ','#','#',' ',' ',' ',' ' },
                { '#','#','#','#','#','#','#','#','#','#' },
            };



            // Console settings
            Console.CursorVisible = false;

            // Set Start
            int currentCol = 0;
            int currentRow = 1;
            char currentPlace = mazeMatrix[currentRow, currentCol];
            printMaze(mazeMatrix, currentRow, currentCol);

            while (true)
            {
                // Move current place
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                    while (Console.KeyAvailable) { Console.ReadKey(true); }
                    if (keyPressed.Key == ConsoleKey.LeftArrow)
                    {
                        if ((currentCol >= 1) &&
                            (mazeMatrix[currentRow, currentCol - 1] != '#'))
                        {

                            char previousPosition = currentPlace;
                            mazeMatrix[currentRow, currentCol] = ' ';
                            mazeMatrix[currentRow, currentCol - 1] = previousPosition;
                            currentCol--;
                            Console.Clear();
                            printMaze(mazeMatrix, currentRow, currentCol);
                        }

                    }
                    if (keyPressed.Key == ConsoleKey.RightArrow)
                    {
                        if (((currentCol + 1) < mazeMatrix.GetLength(1)) &&
                            (mazeMatrix[currentRow, currentCol + 1] != '#'))
                        {

                            if (mazeMatrix[currentRow, currentCol + 1] == '?')
                            {
                                // here must input class questions
                                Console.WriteLine(@"You have code (string something = 2 + 3 + ""word"" ;). What console will be print!");
                                Console.WriteLine("1. 7word");
                                Console.WriteLine("2. 23word");
                                Console.WriteLine("3. 2 + 3 + word");
                                Console.Write("Enter your choice: ");
                                int firstChoice = int.Parse(Console.ReadLine());

                                switch (firstChoice)
                                {
                                    case 1:
                                        Console.WriteLine("Correct! Right is your way");
                                        break;
                                    case 2:
                                        Console.WriteLine("You must learn more C#");
                                        break;
                                    case 3:
                                        Console.WriteLine("You must learn more C#");
                                        break;
                                    default:
                                        Console.WriteLine("Error! Please try again");
                                        break;
                                }
                                //Pause game for answer
                                var continiue = (Console.ReadLine());

                                switch (continiue)
                                {
                                    default:
                                        break;
                                }
                            }
                            char previousPosition = currentPlace;
                            mazeMatrix[currentRow, currentCol] = ' ';
                            mazeMatrix[currentRow, currentCol + 1] = previousPosition;
                            currentCol++;
                            Console.Clear();
                            printMaze(mazeMatrix, currentRow, currentCol);
                        }

                    }
                    if (keyPressed.Key == ConsoleKey.DownArrow)
                    {
                        if ((mazeMatrix[currentRow + 1, currentCol] != '#') &&
                            (currentRow + 1) < mazeMatrix.GetLength(0))
                        {
                            char previousPosition = currentPlace;
                            mazeMatrix[currentRow, currentCol] = ' ';
                            mazeMatrix[currentRow + 1, currentCol] = previousPosition;
                            currentRow++;
                            Console.Clear();
                            printMaze(mazeMatrix, currentRow, currentCol);
                        }
                    }
                    if (keyPressed.Key == ConsoleKey.UpArrow)
                    {
                        if ((mazeMatrix[currentRow - 1, currentCol] != '#') &&
                            ((currentRow - 1) > 0))
                        {
                            char previousPosition = currentPlace;
                            mazeMatrix[currentRow, currentCol] = ' ';
                            mazeMatrix[currentRow - 1, currentCol] = previousPosition;
                            currentRow--;
                            Console.Clear();
                            printMaze(mazeMatrix, currentRow, currentCol);
                        }
                    }
                }
            }


        }

        static void printMaze(char[,] matrix, int currentRow, int currentCol)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((row >= currentRow - 2) && (row <= currentRow + 2) &&
                        (col >= currentCol - 2) && (col <= currentCol + 2))
                    {
                        Console.Write("{0} ", matrix[row, col]);
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}


