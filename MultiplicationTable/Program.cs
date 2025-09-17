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
            Console.WriteLine("Type in What Multiplication Table You Wish to See");
            userInput = Console.ReadLine();
            number = int.Parse(userInput);

            for (int i = 0; i < number; i++)
            {

            }

            //pause
            Console.Read();
        }
    }
}
