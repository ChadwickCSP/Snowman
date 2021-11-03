namespace WordGuesser
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This is a Driver Class for a simple Word Guessing Game.
    /// </summary>
    public class GuessingGame
    {
        /// <summary>
        /// This is the Entry Point for the Word Guessing Game.
        /// </summary>
        public static void Play()
        {
            // WordSelector selector = new WordSelector("words.txt");
            List<string> dictionary = new List<string>();
            WordSelector selector = new WordSelector(dictionary, new Random());

            // TODO: Replace with your constructor
            IWordGame game = null;

            while (game.IsGameWon() == false && game.IsGameOver() == false)
            {
                Console.Clear();
                Console.WriteLine(game.GetFullWord());
                int guessesRemaining = game.GetGuessLimit() - game.GetIncorrectGuesses();
                Console.WriteLine($"Can you guess the word? You have {guessesRemaining} guesses remaining.");
                Console.WriteLine($"Word: {game.GetWord()}");
                Console.WriteLine($"Guessed Letters: {game.GetGuessedLetters()}");

                Console.Write("Guess a letter: ");
                string guess = Console.ReadLine();
                string result = game.CheckGuess(guess);
                Console.WriteLine(result);
                Console.WriteLine("Press Enter to Continue...");
                Console.ReadLine();
            }

            Console.WriteLine($"The word was: {game.GetFullWord()}");

            if (game.IsGameWon())
            {
                Console.WriteLine("Congratulations, you won!");
            }
            else
            {
                Console.WriteLine("Game Over! You could not guess the word.");
            }
        }
    }
}
