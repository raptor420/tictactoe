using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class Player
    {
        public static char marker  ;
      public  static bool isHuman;
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
            marker = 'O';

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
            string s;
            Console.WriteLine("Enter move");
            s = Console.ReadLine();
            return s;

        }
        public string generateComputerMove()
        {
            int i;
            string s;
            string[] k = { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3" };
            Random rand = new Random();
            i = rand.Next(0, 9);

            return k[i];
        }
    }
}
