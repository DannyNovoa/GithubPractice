using System;

namespace GithubPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int num1 = 5;
            int num2 = num1;


            num1 = 6;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            string answer;
            do
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine();
                Console.WriteLine("Would you like to continue (y/n) ?");
                 answer = Console.ReadLine();
                if (answer == "n")
                {
                    Console.WriteLine("Adios Amigo!");
                }
                Console.WriteLine();


            } while (answer == "y");
            string newAnswer;
            do
            {
                Console.WriteLine("Hi dude enter some text please: ");
                newAnswer = Console.ReadLine();
                Console.WriteLine($"Hello world {newAnswer} !");

                Console.WriteLine("Would you like to continue (y/n) ?");
                newAnswer = Console.ReadLine();
                if (newAnswer == "n")
                {
                    Console.WriteLine("Adios, A bientot! ");
                }


            } while (newAnswer == "y");
            


            Console.ReadKey();
          
        }
    }
}
