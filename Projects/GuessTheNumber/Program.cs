namespace GuessTheNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Random rnd = new Random();
            int num = rnd.Next(999);
            Console.WriteLine("Guess a number between 1 and 999. I've picked a number for you to guess, and I will let you know if and when you're close.");
            long guess = Convert.ToInt32(Console.ReadLine());
            while (guess != num)
            {
                if (guess < num)
                {
                    Console.WriteLine("That number is too low.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    guess = Convert.ToInt32(Console.ReadLine());
                    continue;
                }
                else if (guess > num)
                {
                    Console.WriteLine("That number is too high.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    guess = Convert.ToInt32(Console.ReadLine());
                    continue;
                }
                break;
            }
            Console.WriteLine("That's it! Thanks for playing, see you next time!");
        }
    }
}