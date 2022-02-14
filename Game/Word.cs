using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace jumper.Game
{
    public class Word
    {  
        // Creating a jumper object
        Jumper jump = new Jumper();
        // This method generates random word from a list of words
        private static string GenerateWord(){
            string[] wordList = {"flying", "jump", "death", "adventure", "crazy", "penguins", "manley"};
            Random rnd = new Random();
            int random = rnd.Next(0, (wordList.Length - 1));//code for generating a random word from the list
            string randWord = wordList[random];
            return randWord;
        }

        // This method prompts the user for a letter
        private string UserGuess(){
            string guess;
            Console.Write("Guess a letter [a-z]: ");
            guess = Console.ReadLine();
            return guess;
        }

        // Get a random word and the lenth of the random word
        private static string RandomWord = GenerateWord();
        int LenOfRandomWord = RandomWord.Length;
        private static List<string> StringToList()
        {
            List<string> stringToList = new List<string>();
            foreach(var i in RandomWord) stringToList.Add(i.ToString());
            return stringToList;
        }

        // This method creates dashes based on the length of the random word
        private List<string> CreateDash()
        {
            List<string> Dashes = new List<string>();
            for (int i=0; i<LenOfRandomWord; i++)
            {
                Dashes.Add("-");
          }
            return Dashes;
        }

        // This method updates and displays dashes or cut parachute
        public void DisplayDash()
        {
            // These lines of code controls the condition for ending the game
            int LenOfParachute = jump.LenOfParachut - 3;
            int letter_count = LenOfRandomWord;

            // Generating the dash lines will will be displaying to the user
            List<string> CurrentDash = CreateDash();
            while (LenOfParachute > 0 && letter_count > 0)
            {
                // This line displays the number of letters the user has gotten correctly
                System.Console.WriteLine();
                foreach(var i in CurrentDash) System.Console.Write(i +" ");
                System.Console.WriteLine();

                jump.DisplayParachute();

                string userGuess = UserGuess();

                // This checks if the letter is in the randomword or not.
                // If the letter is in the randomword, currenDash gets updated 
                // and letter_count gets reduced by 1, else parachute gets cut
                List<string> stringToList = StringToList();
                int char_index = stringToList.IndexOf(userGuess);
                if (char_index == -1) 
                {
                    jump.CutParachute();
                    LenOfParachute--;
                }
                else
                {
                    CurrentDash[char_index] = userGuess;
                    stringToList.Remove(userGuess);
                    letter_count--;
                }
            }
            System.Console.WriteLine("Thanks for playing.");
        }
    }
}