using System;

namespace SnakeLadderProject
{
   class Program
   {
      static void Main(string[] args)
      {
        Console.WriteLine(" Welcome to Snake and Ladder ");
        Game newgame = new Game();
        newgame.play();
      }
   }
}