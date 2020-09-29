using System;
using System.Globalization;

namespace rockpaperscrissor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1 - rock
             * 2 - paper
             * 3 - scrissors
             */
            Random rnd = new Random();
            //Console.WriteLine("What is your choice? \n [ROCK, PAPER, SCRISSORS]");
            int computerNumber = rnd.Next(1, 4);
            //bool end = false;
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
            int usercounter = 0;
            int pccounter = 0;

            while (pccounter < 3 && usercounter < 3)
            {
                Console.WriteLine("What's your choice? \n [ROCK, PAPER, SCRISSORS]");
                string userInput = Console.ReadLine().ToLower();

                if (computerNumber == 1 && userInput == "rock")
                {
                    Console.WriteLine("Computer chose rock, draw.");
                    computerNumber = rnd.Next(1, 4);
                    Console.WriteLine($"Your score - {usercounter} / Computer score {pccounter}.");
                    //end = false;
                }
                else if (computerNumber == 2 && userInput == "paper")
                {
                    Console.WriteLine("Computer chose paper, draw.");
                    computerNumber = rnd.Next(1, 4);
                    Console.WriteLine($"Your score - {usercounter} / Computer score {pccounter}.");
                    //end = false;
                }
                else if (computerNumber == 3 && userInput == "scrissors")
                {
                    Console.WriteLine("Computer chose scrissors, draw.");
                    computerNumber = rnd.Next(1, 4);
                    Console.WriteLine($"Your score - {usercounter} / Computer score {pccounter}.");
                    //end = false;
                }
                else if (computerNumber == 1 && userInput == "paper")
                {
                    Console.WriteLine("Computer chose rock, you win!");
                    computerNumber = rnd.Next(1, 4);
                    usercounter = usercounter + 1;
                    Console.WriteLine($"Your score - {usercounter} / Computer score {pccounter}.");
                    //end = false;
                }
                else if (computerNumber == 2 && userInput == "scrissors")
                {
                    Console.WriteLine("Computer chose paper, you win!");
                    computerNumber = rnd.Next(1, 4);
                    usercounter = usercounter + 1;
                    Console.WriteLine($"Your score - {usercounter} / Computer score {pccounter}.");
                    //end = false;
                }
                else if (computerNumber == 3 && userInput == "rock")
                {
                    Console.WriteLine("Computer chose scrissors, you win!");
                    computerNumber = rnd.Next(1, 4);
                    usercounter = usercounter + 1;
                    Console.WriteLine($"Your score - {usercounter} / Computer score {pccounter}.");
                    //end = false;
                }
                else if (computerNumber == 1 && userInput == "scrissors")
                {
                    Console.WriteLine("Computer chose rock, you lose!");
                    computerNumber = rnd.Next(1, 4);
                    pccounter = pccounter + 1;
                    Console.WriteLine($"Your score - {usercounter} / Computer score {pccounter}.");
                    //end = false;
                }
                else if (computerNumber == 2 && userInput == "rock")
                {
                    Console.WriteLine("Computer chose paper, you lose!");
                    computerNumber = rnd.Next(1, 4);
                    pccounter = pccounter + 1;
                    Console.WriteLine($"Your score - {usercounter} / Computer score {pccounter}.");
                    //end = false;
                }
                else if (computerNumber == 3 && userInput == "paper")
                {
                    Console.WriteLine("Computer chose scrissors, you lose!");
                    computerNumber = rnd.Next(1, 4);
                    pccounter = pccounter + 1;
                    Console.WriteLine($"Your score - {usercounter} / Computer score {pccounter}.");
                    //end = false;
                }
                else
                {
                    Console.WriteLine("That's not an option.");
                    //end = false;
                }
            }
        }
    }
}
