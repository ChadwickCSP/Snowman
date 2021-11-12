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

        private List<char> lettersGuessed;

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
        }

        public string CheckGuess(string guess)
        {
            if (guess.Length != 1)
            {
                return "You must guess a single letter.";
            }
            else if (char.IsLetter(guess[0]) == false)
            {
                return "You can only guess letters";
            }
            else if (this.lettersGuessed.Contains(guess[0]))
            {
                return $"You've already guessed {guess}.";
            }
            else if (this.fullWord.Contains(guess) == false)
            {
                this.incorrectGuesses++;
                this.lettersGuessed.Add(guess[0]);
                return $"Ouch. No {guess}s";
            }

            int count = this.CountLetter(guess[0]);
            if (count == 1)
            {
                return $"There is {guess}";
            }

            return $"There are {count}{guess}s";
        }

        public int CountLetter(char guess)
        {
            if (!char.IsLetter(guess))
            {
                throw new ArgumentException($"Invalid character: {guess}.");
            }

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
            return this.fullWord;
        }

        public string GetGuessedLetters()
        {
            throw new System.NotImplementedException();
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
            string word;
            word = string.Empty;
            foreach (char c in this.fullWord)
            {
                if (this.guesses.Contains(c))
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
                if (this.guesses.Contains(c) == false)
                {
                    return false;
                }
            }
            return true;
        }
    }

}