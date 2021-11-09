

namespace WordGuesser
{
    using System;
    using System.Collections.Generic;
    public class WordGame : IWordGame
    {

        private string fullWord;
        private List<char> lettersGuessed;
        private int incorrectGuesses;
        private int guessLimit;

        public WordGame(string wordToGuess, int guessLimit)
        {
            if (guessLimit <= 0)
            {
                throw new ArgumentException($"Illegal guessLimit '{guessLimit}'. The guess limit must be greater than 0.");
            }

            foreach (char c in wordToGuess)
            {
                if (char.IsLetter(c) == false)
                {
                    throw new ArgumentException($"Illegal word '{wordToGuess}'. The word must contain only letters.");
                }
            }
        
            // TODO: Initialize member variables
            this.fullWord = wordToGuess;
            this.guessLimit = guessLimit;
            this.incorrectGuesses = 0;
            this.lettersGuessed = new List<char>();
        }
        public string CheckGuess(string guess)
        {
            throw new System.NotImplementedException();
            //Janet
        }

        public int CountLetter(char guess)
        {
            throw new System.NotImplementedException();
            //Lucia
        }

        public string GetFullWord()
        {
            throw new System.NotImplementedException();
            //Janet
        }

        public string GetGuessedLetters()
        {
            throw new System.NotImplementedException();
            //Lucia
        }

        public int GetGuessLimit()
        {
            throw new System.NotImplementedException();
            //Janet
        }

        public int GetIncorrectGuesses()
        {
            throw new System.NotImplementedException();
            //Lucia
        }

        public string GetWord()
        {
            throw new System.NotImplementedException();
            //Janet
        }

        public bool IsGameOver()
        {
            throw new System.NotImplementedException();
            //Lucia

        }

        public bool IsGameWon()
        {
            throw new System.NotImplementedException();
            //Janet
        }
    }
}