using System.Net.Quic;

namespace MultiplicationTable
{
    //Micah Spencer
    //RCET2265
    //Fall 2025
    //Multiplication Table Program
    //
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
                int number = 12;
                bool quit = false;
            
            do
            {
                
                Console.WriteLine("Type in What Multiplication Table You Wish to See");
                Console.WriteLine("Press Enter to Use Default 12 x 12");
                userInput = Console.ReadLine();
                
               
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

            Console.WriteLine();
            Console.WriteLine("Press Enter to Quit");

            //pause
            Console.Read();
            
        }
    }
}
