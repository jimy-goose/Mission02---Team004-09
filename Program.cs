using Mission02___Team004_09;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Driver
{
    public static void Main()
    {


        Console.WriteLine("Welecome to Tic Tac Toe");

        string[] board = new string[9];
        string[] guessed = new string[9];

        Board b = new Board(board);

        string playerChoice = "";

        string winnerName = "";

        bool done = false;

        // Set Counter Variables
        int I = 0;
        int cell = 0;
        int guesser = 0;
        do
        {
            Console.WriteLine("Player " + (I + 1) + "s Turn (e.g. a1, b3");
            playerChoice = Console.ReadLine();
            char letterChoice = playerChoice[0];
            char numberChoice = playerChoice[1];

            

            if ((letterChoice == 97 || letterChoice == 98 || letterChoice == 99) && (numberChoice > 48 && numberChoice < 52))
            {
                if (Array.IndexOf(guessed, playerChoice) != -1)
                {

                    Console.WriteLine("Invalid guess try again");
                }
                else
                {
                    int intNumberChoice = int.Parse(numberChoice.ToString());
                    if (letterChoice == 97)
                    {
                        cell = intNumberChoice - 1;
                    }
                    if (letterChoice == 98)
                    {
                        cell = intNumberChoice + 2;
                    }
                    if (letterChoice == 99)
                    {
                        cell = intNumberChoice + 5;
                    }
                    if (I == 0)
                    {
                        guessed[guesser] = playerChoice;
                        board[cell] = "X";
                        Console.WriteLine(b.ChangeBoard(board));
                        Console.ReadLine();
                        I += 1;
                        if (b.checkBoard(board) == true)
                        {
                            done = true;
                        }
                    }
                    else if (I == 1)
                    {
                        guessed[guesser] = playerChoice;
                        guessed[cell] = playerChoice;
                        board[cell] = "O";
                        Console.WriteLine(b.ChangeBoard(board));
                        Console.ReadLine();
                        I -= 1;
                        if (b.checkBoard(board) == true)
                        {
                            done = true;
                        }
                    }
                    guesser++;

                }
            }
            else
            {
                Console.WriteLine("Invalid guess try again");
            }


        } while (!done);

    }

}