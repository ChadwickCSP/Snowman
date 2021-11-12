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
        // Susan's Methods
        public string CheckGuess(string guess)
        {
            guess = guess.Trim().ToUpper();
            if (guess.Length != 1)
            {
                return "You must guess a single letter";
            }
            else if (!char.IsLetter(guess[0]))
            {
                return "You can only guess letters";
            }
            else if (this.guesses.Contains(guess[0]))
            {
                return $"You've already guessed {guess}";
            }
            else if (!this.fullWord.Contains(guess))
            {
                this.incorrectGuesses++;
                this.guesses.Add(guess[0]);
                return $"Ouch! No {guess}s";
            }
            else
            {
                int count;
                count = this.CountLetter(guess[0]);
                this.guesses.Add(guess[0]);
                if (count == 1)
                {
                    return $"There is 1 {guess}";
                }
                else
                {
                    return $"There are {count} {guess}s";
                }
            }
        }
        // Susan's Methods
        public int CountLetter(char guess)
        {
            guess = char.ToUpper(guess);
            if (!char.IsLetter(guess))
            {
                throw new ArgumentException("Invalid character: {guess}.");


            }
            int count;
            count = 0;
            foreach (char c in fullWord)
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
        // Hudson's Methods
        public string GetGuessedLetters()
        {
            string letters;
            letters = string.Empty;
            foreach (char c in this.guesses)
            {
                letters += $"{c} ";
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
            string word;
            word = string.Empty;
            foreach(char c in this.fullWord)
            {
                if (this.guesses.Contains(c))
                {
                    word +=$"{c}";
                }
                word += "_ ";
            }
            return word.Trim();
        }
        // Austins methods
        public bool IsGameOver()
        {
            return this.incorrectGuesses >= this.guessLimit;
        }
        // Austins methods
        public bool IsGameWon()
        {
            foreach (char c in this.fullWord)
            {
                if (!this.guesses.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }

}