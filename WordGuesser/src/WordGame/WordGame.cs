namespace WordGuesser
{
    using System;
    using System.Collections.Generic;

    public class WordGame : IWordGame
    {

        private string fullWord;
        private int guessLimit;
        private int incorrectGuesses;
        private List<char> guesses;
        private List<char> guessedLetters;
        private string word;
        private string letters;

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
            this.incorrectGuesses = 0;
            this.guesses = new List<char>();
            this.guessedLetters = new List<char>();
            word = string.Empty;
            letters = string.Empty;
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
            foreach (char c in this.guessedLetters)
            {
                letters += $" {c}";
            }
            return letters.Trim();
        }

        public int GetGuessLimit()
        {
            return this.guessLimit;
        }

        public int GetIncorrectGuesses()
        {
            return this.incorrectGuesses;
        }

        public string GetWord()
        {
            foreach (char c in this.fullWord)
            {
                if (this.guessedLetters.Contains(c))
                {
                    word += $"{c} ";
                }
                else
                {
                    word += "_ ";
                }
            }
            return word.Trim();
        }

        public bool IsGameOver()
        {
            return this.incorrectGuesses >= this.guessLimit;
        }

        public bool IsGameWon()
        {
            foreach (char c in this.fullWord)
            {
                if (this.guessedLetters.Contains(c) != true)
                {
                    return false;
                }
            }
            return true;
        }
    }

}