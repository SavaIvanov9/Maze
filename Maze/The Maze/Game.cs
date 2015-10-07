using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMaze
{
    class Program
    {
        // Random generator.
        private static Random rand = new Random();
        // Here you should add all question positions along with their question index. Positions are string is format "{row} {col}"
        public static Dictionary<string, int> questionPositions = new Dictionary<string, int>()
        {
            { "1 1", 0}
        };

        static bool isRunning = true;
        static void Main(string[] args)
        {

            char[,] mazeMatrix =
            {
                { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
                { 'O','?','#',' ',' ',' ','#',' ',' ','#',' ',' ',' ','#',' ','#',' ',' ',' ','#' },
                { '#',' ','#',' ','#',' ','#','#',' ','#',' ','#',' ',' ',' ','#',' ','#','#','#' },
                { '#','?',' ',' ','#',' ',' ',' ',' ','#',' ','#','#','#',' ',' ',' ','#',' ','#' },
                { '#','#','#',' ','#','#','#','#',' ','#',' ',' ',' ','#','#','#','#','#',' ','#' },
                { '#',' ',' ',' ',' ','#',' ',' ',' ','#','#','#',' ',' ',' ',' ',' ',' ',' ','#' },
                { '#',' ','#','#',' ','#',' ','#',' ','#',' ',' ',' ','#',' ','#','#','#','#','#' },
                { '#',' ','#',' ',' ','#',' ','#','#','#',' ','#','#','#',' ','#',' ',' ',' ','#' },
                { '#',' ','#',' ','#','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ','#' },
                { '#','#','#',' ','#',' ',' ','#',' ','#','#','#',' ','#','#','#','#','#',' ','#' },
                { '#',' ',' ',' ','#',' ','#','#',' ','#',' ','#','#','#',' ',' ',' ',' ',' ','#' },
                { '#',' ','#','#','#','#','#',' ',' ','#',' ',' ','#',' ',' ','#',' ','#','#','#' },
                { '#',' ','#',' ',' ',' ','#',' ','#','#','#',' ',' ',' ',' ','#',' ',' ',' ','#' },
                { '#',' ',' ',' ','#',' ','#',' ',' ',' ','#','#','#','#',' ','#','#','#','#','#' },
                { '#','#','#',' ','#',' ','#',' ','#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#' },
                { '#',' ',' ',' ','#',' ','#',' ','#','#','#','#',' ','#','#',' ','#','#',' ','#' },
                { '#',' ','#','#','#',' ','#',' ',' ',' ',' ','#',' ','#',' ',' ','#',' ',' ','#' },
                { '#',' ','#',' ',' ',' ','#','#',' ','#',' ','#',' ','#',' ','#','#',' ','#','#' },
                { '#',' ','#',' ','#',' ','#',' ',' ','#',' ',' ',' ','#',' ',' ','#',' ',' ',' ' },
                { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
            };



            // Console settings
            Console.CursorVisible = false;

            // Set Start
            int currentCol = 0;
            int currentRow = 1;
            char currentPlace = mazeMatrix[currentRow, currentCol];
            PrintMaze(mazeMatrix, currentRow, currentCol);

            while (isRunning)
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

                            OnQuestionAction(currentCol, currentRow);

                            Console.Clear();
                            PrintMaze(mazeMatrix, currentRow, currentCol);

                            CheckForEnd(currentCol, currentRow);
                        }

                    }
                    if (keyPressed.Key == ConsoleKey.RightArrow)
                    {
                        if (((currentCol + 1) < mazeMatrix.GetLength(1)) &&
                            (mazeMatrix[currentRow, currentCol + 1] != '#'))
                        {
                            char previousPosition = currentPlace;
                            mazeMatrix[currentRow, currentCol] = ' ';
                            mazeMatrix[currentRow, currentCol + 1] = previousPosition;
                            currentCol++;

                            OnQuestionAction(currentCol, currentRow);

                            Console.Clear();
                            PrintMaze(mazeMatrix, currentRow, currentCol);

                            CheckForEnd(currentCol, currentRow);
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

                            OnQuestionAction(currentCol, currentRow);

                            Console.Clear();
                            PrintMaze(mazeMatrix, currentRow, currentCol);

                            CheckForEnd(currentCol, currentRow);
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

                            OnQuestionAction(currentCol, currentRow);

                            Console.Clear();
                            PrintMaze(mazeMatrix, currentRow, currentCol);

                            CheckForEnd(currentCol, currentRow);
                        }
                    }
                }
            }


        }

        private static void OnQuestionAction(int currentCol, int currentRow)
        {
            if (GetQuestionIndex(currentRow, currentCol) > -1)
            {
                int randNum = rand.Next(1, 15);

                Questions.QuestionsList(randNum, GetQuestionIndex(currentRow, currentCol));

                //Pause game for answer
                var continiue = (Console.ReadLine());

                switch (continiue)
                {
                    default:
                        break;
                }
            }
        }

        private static int GetQuestionIndex(int row, int column)
        {
            string key = row + " " + column;
            if (questionPositions.ContainsKey(key))
            {
                int questionIndex = questionPositions[key];

                return questionIndex;
            }

            return -1;
        }

        static void CheckForEnd(int currCol, int currRow)
        {
            if ((currCol == 19) && (currRow == 18))
            {
                Console.Clear();
                Console.WriteLine("GOOD JOB!!!");
                Console.ReadKey();
                isRunning = false;
            }
        }

        //Printing muted maze
        static void PrintMaze(char[,] matrix, int currentRow, int currentCol)
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