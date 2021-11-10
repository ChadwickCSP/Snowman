namespace WordGuesser
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

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
                throw new ArgumentExcept($"Illegal guessLimit '{guessLimit}'. The guess limit must be greater than 0.");
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
            if (guess = AttributeTargetsfullWord)
            {
                return "Your Guess is correct.";
            }
            else
            {
                return "Your Guess is incorrect.";
            }

            throw new System.NotImplementedException();
        }

        public int CountLetter(char guess)
        {
            if (guess = i)
            throw new System.NotImplementedException();
        }

        public string GetFullWord()
        {
            throw new System.NotImplementedException();
        }

        public string GetGuessedLetters()
        {
            throw new System.NotImplementedException();
        }

        public int GetGuessLimit()
        {
            throw new System.NotImplementedException();
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
        }

        public bool IsGameWon()
        {
            throw new System.NotImplementedException();
        }
    }

    [Serializable]
    internal class ArgumentExcept : Exception
    {
        public ArgumentExcept()
        {
        }

        public ArgumentExcept(string message) : base(message)
        {
        }

        public ArgumentExcept(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArgumentExcept(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}