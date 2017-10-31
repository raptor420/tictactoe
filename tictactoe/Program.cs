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
            Board b = new Board();
            Player h = new Player(true);
            Console.WriteLine("Welcome to Farhan's Tic Tac Toe");
          
            b.PrintBoard();
         

        }

       

        }
    }
}
