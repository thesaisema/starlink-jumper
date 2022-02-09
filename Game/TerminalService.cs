using System;

namespace jumper.Game
{
    public class TerminalService
    {  
        Word Text = new Word();

        // 

        public static void ReadText()
        {
            Text.UserGuess();
        }
        public static void WriteText()
        {
            Text.DisplayDash();
        }
        // Sai
        // ReadText
        // WriteText
    }
}