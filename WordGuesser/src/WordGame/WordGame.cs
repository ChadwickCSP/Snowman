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
        private int count;

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
        }


        public string CheckGuess(string guess)
        {
            guess = guess.Trim().ToUpper();
            if (guess.Length != 1)
            {
                return "You must guess a single letter";
            }
            if (char.IsLetter(guess[0]) == false)
            {
                return "You can only guess letters";
            }

            if (this.guessedLetters.Contains(guess[0]))
            {
                return $"You've already guessed {guess}";
            }

            this.guessedLetters.Add(guess[0]);
            if (this.fullWord.Contains(guess) == false)
            {
                this.incorrectGuesses++;
                return $"Ouch! No {guess}s";

            }
            int count = this.CountLetter(guess[0]);
            if (count != 1)
            {
                return $"There are {count} {guess}s";
            }
            return $"There is 1 {guess}";

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
            return this.fullWord;
        }

        public string GetGuessedLetters()
        {
            letters = string.Empty;
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
            word = string.Empty;
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
