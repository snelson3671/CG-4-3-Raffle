using System;

namespace CG_4_3_Raffle
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask the user to enter up to 30 names
            Console.WriteLine("Sandra's Raffle!");
            Console.WriteLine("Enter up to 30 names of people who would like to enter the raffle.");
            Console.WriteLine("Press enter after each name.  Then press enter twice when you are finished.");

            //initialize an integer variable called numberOfNames
            int numberOfNames = 0;

            //create a string array called allNames with 30 elements in it
            string[] allNames = new string[30];

            //loop through each time the user hits enter to see if 
            //the user types another name or hits enter twice
            for (int i = 0; i <= 30; i++)
            {
                string name = Console.ReadLine();
                if (name == "")
                    break;
                
                //store all the names the user types into the array allNames
                allNames[i] = name;
                numberOfNames = i;
            }

            //have the code pick a position in the array allNames at random
            //store that number in an integer variable called raffleWinner
            Random pickAName = new Random();
            int raffleWinner = pickAName.Next(0, numberOfNames);

            //print the name that is in that position to the console
            Console.WriteLine("The winner is " + allNames[raffleWinner]);

            //create a foreach loop
            //loop through each name the user has typed to see if it's in the raffleWinner position
            foreach (string name in allNames)
            {
                //if a name is empty, break and to go the Console.WriteLine
                if (name == null)
                    break;

                //if a name is in the raffleWinner position, do nothing
                if (allNames[raffleWinner] == name)
                    continue;
                
                //print each name to the console + you lost
                Console.WriteLine(name + " you lost");
            }

            Console.ReadLine();

            
        }
    }
}
