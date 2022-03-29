using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Operations
    {
        public void OprerationsGameBeginCheck(ConsoleKeyInfo cki)
        {
           
            if (cki.Key == ConsoleKey.Y)
            {
                Console.WriteLine("\nGreat! Let's get started.");
                Console.WriteLine("Complete the following equation");
            }
            else if (cki.Key == ConsoleKey.N)
            {
                Console.WriteLine("\nAre you sure. Math is fun!");
            }
            else
            {
                Console.WriteLine("\nSorry. I don't understand that answer.");
            }
        }

        public void MatProblemsHasSelected(ConsoleKeyInfo cki)
        {
            int num1 = 0;
            int num2 = 0;
            int mathAnswer = 0;
            string mathProblem = null;
            string userValue = null;
            int answer = 0;
            int correctCount = 0;

            bool userPlays = true;
            while (userPlays)
            {
                bool questionCycle = true;
                while (questionCycle)
                {
                    Random rnd = new Random();
                    num1 = rnd.Next(10);
                    num2 = rnd.Next(10);
                    mathAnswer = num1 + num2;
                    mathProblem = num1.ToString() + " + " + num2.ToString() + " = ";
                    Console.WriteLine(mathProblem);
                    userValue = Console.ReadLine();
                    answer = Convert.ToInt32(userValue);


                    if (mathAnswer == answer)
                    {
                        Console.WriteLine("Correct!");

                        correctCount +=  1;
                    }


                    if (correctCount % 5 == 0)
                    {
                        Console.WriteLine("You've answered " + correctCount + " questions correctly! Great job. " +
                                          "Would you like to keep playing? Press Y for Yes and N for No.");
                        cki = Console.ReadKey();

                      
                        if (cki.Key == ConsoleKey.N)
                        {
                            Console.WriteLine("\nGoodbye.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Sorry. I don't understand that answer.");
                            Console.ReadKey();
                        }

                    }
                    else
                    {
                        Console.WriteLine("The Correct answer is " + mathAnswer);
                    }

                }
            }
        }
    }
}
