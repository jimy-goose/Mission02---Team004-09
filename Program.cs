﻿using Mission02___Team004_09;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Driver
{
    public static void Main()
    {

       
        Console.WriteLine("Welcome to Tic Tac Toe!");

        string[] board = new string[9];
        string[] guessed = new string[9];
        for (int i = 0; i < 6; i++)
        {
            board[i] = "_";
        }
        for (int i = 6; i < 9; i++)
        {
            board[i] = " ";
        }

        Board b = new Board(board);

        string playerChoice = "";

        string winnerName = "";

        bool done = false;

        // Set Counter Variables
        int I = 0;
        int cell = 0;
        int guesser = 0;
        Console.WriteLine("  1 2 3");
        Console.WriteLine("a _|_|_");
        Console.WriteLine("b _|_|_");
        Console.WriteLine("c  | | ");
        do
        {
            Console.WriteLine("Player " + (I +1) + "'s Turn. Please enter where you would like to play." + "(e.g. a1, b3");
            playerChoice = Console.ReadLine();
            char letterChoice = playerChoice[0];
            char numberChoice = playerChoice[1];
            
            int intNumberChoice = int.Parse(numberChoice.ToString());

            if ((letterChoice == 97 || letterChoice == 98 || letterChoice == 99) && (numberChoice > 48 && numberChoice < 52))
            {
                if (Array.IndexOf(guessed, playerChoice) != -1)
                {

                    Console.WriteLine("Invalid guess try again");
                }
                else
                {
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
                        I += 1;
                        if(b.checkBoard(board) == true)
                        {
                            Console.WriteLine("Yay! Player " + (I) + " Wins");
                            done = true;
                        }

                    }
                    else if (I == 1)
                    {
                        guessed[guesser] = playerChoice;
                        guessed[cell] = playerChoice;
                        board[cell] = "O";
                        Console.WriteLine(b.ChangeBoard(board));
                        I -= 1;
                        if (b.checkBoard(board) == true)
                        {
                            Console.WriteLine("Yay! Player " + (I + 2) + " Wins");
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
        Console.ReadLine();
    }
   
}