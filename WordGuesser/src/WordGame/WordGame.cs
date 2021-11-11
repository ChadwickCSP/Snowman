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

        private int wordToGuess;

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
            guess = guess.Trim()toUpper();

            if (guess.Length != 1)
            {
                return "You must guess a single letter";
            }
            else if (char.IsLetter(guess[0]) = false)
            {
                return "You can only Guess leters";
            }
            else if (this.lettersGuessed.Contains(guess[0]))
            {
                return $"You've already guessed {guess}";
            }
            if (this.wordToGuess.Contains(guess) = false)
            {
                this.incorrectGuesses++;
                this.lettersGuessed.Add(guess[0]);
                return $"Ouch! No {guesses}s";
            }
            


            public int CountLetter(char guess)
            {
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
    }