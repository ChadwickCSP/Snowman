

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
            else if (this.fullWord.Contains(guess) == false)
            {
                // If the character is a digit, we increment count by 1.
                this.incorrectGuesses++;

                // We check to see if there are no guesses
                return $"Ouch! No{guess}es";
            }

            // Declare a count variable to track the number of
            // digits and initialize the value to 0.
            int count;
            count = this.CountLetter(guess[0]);

            if (count == 1)
            {
                return $"There is 1 {guess}";
            }
            else
            {
                return $"There are {count} {guess}es";
            }
        }
        public int CountLetter(char guess)
        {

            if (!char.IsLetter(guess))
            {
                throw new ArgumentException("Invalid Character: {guess}.");
            }
            else
            {

                guess = char.ToUpper(guess);

                int count = 0;
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
                throw new System.NotImplementedException();
            }

            public string GetGuessedLetters()
            {

                string letters;
                letters = string.Empty;
                foreach (char c in this.lettersGuessed)
                {
                    letters += $" {c}";
                }
                return letters.Trim();
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