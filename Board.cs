﻿using System;
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

            string output = "";
            for (int i = 0; i < theBoard.Length; i++)
            {
                if (i == 3 || i == 6) { output += "\n"; }
                if (theBoard[i] == "")
                {
                    if (i == 0 || i == 1 || i == 3 || i == 4 || i == 6 || i == 7)
                    {
                        output += "_|";
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

            if (scen1 == "xxx" || scen1 == "ooo")
            {
                over = true;
            }
            else if (scen2 == "xxx" || scen2 == "ooo")
            {
                over = true;
            } else if (scen3 == "xxx" || scen3 == "ooo")
            {
                over = true;
            } else if (scen4 == "xxx" || scen4 == "ooo")
            {
                over = true;
            } else if (scen5 == "xxx" || scen5 == "ooo")
            {
                over = true;
            } else if (scen6 == "xxx" || scen6 == "ooo")
            {
                over = true;
            } else if (scen7 == "xxx" || scen7 == "ooo")
            {
                over = true;
            } else if (scen8 == "xxx" || scen8 == "ooo")
            {
                over = true;
            }

            return over;
        }
    }
}