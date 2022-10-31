using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProject
{
    public class Game
    {
      int playerposition = 0;
      Random random = new Random();
      const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WIN_POSITION = 100;
       public  int DieRoll()
       {
          int die = random.Next(1, 7);
          return die;
       }
       public  void play()
       {
            for (int i = 0; i < WIN_POSITION; i++)
            {
                int check = random.Next(0, 3);
                switch (check)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        this.playerposition += DieRoll();
                        break;
                    case SNAKE:
                        this.playerposition -= DieRoll();
                        if (this.playerposition < 0)
                            this.playerposition = 0;
                        break;
                }
                if(this.playerposition == WIN_POSITION)
                {
                    Console.WriteLine(this.playerposition);
                    return;
                }
            }  
            Console.WriteLine(" Player position is at position " + this.playerposition);
       }
    }
}
