namespace DiceGame
{
    public class Program
    {
        private int _rolled;

        public static void Main(string[] args)
        {

            Console.Clear();
            int[] rounds = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("SURPRISE DICE GAME! Beat your opponent to, I don't know, look cool I guess?");
            int load = 0;
            int OppScore = 0;
            int YourScore = 0;
            Console.ReadKey();
            foreach (int round in rounds)
            {
                if (round != 11)
                {
                    Random rnd = new Random();
                    int OppRoll = rnd.Next(1, 6);
                    Console.WriteLine($"Your opponent rolled a {OppRoll}.");
                    Console.ReadKey();
                    Random rad = new Random();
                    int YourRoll = rad.Next(1, 6);
                    Console.WriteLine($"You rolled a {YourRoll}.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (OppRoll > YourRoll)
                    {
                        Console.WriteLine("Your opponent wins this match.");
                        OppScore++;
                    }
                    else if (OppRoll == YourRoll)
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else
                    {
                        Console.WriteLine("You win this match.");
                        YourScore++;
                    }
                    Thread.Sleep(500);
                    Console.WriteLine($"Opponent's Score: {OppScore}");
                    Console.WriteLine($"Your Score: {YourScore}");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("And the final result of this dice game is");
            while (load < 3)
            {
                Console.Write(".");
                Thread.Sleep(500);
                load++;
            }
            if (OppScore > YourScore)
            {
                Console.WriteLine("you lose, may luck be in your favor next time.");
            }
            else if (OppScore == YourScore)
            {
                Console.WriteLine("YOU WIN! Against the odds you pulled through, congrats, until next time.");
            }
            else
            {
                Console.WriteLine("a draw? Curious, that's pretty rare, what are the odds?");
            }
        }
    }
}