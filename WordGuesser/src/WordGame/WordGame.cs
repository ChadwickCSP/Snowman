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
            guess = guess.Trim().ToUpper();
            if (guess.Length != 1)
            {
                return ("You must guess a single letter");
            }
            if (char.IsLetter(guess[0]) == false)
            {
                return ("You can only guess letters");
            }
            if (this.lettersGuessed.Contains(guess[0]))
            {
                return ($"You've already guessed {guess}");
            }
            if (this.wordToGuess.Contains(guess) == false)
            {
                this.incorrectGuesses++;
                this.lettersGuessed.Add(guess[0]);
                return $"Ouch! No {guess}s"
            }
            int count;
            count = this.CountLetter(guess[0]);
            if (count == 1)
            {
                return $"There is 1 {guess}";
            }
            return $"there are {count} {guess}s";
        }

        public int CountLetter(char guess)
        {

            if (!char.IsLetter(guess))
            {
                throw new ArgumentException($"Invalid character: {guess}.");
            }
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