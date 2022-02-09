using System;
using System.Collections.Generic;

namespace jumper.Game
{
    public class Jumper
    {  
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
        public static Queue<string> MakeParachute()
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
        // public static void MakeEndGameDisplay()
        // {
        //     Queue<string> parachute = new Queue<string>();
        //     parachute.Enqueue("     X ");
        //     parachute.Enqueue("    /|\\");
        //     parachute.Enqueue("    / \\");
        //     parachute.Enqueue("\n^^^^^^^^^^^");
        //     return parachute;
        // }
        // public static Queue<string> EndGameParachute = EndGameDisplay();
        // public static void DisplayEndGameParachute()
        // {
        //     foreach(var i in EndGameParachute) System.Console.WriteLine(i);
        // }

        //Daniel - MakeChute
        //Daniel - CutChute




    }
}