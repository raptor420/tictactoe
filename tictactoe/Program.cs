using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class Program
    {
        //static String re;
        static bool play = true;
        static Board b = new Board();
        static Player h = new Player(true);
        static Player ai = new Player(false);
        public int ass;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Farhan's Tic Tac Toe");

            b.PrintBoard();
            Play();


        }


            /*if(b.isWinner(h.gerMarker()) || b.isWinner(ai.gerMarker()))
                            {
                                if(AiMoveCounter> HMoveCounter)
                                {

                                    Console.WriteLine("Player wins");
                                }
                                if (HMoveCounter > AiMoveCounter)
                                {

                                    Console.WriteLine("Ai Wins");
                                } 

                            }*/


/* Console.WriteLine("GAME OVER" + "Press R to play again");
 re = Console.ReadLine();
 if (re == "R")
 {
     Board c= new Board();
     play = true;
     Play();




 }

}*/




//  b.submitMove(ai.getPlayerMove(), ai.gerMarker());
//NOT SO SMART ai ATM LOL XD 

public static void Play()
{
 while (play)

 {

     b.submitMove(h.getPlayerMove(), h.gerMarker());
                ;
     b.PrintBoard();
     if (b.isWinner(h.gerMarker()))
     {
         play = false;
         break;

     }


     b.submitMove(ai.getPlayerMove(), ai.gerMarker());
     Console.WriteLine();
     b.PrintBoard();
     if (b.isWinner(ai.gerMarker())) { play = false; }

 }


}
}

}
 
 