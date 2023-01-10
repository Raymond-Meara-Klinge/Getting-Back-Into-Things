
namespace RockPaperScissors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Random random = new();
            int wins = 0;
            int losses = 0;
            int draws = 0;
            Console.WriteLine("''You, me , Rock, Paper, Scissors, NOW!''");
            Console.ReadKey();
            while (true)
            {
            GetInput:
                Console.WriteLine("Type 'Rock', 'Paper', or 'Scissors' to continue, or 'Flee' to flee like a coward.");
                Move playerMove;
                switch (Convert.ToString(Console.ReadLine()))
                {
                    case "rock" or "ROCK" or "Rock" or "r":
                        Console.WriteLine("You chose rock");

                        playerMove = Move.Rock;
                        break;
                    case "paper" or "PAPER" or "Paper" or "p":
                        Console.WriteLine("You chose paper");
                        playerMove = Move.Paper;
                        break;
                    case "scissors" or "SCISSORS" or "Scissors" or "s":
                        Console.WriteLine("You chose scissors");
                        playerMove = Move.Scissors;
                        break;
                    case "flee" or "FLEE" or "Flee" or "f":
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Input not recognized, try again.");
                        Thread.Sleep(500);
                        Console.Clear();
                        goto GetInput;
                }
                Move oppMove = (Move)random.Next(3);
                Console.WriteLine($"''I choose {oppMove}.''");
                switch (playerMove, oppMove)
                {
                    case (Move.Rock, Move.Scissors):
                    case (Move.Paper, Move.Rock):
                    case (Move.Scissors, Move.Paper):
                        Console.WriteLine("''That's a win for you.''");
                        wins++;
                        break;
                    case (Move.Rock, Move.Paper):
                    case (Move.Scissors, Move.Rock):
                    case (Move.Paper, Move.Scissors):
                        Console.WriteLine("''That's a win for me.''");
                        losses++;
                        break;
                    default:
                        Console.WriteLine("''That's a draw.''");
                        draws++;
                        break;
                }
                Console.WriteLine($"Wins: {wins}");
                Console.WriteLine($"Losses: {losses}");
                Console.WriteLine($"draws: {draws}");
                Console.ReadKey();
                Console.Clear();

            }
        }
        enum Move
        {
            Rock = 0,
            Paper = 1,
            Scissors = 2,
        }
    }
}