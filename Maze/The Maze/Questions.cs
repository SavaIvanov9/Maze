using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheMaze
{
    public static class Questions
    {
        // Here are question indexes with their corresponding directions.
        private static Dictionary<int, string> questionPositionsDir = new Dictionary<int, string>()
        {
            { 0, "Up" },
            { 1, "Back" },
            { 2, "Back" },
            { 3, "Right" },
            { 4, "Right" },
            { 5, "Back" },
            { 6, "Down" },
            { 7, "Right" },
            { 8, "Down" },
            { 9, "Left" },
            { 10, "Left" },
        };

        public static void QuestionsList(int questionNum, int questionPosIndex)
        {

            switch (questionNum)
            {
                case 1:
                    Console.WriteLine(@"You have code (string something = 2 + 3 + ""word"" ). What console will print?");
                    Console.WriteLine("1. 7word");
                    Console.WriteLine("2. 23word");
                    Console.WriteLine("3. 2 + 3 + word");
                    Console.Write("Enter your choice: ");

                    PrintResponse(1, questionPosIndex);
                    break;
                case 2:
                    Console.WriteLine("Which of the following is NOT a Bitwise operator in C#.NET?");
                    Console.WriteLine("1. &");
                    Console.WriteLine("2. ~");
                    Console.WriteLine("3. <");
                    Console.Write("Enter your choice: ");
                    PrintResponse(3, questionPosIndex);
                    break;

                case 3:
                    Console.WriteLine("What is diference between Array and List Methods?");
                    Console.WriteLine("1. List have resizable holds, Array have fix holds");
                    Console.WriteLine("2. Array have resizable holds, List have fix holds");                    
                    Console.WriteLine("3. They don't have diference");
                    Console.Write("Enter your choice: ");

                    PrintResponse(1, questionPosIndex);
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
                    Console.WriteLine("Which datatype should be more preferred for storing a simple number like 35 to improve execution speed of a program?");
                    Console.WriteLine("1. short");
                    Console.WriteLine("2. sbyte");
                    Console.WriteLine("3. int");
                    Console.Write("Enter your choice: ");

                    PrintResponse(2, questionPosIndex);
                    break;

                case 6:

                    Console.WriteLine("Correct way to assign values to variable ‘c’ when int a=12, float b=3.5, int c;");
                    Console.WriteLine("1. c = int(a + b)");
                    Console.WriteLine("2. c = a + int(float(b))");
                    Console.WriteLine("3. a + convert.ToInt32(b)");
                    Console.Write("Enter your choice: ");

                    PrintResponse(3, questionPosIndex);
                    break;

                case 7:
                    Console.WriteLine(@"You have string word = ""Hello!""; , what console will print? -> int num = word.Length;");
                    Console.WriteLine("1. Will be print Hello!");
                    Console.WriteLine("2. Will be print 5");
                    Console.WriteLine("3. Will be print 6");
                    Console.Write("Enter your choice: ");

                    PrintResponse(3, questionPosIndex);
                    break;

                case 8:

                    Console.WriteLine("Which of the following statements are correct?");
                    Console.WriteLine("1. The conditional operator (?:) returns one of two values depending on the value of a Boolean expression.");
                    Console.WriteLine("2. The as operator in C#.NET is used to perform conversions between compatible reference types.");
                    Console.WriteLine("3. In addition to being used to specify the order of operations in an expression, brackets [ ] are used to specify casts or type conversions.");
                    Console.Write("Enter your choice: ");

                    PrintResponse(3, questionPosIndex);
                    break;
                case 9:

                    Console.WriteLine("We have string filename C:\\Pics\\Rila2009.jpg; string name = filename.Substring(8,8). What console will print?");
                    Console.WriteLine("1. Rila2009");
                    Console.WriteLine("2. Will print only \"R\"");
                    Console.WriteLine("3. C:\\Pics\\R");
                    Console.Write("Enter your choice: ");

                    PrintResponse(1, questionPosIndex);
                    break;

                case 10:
                    Console.WriteLine(" What is the value of double constant ‘E’ defined in Math class?");
                    Console.WriteLine("1. approximately 0");
                    Console.WriteLine("2. approximately 2.72");
                    Console.WriteLine("3. approximately 3.14");
                    Console.Write("Enter your choice: ");

                    PrintResponse(2, questionPosIndex);
                    break;

                case 11:
                    Console.WriteLine("What is Regular Expression?");
                    Console.WriteLine("1. Regular program code ");
                    Console.WriteLine("2. Regular Expression is a sequence of characters that forms a search pattern");
                    Console.WriteLine("3. Regular Expression is for easy find differnt number in arrays");
                    Console.Write("Enter your choice: ");

                    PrintResponse(2, questionPosIndex);
                    break;

                case 12:
                    Console.WriteLine("For what is used string \\t ?");
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
                    Console.WriteLine("Which of these methods are used to read single character from the console?");
                    Console.WriteLine("1. get()");
                    Console.WriteLine("2. read()");
                    Console.WriteLine("3. readLine()");
                    Console.Write("Enter your choice: ");

                    PrintResponse(2, questionPosIndex);
                    break;
             

                case 16:
                    Console.WriteLine("Which of these method used to read strings from the console");
                    Console.WriteLine("1. getLine()");
                    Console.WriteLine("2. read()");
                    Console.WriteLine("3. readLine()");
                    Console.Write("Enter your choice: ");

                    PrintResponse(3, questionPosIndex);
                    break;

                case 17:
                    Console.WriteLine("What is the Size of ‘Char’ datatype?");
                    Console.WriteLine("1. 12 bit");
                    Console.WriteLine("2. 16 bit");
                    Console.WriteLine("3. 20 bit");
                    Console.Write("Enter your choice: ");

                    PrintResponse(2, questionPosIndex);
                    break;
                case 18:
                    Console.WriteLine("Correct statement about strings are?");
                    Console.WriteLine("1. a string is created on the stack");
                    Console.WriteLine("2. a string created on heap");
                    Console.WriteLine("3. a string is primitive in nature");
                    Console.Write("Enter your choice: ");

                    PrintResponse(2, questionPosIndex);
                    break;
                case 19:
                    Console.WriteLine("Which statement is correct among the mentioned statements");
                    Console.WriteLine("A. The for loop works faster than a while loop");
                    Console.WriteLine("B. for( ; ; )implements an infinite loop");
                    Console.WriteLine("1. Only A is correct");
                    Console.WriteLine("2. Only B is correct");
                    Console.WriteLine("3. Both are incorrect");
                    Console.Write("Enter your choice: ");

                    PrintResponse(2, questionPosIndex);
                    break;
                case 20:
                    Console.WriteLine("Which of the following functions return absolute value of a variable?");
                    Console.WriteLine("1. Abs()");
                    Console.WriteLine("2. Absolute()");
                    Console.WriteLine("3. absolutevariable()");
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