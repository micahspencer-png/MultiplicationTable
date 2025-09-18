using System.Net.Quic;

namespace MultiplicationTable
{
    //Micah Spencer
    //RCET2265
    //Fall 2025
    //Multiplication Table Program
    //https://github.com/micahspencer-png/MultiplicationTable.git
    internal class Program
    {
        static void Main(string[] args)
        {
                //sets variables
                string userInput;
                int number = 12;
                bool quit = false;
            
            do
            {
                //prompts user for input. informs user that there is a default
                Console.WriteLine("Type in What Multiplication Table You Wish to See");
                Console.WriteLine("Press Enter to Use Default 12 x 12");
                userInput = Console.ReadLine();
                
               //runs the multiplication table if there is a number it can use
                try
                {
                    number = int.Parse(userInput);
                    for (int i = 1; i < number + 1; i++)
                    {
                        for (int j = 1; j < number + 1; j++) 
                        {
                            Console.Write((i * j).ToString().PadLeft(3) + " | ");
                        }
                        Console.WriteLine();
                    }
     
                    quit = true;
                }

                //Prompts user to put in correcct number. Runs default if there is no input
                catch
                {
                    if (userInput == "")
                    {
                        
                        for (int i = 1; i < number + 1; i++)
                        {
                            for (int j = 1; j < number + 1; j++)
                            {
                                Console.Write((i * j).ToString().PadLeft(3) + " | ");
                            }
                            Console.WriteLine();
                        }

                        quit = true;
                    }
                    else
                    {

                        Console.WriteLine("Invalid. Try Again");
                        Console.WriteLine();
                        quit = false;
                    }
                }
            } while (quit == false);

            //prompts user to exit program
            Console.WriteLine();
            Console.WriteLine("Press Enter to Quit");

            //pause
            Console.Read();
            
        }
    }
}
