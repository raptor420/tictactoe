using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    public class Player
    {
        public  char marker;
      public   bool isHuman;
        public Player()
        { marker = 'X';
            isHuman = true;
        }
       public  Player(bool inIsHuman)
        {
            isHuman = inIsHuman;
            if (inIsHuman)
            {
                marker = 'X';


            }
            else
            {
                marker = 'O';
            }
        }
        public char gerMarker()
        {
            return marker;
        }
        public bool getIsHuman()
        {
            return isHuman;
        }

        public string getPlayerMove()
        {
            if (isHuman)
            {
                return getHumanMove();
            }
            return generateComputerMove();

        }

        public string getHumanMove()
        {
            
            Console.WriteLine();
            Console.WriteLine("Enter move (Column(In Caps), Space, Row Number. )");
            Console.WriteLine("Invalid move will result in a penalty,move will not be counted then.");
            string s = Console.ReadLine();
            Console.WriteLine("Player Move :" + s);
            return s;

        }
        public string generateComputerMove()
        {
            int i;
           
            string[] k = { "A 1", "A 2", "A 3", "B 1", "B 2", "B 3", "C 1", "C 2", "C 3" };
            Random rand = new Random();
            i = rand.Next(0, 8);
            Console.WriteLine("Ai move : " + k[i]);
            return k[i];
        }
    }
}
