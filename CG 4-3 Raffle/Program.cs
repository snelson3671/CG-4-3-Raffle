using System;

namespace CG_4_3_Raffle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sandra's Raffle!");
            Console.WriteLine("Enter up to 30 names of people who would like to enter the raffle.");
            Console.WriteLine("Press enter after each name.  Then press enter twice when you are finished.");

            int numberOfNames = 0;
            string[] allNames = new string[30];

            for (int i = 0; i <= 30; i++)
            {
                string name = Console.ReadLine();
                if (name == "")
                    break;

                allNames[i] = name;
                numberOfNames = i;
            }

            Random pickAName = new Random();
            int raffleWinner = pickAName.Next(0, numberOfNames);
            Console.WriteLine("The winner is " + allNames[raffleWinner]);

            foreach (string name in allNames)
            {
                if (name == null)
                    break;
                    
                if (allNames[raffleWinner] == name)
                    continue;

                Console.WriteLine(name + " you lost");
            }

            Console.ReadLine();

            
        }
    }
}
