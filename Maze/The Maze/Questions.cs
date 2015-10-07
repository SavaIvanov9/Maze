using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheMaze
{
    public static class Questions
    {
        // Here you should add all question indexes with their corresponding directions.
        private static Dictionary<int, string> questionPositionsDir = new Dictionary<int, string>()
        {
            { 0, "Right" }
        };

        public static void QuestionsList(int questionNum, int questionPosIndex)
        {

            switch (questionNum)
            {
                case 1:
                    Console.WriteLine(@"You have code (string something = 2 + 3 + ""word"" ). What console will be print!");
                    Console.WriteLine("1. 7word");
                    Console.WriteLine("2. 23word");
                    Console.WriteLine("3. 2 + 3 + word");
                    Console.Write("Enter your choice: ");

                    PrintResponse(1, questionPosIndex);
                    break;
                case 2:
                    Console.WriteLine("What is string?");
                    Console.WriteLine("1. This is ring street");
                    Console.WriteLine("2. Array of chars");
                    Console.WriteLine("3. Method in C#");
                    Console.Write("Enter your choice: ");
                    PrintResponse(2, questionPosIndex);
                    break;

                case 3:
                    Console.WriteLine("What is diference between Array and List Methods?");
                    Console.WriteLine("1. They don't have diference");
                    Console.WriteLine("2. Array have resizable holds, List have fix holds");
                    Console.WriteLine("3. List have resizable holds, Array have fix holds");
                    Console.Write("Enter your choice: ");

                    PrintResponse(3, questionPosIndex);
                    break;
                case 4:
                    Console.WriteLine("What is diference between matrix[,] and matrix[,,]");
                    Console.WriteLine("1. The matrices have point inside");
                    Console.WriteLine("2. matrix[,] - have one dimension, matrix[,,] have two dimensions");
                    Console.WriteLine("3. matrix[,] - have two dimensions, matrix[,,] have three dimensions");
                    Console.Write("Enter your choice: ");

                    PrintResponse(3, questionPosIndex);
                    break;

                case 5:
                    Console.WriteLine("What is jagged arrays?");
                    Console.WriteLine("1. Arrays of arrays, each element is an array itself");
                    Console.WriteLine("2. Arrays who help to code football game");
                    Console.WriteLine("3. Arrays who collect - int, string, char etc.");
                    Console.Write("Enter your choice: ");

                    PrintResponse(1, questionPosIndex);
                    break;

                case 6:

                    Console.WriteLine("What is desribe of words - static void FunctionalCode(int count)?");
                    Console.WriteLine("1. static voice of code who can (counting)");
                    Console.WriteLine("2. static free code for (count)");
                    Console.WriteLine("3. static return type name (parameters)");
                    Console.Write("Enter your choice: ");

                    PrintResponse(3, questionPosIndex);
                    break;

                case 7:
                    Console.WriteLine("You have string word = Hello!; , what will be print console -> int num = word.lenght;");
                    Console.WriteLine("1. Will be print Hello!");
                    Console.WriteLine("2. Will be print 5");
                    Console.WriteLine("3. Will be print 6");
                    Console.Write("Enter your choice: ");

                    PrintResponse(2, questionPosIndex);
                    break;

                case 8:

                    Console.WriteLine("When you search samo letter in string and console print -1. What means this?");
                    Console.WriteLine("1. Visual Studio don't worked corred");
                    Console.WriteLine("2. In word have -1");
                    Console.WriteLine("3. In word don't have this letter");
                    Console.Write("Enter your choice: ");

                    PrintResponse(3, questionPosIndex);
                    break;
                case 9:

                    Console.WriteLine("When we have string filename C:\\Pics\\Rila2009.jpg; string name = filename.Substring(8,8).What console will print?");
                    Console.WriteLine("1. Rila2009");
                    Console.WriteLine("2. Will print only \"R\"");
                    Console.WriteLine("3. C:\\Pics\\R");
                    Console.Write("Enter your choice: ");

                    PrintResponse(1, questionPosIndex);
                    break;

                case 10:
                    Console.WriteLine("What is StingBuilder?");
                    Console.WriteLine("1. Build work process in Visual Studio");
                    Console.WriteLine("2. Console print int faster");
                    Console.WriteLine("3. Keeps a buffer memory, allocated in advance");
                    Console.Write("Enter your choice: ");

                    PrintResponse(3, questionPosIndex);
                    break;

                case 11:
                    Console.WriteLine("What is Regular Expressions?");
                    Console.WriteLine("1. Regular program code ");
                    Console.WriteLine("2. Regular is a sequence of characters that forms a search pattern");
                    Console.WriteLine("3. Regular Expressions is for easy find differnt number in arrays");
                    Console.Write("Enter your choice: ");

                    PrintResponse(2, questionPosIndex);
                    break;

                case 12:
                    Console.WriteLine("For what is use character \\t ?");
                    Console.WriteLine("1. This is located disk on hard drive ");
                    Console.WriteLine("2. It use for matches a tab");
                    Console.WriteLine("3. This is only letter in word");
                    Console.Write("Enter your choice: ");

                    PrintResponse(2, questionPosIndex);
                    break;

                case 13:
                    Console.WriteLine("What is file?");
                    Console.WriteLine("1. This is my operation system");
                    Console.WriteLine("2. Code who run the programs");
                    Console.WriteLine("3. Is a resource for storing information");
                    Console.Write("Enter your choice: ");

                    PrintResponse(3, questionPosIndex);
                    break;

                case 14:
                    Console.WriteLine("What is GzipStream?");
                    Console.WriteLine("1. Stream who compress and decompress data");
                    Console.WriteLine("2. Another name of rar");
                    Console.WriteLine("3. Giga zip file");
                    Console.Write("Enter your choice: ");

                    PrintResponse(1, questionPosIndex);
                    break;

                case 15:
                    Console.WriteLine("What is var method");
                    Console.WriteLine("1. I can service trees");
                    Console.WriteLine("2. This is nothing");
                    Console.WriteLine("3. Can collected int, char, shtring etc.");
                    Console.Write("Enter your choice: ");

                    PrintResponse(1, questionPosIndex);
                    break;
                default:
                    Console.WriteLine("Error! Please try again");
                    break;
            }
        }

        private static void PrintResponse(int correctAnswer, int questionPosIndex)
        {
            int firstChoice = int.Parse(Console.ReadLine());

            if (firstChoice == correctAnswer)
            {
                string direction = GetDirection(questionPosIndex);
                Console.WriteLine("Correct! {0} is your way", direction);
            }
            else if (firstChoice <= 3)
            {
                Console.WriteLine("You must learn more C#");
            }
            else
            {
                Console.WriteLine("Error! Please try again");
            }
        }

        private static string GetDirection(int questionPosIndex)
        {
            string direction = questionPositionsDir[questionPosIndex];
            return direction;
        }
    }
}