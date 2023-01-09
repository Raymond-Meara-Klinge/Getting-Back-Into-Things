
namespace RockPaperScissors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("''You, me , Rock, Paper, Scissors, NOW!''");
            Console.ReadKey();
            while (true)
            {
                Console.WriteLine("Type 'Rock', 'Paper', or 'Scissors' to continue, or 'Run' to flee like a coward.");
                string response = Convert.ToString(Console.ReadLine());
                switch{
                    case "rock" or "ROCK" or "Rock" or "r":
                }
            }
        }
        enum Move()
        {
            Rock = 0;
            Paper=1;
            Scissors=2;
        }
}
}