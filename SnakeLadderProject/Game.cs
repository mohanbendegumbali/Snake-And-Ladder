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
       public void DieRoll()
        {
          int die = random.Next(1, 7);
          Console.WriteLine(" Die value " + die);
        }

    }
}
