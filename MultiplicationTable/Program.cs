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
                userInput = Console.ReadLine();
                number = int.Parse(userInput);
               
                try
                {
                    
 
                    for (int i = 0; i < number + 1; i++)
                    {
                        for (int j = 0; j < number + 1; j++) 
                        {
                            Console.Write((i * j).ToString().PadLeft(3) + " | ");
                        }
                    }
     
                    quit = true;
                }
                catch
                {
                    Console.WriteLine("Invalid Number. Try Again.");
                    quit = false;
                }
            } while (quit = false);
            
            //pause
            Console.Read();
        }
    }
}
