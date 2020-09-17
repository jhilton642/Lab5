using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int hidden;
            while (true)
            {
                hidden = rand.Next(100);
                while (true)
                {
                    Console.WriteLine("Guess a number between 0 an 100 ");
                    string tGuess = Console.ReadLine();
                    int guess = Convert.ToInt32(tGuess);

                    if (guess < 0)
                    {
                        Console.WriteLine("That is not a number between 0 and 100");
                        continue;
                    }
                    if (guess > 100)
                    {
                        Console.WriteLine("That is not a number between 0 and 100");
                        continue;
                    }
                    if (guess < hidden)
                    {
                        Console.WriteLine("To low");
                        continue;
                    }
                    if (guess > hidden)
                    {
                        Console.WriteLine("To high");
                        continue;
                    }
                    if (guess == hidden)
                    {
                        Console.WriteLine("You got it!");
                        break;
                    }
                }
                Console.WriteLine("enter 1 to keep playing and 2 to stop");
                string keepPlaying = Console.ReadLine();
                if(keepPlaying == "1")
                {
                    continue;
                }
                if(keepPlaying == "2")
                {
                    break;
                }
            }
        }
    }
}
