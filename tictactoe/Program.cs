using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class Program
    {

        static void Main(string[] args)
        {
            bool play = true;
            Board b = new Board();
            Player h = new Player();
            Player ai = new Player(false);
            Console.WriteLine("Welcome to Farhan's Tic Tac Toe");

            b.PrintBoard();
            
          

            while(play)
       
            { 

                b.submitMove(h.getPlayerMove(), h.gerMarker());
                b.PrintBoard();

                b.submitMove(ai.getPlayerMove(), ai.gerMarker());
                Console.WriteLine();
                b.PrintBoard();
                if(b.isWinner(h.gerMarker()) || b.isWinner(ai.gerMarker()) )
                {
                    play = false;
                   // Console.WriteLine(ai.gerMarker());

                }


                //  b.submitMove(ai.getPlayerMove(), ai.gerMarker());
                //NOT SO SMART ai ATM LOL XD 
            }



        }
    }

}