

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
        private string wordToGuess;
        private string guessedLetters;

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

            guess = guess.Trim().ToUpper();
            if (guess.Length != 1)
            {
                return "You must guess a single letter";
            }
            else if (char.IsLetter(guess[0]) == false)
            {
                return "You can only guess letters";
            }
            else if (this.lettersGuessed.Contains(guess[0]))
            {
                return $"You've already guessed {guess}";

            }
            else if (this.wordToGuess.Contains(guess) == false)
            {
                this.incorrectGuesses++;
                this.lettersGuessed.Add(guess[0]);
                return $"Ouch! No {guess}s";
            }
            int count;
            count = this.CountLetter(guess[0]);

            if (count == 1)
            {
                return $"There is 1 {guess}";
            }

            return $"There are {count} guesses";
        }

        public int CountLetter(char guess)
        {
            int count;
            count = 0;
            guess = char.ToUpper(guess);
            if (!char.IsLetter(guess))
            {
                throw new ArgumentException("Invalid character: {guess}.");
            }

            foreach (char c in this.fullWord)
            {
                if (c == guess)
                {
                    count++;
                }
            }
            return count;
        }

        public string GetFullWord()
        {
            return this.fullWord;
        }

        public string GetGuessedLetters()
        {
            throw new System.NotImplementedException();
            //Lucia
        }

        public int GetGuessLimit()
        {
            return this.guessLimit;
        }

        public int GetIncorrectGuesses()
        {
            throw new System.NotImplementedException();
            //Lucia
        }

        public string GetWord()
        {
            string word;
            word = string.Empty;
            foreach (char c in this.fullWord)
            {
                if (this.guessedLetters.Contains(c))
                {
                    word += $"{c}";
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
                if (this.lettersGuessed.Contains(c))
                {

                }
                else 
                {
                    return false;
                }
            }
            return true;

        }
    }
}