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
        private string word;

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
            throw new System.NotImplementedException();
        }

        public int CountLetter(char guess)
        {

        }

        public string GetFullWord()
        {
            return this.fullWord;
        }

        public string GetGuessedLetters()
        {
            letters = string.Empty;
            while (this.guessedLetters(char c))
            {
                letters += $" {c}";
            }
            return string letters.Trim();

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
            while (this.fullWord(char c))
            {
                if this.guessedLetters.Contains(c){
                    word += $"{c}";
                }
                else
                    word += "_";
            }
            return string word.Trim();
        }

        public bool IsGameOver()
        {
            return bool this.incorrectGuesses >= this.guessLimit;
        }

        public bool IsGameWon()
        {
            throw new System.NotImplementedException();
        }
    }

}