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
        }

        public int CountLetter(char guess)
        {
            string charGuess;
            string toUpper;

            throw new System.NotImplementedException();
            if (!char.IsLetter(guess))
            {
                throw new ArgumentException($"Invalid character: {guess}.");
            }
            else 
            {
                charGuess = char.toUpper(guess);
            }
        }

        public string GetFullWord()
        {
            throw new System.NotImplementedException();
        }

        public string GetGuessedLetters()
        {
            throw new System.NotImplementedException();

            string letters;
            letters = string.Empty;

            foreach (char c in this.GetGuessedLetters)
            {
                letters += $"{c}";
            }
            return letters.Trim();
        }

        public int GetGuessLimit()
        {
            throw new System.NotImplementedException();
            return this.guessLimit;
        }

        public int GetIncorrectGuesses()
        {
            throw new System.NotImplementedException();
        }

        public string GetWord()
        {
            throw new System.NotImplementedException();
        }

        public bool IsGameOver()
        {
            throw new System.NotImplementedException();
            return this.incorrectGuesses >= this.guessLimit;
        }

        public bool IsGameWon()
        {
            throw new System.NotImplementedException();
            foreach (char c in this.fullWord)
            {
                if (this.lettersGuessed.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}