using System;

namespace jumper.Game
{
    public class Word
    {  
        //Andra - GenerateWord - choose random word form list
        //Nwokolo - DisplayBlanks - displays the blank lines
        //Andra - UserGuess - returns the letter guessed by the user
        //Nwokolo - UpdateWord - updates the word after user guess. (could be done in DisplayWord)
        public string GenerateWord(){
            string[] wordList = {"flying", "jump", "death", "adventure", "crazy", "penguins", "manley"};
            Random rnd = new Random();
            int random = rnd.Next(0, (wordList.Length + 1));//code for generating a random word from the list
            string randWord = wordList[random];
            return randWord;
        }

        public string UserGuess(){
            string guess;
            Console.Write("Guess a letter [a-z]: ");
            guess = Console.ReadLine();
            return guess;
        }

    }
}