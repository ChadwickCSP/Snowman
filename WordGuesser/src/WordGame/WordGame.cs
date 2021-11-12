namespace WordGuesser
{
    using System;
    using System.Collections.Generic;

    public class WordGame : IWordGame
    {
        private string fullWord;
        private int guessLimit;
        private int incorrrectGuesses;
        private List<char> guesses;

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

            this.fullWord = wordToGuess.ToUpper();
            this.guessLimit = guessLimit;
            this.incorrrectGuesses = 0;
            this.guesses = new List<char>();

        }

        public string CheckGuess(string guess)
        {
            throw new System.NotImplementedException();
        }

        public int CountLetter(char guess)
        {
            throw new System.NotImplementedException();
        }

        public string GetFullWord()
        {
            return this.fullWord;
        }

        public string GetGuessedLetters()
        {
            throw new System.NotImplementedException();
        }

        public int GetGuessLimit()
        {
            return this.guessLimit;
        }

        public int GetIncorrectGuesses()
        {
            return this.incorrrectGuesses;
        }

        public string GetWord()
        {
            throw new System.NotImplementedException();
        }
        // Austins methods
        public bool IsGameOver()
        {
            return this.incorrrectGuesses >= this.guessLimit;
        }
        // Austins methods
        public bool IsGameWon()
        {
            foreach (char c in this.fullWord)
            {
                if (this.guesses.Contains(c) === false)
                {
                    return false;
                }
                return true; 
            }
        }
    }

}