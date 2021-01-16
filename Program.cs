using System;
using System.Threading;

namespace projekt
{
    class Program
    {
        static void Main(string[] args)
        {

            ProgramInfo();

            Hello();

             //Create a randomizer object
            Random randomObject = new Random();

            while(true)
            {
            string questionString = GetQuestionFromUser();

            int numberOfSecondsToSleep = randomObject.Next(5) + 1;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Hmmm, let me think...");
            Thread.Sleep(numberOfSecondsToSleep * 1000);

            if(questionString.Length == 0)
            {
                Console.WriteLine("You need to type a question.");
                continue;
            }
               //Cleaning up color
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            //Get a random number
            int randomNumber = randomObject.Next(8); 


            //Answers
            switch(randomNumber)
            {
                case 0:
                {
                    Console.WriteLine("OMG YES!");
                break;
                }
                case 1:
                {
                    Console.WriteLine("HA HA, don't think so!");
                break;
                }
                case 2:
                {
                    Console.WriteLine("HELL NO!");
                break;
                }
                case 3:
                {
                    Console.WriteLine("Maybe when you're old?");
                break;
                }
                case 4:
                {
                    Console.WriteLine("For sure!");
                break;
                }
                case 5:
                {
                    Console.WriteLine("Can't answer that right now.");
                break;
                }
                case 6:
                {
                    Console.WriteLine("Not in a million years!");
                break;
                }
                case 7:
                {
                    Console.WriteLine("YEAAAH!");
                break;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Do you have another question? ");
            continue;

            }

        }
        //Program info
        static void ProgramInfo()
        {
            //Change console color
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Magic 8 ball by Cecilia Wendin, 2021");
            Console.WriteLine("");
        }

        //Hello
        static void Hello()
        {
            //Change console color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello, I'm the Magic 8 ball!");
            Console.WriteLine("");
        }

        //Function that return the text the user types
        static string GetQuestionFromUser()
        {
        //Ask the user for a question and store it in a string
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Ask me a question: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string questionString = Console.ReadLine(); 

            return questionString;
        }
    }
}
