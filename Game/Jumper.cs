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
            // string member1 = "_____";
            // parachute.Enqueue(member1);
            // string member2 = "/_____\\";
            // parachute.Enqueue(member2);
            // string member3 = "\\     /";
            // parachute.Enqueue(member3);
            // string member4 = "\\   /";
            // parachute.Enqueue(member4);
            // string member5 = " O ";
            // parachute.Enqueue(member5);
            // string member6 = "/|\\";
            // parachute.Enqueue(member6);
            // string member7 = "/ \\";
            // parachute.Enqueue(member7);
            
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