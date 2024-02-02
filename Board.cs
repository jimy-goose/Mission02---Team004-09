using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission02___Team004_09
{
    internal class Board
    {
        string[] board;
        public Board(string[] theBoard)
        {
                this.board = theBoard;      
        }
        public string ChangeBoard(string[] theBoard)
        {

            string output = "  1 2 3\n";
            for (int i = 0; i < theBoard.Length; i++)
            {
                if (i == 3 || i == 6) { output += "\n"; }
                if (i == 0) {  output += "a "; }
                if (i == 3) { output += "b "; }
                if (i == 6) { output += "c "; }
                if (theBoard[i] == null)
                {
                    if (i == 0 || i == 1 || i == 3 || i == 4)
                    {
                        output += "_|";
                    }
                    else if (i == 6 || i == 7)
                    {
                        output += " |";
                    }
                    else if (i == 8)
                    {
                        output += "";
                    }
                    else
                    {
                        output += "_";
                    }
                }
                else
                {
                    if (i == 0 || i == 1 || i == 3 || i == 4 || i == 6 || i == 7)
                    {
                        output += theBoard[i] + "|";
                    }
                    else
                    {
                        output += theBoard[i];
                    }
                }
            }

            return output;
        }

        public bool checkBoard(string[] theBoard)
        {
            bool over = false;
            string scen1 = theBoard[0] + theBoard[1] + theBoard[2];
            string scen2 = theBoard[3] + theBoard[4] + theBoard[5];
            string scen3 = theBoard[6] + theBoard[7] + theBoard[8]; 
            string scen4 = theBoard[0] + theBoard[3] + theBoard[6]; 
            string scen5 = theBoard[1] + theBoard[4] + theBoard[7];
            string scen6 = theBoard[2] + theBoard[5] + theBoard[8];
            string scen7 = theBoard[0] + theBoard[4] + theBoard[8];
            string scen8 = theBoard[2] + theBoard[4] + theBoard[6];
            int whatScen = 0;

            if (scen1 == "XXX" || scen1 == "OOO")
            {
                over = true;
                whatScen = 1;
            }
            else if (scen2 == "XXX" || scen2 == "OOO")
            {
                over = true;
                whatScen = 2;

            }
            else if (scen3 == "XXX" || scen3 == "OOO")
            {
                over = true;
                whatScen = 3;

            }
            else if (scen4 == "XXX" || scen4 == "OOO")
            {
                over = true;
                whatScen = 4;

            }
            else if (scen5 == "XXX" || scen5 == "OOO")
            {
                over = true;
                whatScen = 5;

            }
            else if (scen6 == "XXX" || scen6 == "OOO")
            {
                over = true;
                whatScen = 6;

            }
            else if (scen7 == "XXX" || scen7 == "OOO")
            {
                over = true;
                whatScen = 7;

            }
            else if (scen8 == "XXX" || scen8 == "OOO")
            {
                over = true;
                whatScen = 8;

            }
            //who won?
            if (whatScen == 1)
            {
                if (scen1 == "OOO")
                {
                    Console.WriteLine("O's won");
                }
                else
                {
                    Console.WriteLine("X's won");
                }
            } else if (whatScen == 2)
            {
                if (scen2 == "OOO")
                {
                    Console.WriteLine("O's won");
                }
                else
                {
                    Console.WriteLine("X's won");
                }
            } else if (whatScen ==3)
            {
                if (scen3 == "OOO")
                {
                    Console.WriteLine("O's won");
                }
                else
                {
                    Console.WriteLine("X's won");
                }
            } else if (whatScen == 4)
            {
                if (scen4 == "OOO")
                {
                    Console.WriteLine("O's won");
                }
                else
                {
                    Console.WriteLine("X's won");
                }
            } else if (whatScen == 5)
            {
                if (scen5 == "OOO")
                {
                    Console.WriteLine("O's won");
                }
                else
                {
                    Console.WriteLine("X's won");
                }
            } else if (whatScen == 6)
            {
                if (scen6 == "OOO")
                {
                    Console.WriteLine("O's won");
                }
                else
                {
                    Console.WriteLine("X's won");
                }
            } else if (whatScen == 7)
            {
                if (scen7 == "OOO")
                {
                    Console.WriteLine("O's won");
                }
                else
                {
                    Console.WriteLine("X's won");
                }
            } else if (whatScen == 8)
            {
                if (scen8 == "OOO")
                {
                    Console.WriteLine("O's won");
                }
                else
                {
                    Console.WriteLine("X's won");
                }
            }

            return over;
        }
    }
}
