using System;

namespace free_rps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var choice = "";
            int playerNum = 0;
            int compNum = 0;

            while (choice != null)
            {
                System.Console.WriteLine("Choose: \n-> Rock \n-> Paper \n-> Scissors");
                string[] options = new string[3] { "Rock", "Paper", "Scissors" };

                Random random = new Random();
                int num = random.Next(0, 3);
                System.Console.WriteLine("What Choice Will Lead To VICTORY?");
            }
        }
    }
}
