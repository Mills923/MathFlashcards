using System;

namespace MathGames
{
    class Util
    {
        public static int Add(int numb)
        {
            Random r = new Random();
            int counter = 0;
            for (int i = 0; i < numb; i++)
            {
                int numOne = r.Next(1, 51);
                int numTwo = r.Next(1, 51);
                Console.Write($"{numOne} + {numTwo} = ");
                int response = int.Parse(Console.ReadLine());
                if (response == numOne + numTwo)
                {
                    Console.WriteLine("Correct!");
                    counter++;
                }
                else
                {
                    int answer = numOne + numTwo;
                    Console.WriteLine($"Sorry, the correct answer is {answer}");
                }

            }

            return counter;
        }

        public static int Subtract(int input)
        {
            Random r = new Random();
            int counter = 0;
            for (int i = 0; i < input; i++)
            {
                int numOne = r.Next(1, 51);
                int numTwo = r.Next(1, 51);
                Console.Write($"{numOne} - {numTwo} = ");
                int response = int.Parse(Console.ReadLine());
                if (response == numOne - numTwo)
                {
                    Console.WriteLine("Correct!");
                    counter++;
                }
                else
                {
                    int answer = numOne - numTwo;
                    Console.WriteLine($"Sorry, the correct answer is {answer}");
                }

            }

            return counter;
        }
        public static int Multiply(int input)
        {
            Random r = new Random();
            int counter = 0;
            for (int i = 0; i < input; i++)
            {
                int numOne = r.Next(1, 51);
                int numTwo = r.Next(1, 51);
                Console.Write($"{numOne} * {numTwo} = ");
                int response = int.Parse(Console.ReadLine());
                if (response == numOne * numTwo)
                {
                    Console.WriteLine("Correct!");
                    counter++;
                }
                else
                {
                    int answer = numOne * numTwo;
                    Console.WriteLine($"Sorry, the correct answer is {answer}");
                }

            }

            return counter;
        }

        public static int Divide(int input)
        {
            Random r = new Random();
            int counter = 0;
            for (int i = 0; i < input; i++)
            {
                decimal numOne = r.Next(1, 51);
                decimal numTwo = r.Next(1, 51);
                Console.Write($"{numOne} / {numTwo} = ");
                decimal response = decimal.Parse(Console.ReadLine());
                decimal answer = Math.Round(numOne / numTwo,2);
                
                if (response == numOne / numTwo)
                {
                    Console.WriteLine("Correct!");
                    counter++;
                }
                else
                {

                    Console.WriteLine($"Sorry, the correct answer is {answer}");
                }

            }

            return counter;
        }

        public static string Report(int score, int numb)
        {
            double newNum = score;
            double newTwo = numb;
            double average = (newNum / newTwo) * 100;

            string response =($"You got {score} out of {numb} correct and your grade is {average}");

            return response;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Math Games");
            Console.WriteLine("\tTo add, enter 1,");
            Console.WriteLine("\tTo subtract, enter 2,");
            Console.WriteLine("\tTo multiply, enter 3,");
            Console.WriteLine("\tTo divide, enter 4,");
            Console.Write("Choose your problem type: ");
            int probType = int.Parse(Console.ReadLine());
            Console.Write("Enter number of problem between 1 and 10: ");
            int numProb = int.Parse(Console.ReadLine());
            int score = 0;

            if (probType == 1)
                score = Util.Add(numProb);
            else if (probType == 2)
                score = Util.Subtract(numProb);
            else if (probType == 3)
                score = Util.Multiply(numProb);
            else if (probType == 4)
                score = Util.Divide(numProb);
            else
                Console.WriteLine("Sorry, you made an invalid choice.");
            string report = Util.Report(score, numProb);
            Console.WriteLine(report);
        }
    }
}