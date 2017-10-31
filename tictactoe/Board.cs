using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class Board
    { static char [,]  gameBoard = new  char [3, 3];
        public static int row, col;

        public Board()
        {for (int i = 0; i <3; i++)
            {for(int j = 0; j <3 ; j++)
                {
                    gameBoard[i,j] = '_';

                }

            }


        }
        public void PrintBoard()
        {
            Console.Write("  A " + "B " + "C ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
           
                Console.Write(i+1);
                Console.Write("|");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write( gameBoard[i,j] + "|");
                    

                }
            }


        }
       public  bool submitMove(string move,char player)
        {//if else condition is left for this method
            
            string[] m = move.Split(' ');
            char column = char.Parse(m[0]);
            if(column == 'A')
            {
                col = 0;
}
            if (column == 'B')
            {
                col = 1;
            }
            if (column == 'C')
            {
                col = 2;
            }
            
             row = int.Parse(m[1])-1;
            if (gameBoard[row, column] == '_')
            {
                gameBoard[row, col] = player;
                return true;
            }
            else return false;
          


        }

       public  bool isWinner(char player)
        {
            if (gameBoard[0,col] == gameBoard[1,col] && gameBoard[0,col] == gameBoard[2,col])
                return true;
            if (gameBoard[row,0] == gameBoard[row,1] && gameBoard[row,0] == gameBoard[row,2])
                return true;
            if (gameBoard[0,0] == gameBoard[1,1] && gameBoard[0,0] == gameBoard[2,2]
                    && gameBoard[1,1] != '_')
                return true;
            if (gameBoard[2,0] == gameBoard[1,1] && gameBoard[2,0] == gameBoard[0,2] && gameBoard[1,1] != '_')
                return true;
            return false;
        }

       public  bool isMoveValid (string move)
        {  if (move == "A1 " || move == "A2" || move == "A3" || move == "B1" || move == "B2" || move == "B3" || move == "C1" || move == "C2" || move == "C3")
            {
                return true;
            }
            return false;
        }

    }
}
