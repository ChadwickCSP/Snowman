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
            // throw new System.NotImplementedException();
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
                this.incorrectGuesses++;
                this.lettersGuessed.Add(guess[0]);
                return $"Ouch! No {guess}s";
            }

            int count = this.CountLetter(guess[0]);
            this.lettersGuessed.Add(guess[0]);

            if (count == 1)
            {
                return $"There is 1 {guess}";
            }
            else
            {
                return $"There are {count}{guess}s";
            }



        }

        public int CountLetter(char guess)
        {
            throw new System.NotImplementedException();
        }

        public string GetFullWord()
        {
            // throw new System.NotImplementedException();
            return this.fullWord;
        }

        public string GetGuessedLetters()
        {
            // throw new System.NotImplementedException();
            string letters;
            letters = string.Empty;
            foreach (char c in this.lettersGuessed)
            {
                letters += $"{c}";
            }

            return letters.Trim();
        }

        public int GetGuessLimit()
        {
            throw new System.NotImplementedException();
        }

        public int GetIncorrectGuesses()
        {
            // throw new System.NotImplementedException();
            return this.incorrectGuesses;
        }

        public string GetWord()
        {
            // throw new System.NotImplementedException();
            string word;
            word = string.Empty;
            foreach (char c in this.fullWord)
            {
                if (this.lettersGuessed.Contains(c))
                {
                    word += $"{c}";
                }
                else
                {
                    word += "_";
                }
            }

            return word.Trim();
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