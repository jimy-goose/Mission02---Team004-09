public class Driver
{
    public static void Main()
    {
        Console.WriteLine("Welecome to Tic Tac Toe");

        string[] board = new string[9];

        string playerChoice = "";

        string winnerName = "";

        bool done = false;

        do
        {
            Console.WriteLine("Player 1's Turn");
            string p1Choice = Console.ReadLine();
            

            
            Console.WriteLine(printboard());
            done, winnerName = CheckWinner();
            
            Console.WriteLine("Player 2's Turn");
            string p2Choice = Console.ReadLine();
            Console.WriteLine(printboard());
            done, winnerName = CheckWinner();

        } while (!done);
        
    }
}