using System;
using System.Collections.Generic;

namespace jumper.Game
{
    public class Jumper
    {  
        //Daniel - MakeChute
        //Daniel - CutChute
        /**
          _____
         /_____\
         \     /
          \   /
            O 
           /|\
           / \
       ^^^^^^^^^^^
       
        **/
        private static Queue<string> MakeParachute()
        {
            Queue<string> parachute = new Queue<string>();
            parachute.Enqueue("   _____");
            parachute.Enqueue("  /_____\\");
            parachute.Enqueue("  \\     /");
            parachute.Enqueue("   \\   /");
            parachute.Enqueue("     O ");
            parachute.Enqueue("    /|\\");
            parachute.Enqueue("    / \\");
            parachute.Enqueue("\n^^^^^^^^^^^");
            return parachute;
        }
        public static Queue<string> Parachute = MakeParachute();
        public int LenOfParachut = Parachute.Count;

        public void DisplayParachute()
        {
            foreach(var i in Parachute) System.Console.WriteLine(i);
        }
        public void CutParachute()
        {
            DisplayParachute();
            Parachute.Dequeue();

        }

        // This code when implemented will control the final display when the game is over.
        // public static Queue<string> EndGameParachute()
        // {
        //     Queue<string> parachute = new Queue<string>();
        //     parachute.Enqueue("     X ");
        //     parachute.Enqueue("    /|\\");
        //     parachute.Enqueue("    / \\");
        //     parachute.Enqueue("\n^^^^^^^^^^^");
        //     return parachute;
        // }
        // public static Queue<string> EndOfGameParachute = EndGameParachute();

        // public void DisplayEndOfGameParachute()
        // {
        //     foreach(var i in EndOfGameParachute) System.Console.WriteLine(i);
        //     System.Console.WriteLine("It's Game Over");
        // }

    }
}