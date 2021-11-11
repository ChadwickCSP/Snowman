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
            this.fullWord = wordToGuess.ToUpper();
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
            if (!char.IsLetter(guess))
            {
                throw new ArgumentException("Invalid character: {guess}.");
            }
            else
            {
                guess = char.ToUpper(guess);
                int count;
                count = 0;
                foreach (char c in this.fullWord)
                {
                    if (c == guess)
                    {
                        count++;
                    }

                }
                return count;

            }
        }

        public string GetFullWord()
        {
            throw new System.NotImplementedException();
        }

        public string GetGuessedLetters()
        {
            string letters;
            letters = string.Empty;
            foreach (char c in this.lettersGuessed)
            {
                letters += $"{c}";
            }
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
            return "";
        }

        public bool IsGameOver()
        {
            return this.incorrectGuesses >= this.guessLimit;
        }

        public bool IsGameWon()
        {
            foreach (char c in this.fullWord)
            {
                if (!this.lettersGuessed.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
