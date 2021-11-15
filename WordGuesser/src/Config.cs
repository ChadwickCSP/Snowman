namespace WordGuesser
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This is a helper class which defines which classes to use
    /// for Unit testing.
    /// </summary>
    public class Config
    {
        /// <summary>
        /// Returns an implementaiton of IWordSelector specifying a
        /// path to a dictionary to use.
        /// </summary>
        /// <param name="path">The file path of the dictionary to use.</param>
        /// <returns>An IWordSelector containing the words in the specified file.</returns>
        public static IWordSelector GetWordSelector(string path)
        {
            return new WordSelector(path);
        }

        /// <summary>
        /// Returns an implementaiton of IWordSelector specifying a
        /// path to a dictionary to use and a Random number generator.
        /// </summary>
        /// <param name="path">The file path of the dictionary to use.</param>
        /// <param name="random">A random number generator.</param>
        /// <returns>An IWordSelector containing the words in the specified file and random number generator.</returns>
        public static IWordSelector GetWordSelector(string path, Random random)
        {
            return new WordSelector(path, random);
        }

         /// <summary>
        /// Returns an implementaiton of IWordSelector specifying a
        /// non-empty dictionary to use and a Random number generator.
        /// </summary>
        /// <param name="dictionary">A non-empty list of words to use.</param>
        /// <param name="random">A random number generator.</param>
        /// <returns>An IWordSelector containing the words in the specified file and random number generator.</returns>
        public static IWordSelector GetWordSelector(List<string> dictionary, Random random)
        {
            return new WordSelector(dictionary, random);
        }

        /// <summary>
        /// Returns an implementaiton of IWordGame specifying the word
        /// that is being guessed and the number of incorrect guesses that can be made.
        /// </summary>
        /// <param name="wordToGuess">The word to guess.</param>
        /// <param name="guessLimit">The number of incorrect guesses that can be made.</param>
        /// <returns>An IWordGame.</returns>
        public static IWordGame GetWordGame(string wordToGuess, int guessLimit)
        {
            // TODO: Replace with your constructor.
            return new WordGame(wordToGuess, guessLimit);
        }
    }
}