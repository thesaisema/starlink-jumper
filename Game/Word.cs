using System;
using System.Collections.Generic;

namespace jumper.Game
{
    public class Word
    {  
        // Andra can come up with the method that creates random words here
        static string RandomWord = "flying";

        // Get the lenth of the random word
        static int LenOfRandomWord = RandomWord.Length;

        // This method creates and displays dashes
        public List<string> DisplayDash()
        {
            List<string> Dashes = new List<string>();
            for (int i=0; i<LenOfRandomWord; i++)
            {
                Dashes.Add("-");
          }
            return Dashes;
        }

        // This method updates and displays dashes or cuts parachute
        public void UpdateAndDisplayDash()
        {
            // Daniel will create the parachute
            int parachute = 6;
            // This line keeps count of the number of letters that a user has guessed correctly
            int letter_count = LenOfRandomWord;

            List<string> CurrentDash = DisplayDash();
            while (parachute > 0 && letter_count > 0)
            {
                // This line displays the number of letters the user has gotten correctly
                System.Console.WriteLine();
                foreach(var i in CurrentDash) System.Console.Write(i +" ");

                // Ask User for a letter
                System.Console.Write("\n\nGuess a letter [a-z]: ");
                string UserGuess = Console.ReadLine();

                // This checks if the letter is in the randomword or not.
                // If the letter is in the randomword, currenDash gets updated 
                // and letter_count gets reduced by 1, else parachute gets cut
                int char_index = RandomWord.IndexOf(UserGuess);
                if (char_index == -1) 
                {
                    parachute--;
                }
                else
                {
                    CurrentDash[char_index] = UserGuess;
                    letter_count--;
                }
            }
            System.Console.WriteLine("Game Over.");
        }
        //Nwokolo - DisplayBlanks - displays the blank lines
        //Nwokolo - UpdateWord - updates the word after user guess. (could be done in DisplayWord)
        //Andra - GenerateWord - choose random word form list
        //Andra - UserGuess - returns the letter guessed by the user
    }
}