namespace WordGuesser
{
    /// <summary>
    /// A WordFilter specifies a predicate method IsValid which returns true
    /// if the specified word meets the criteria for this WordFilter.
    /// </summary>
    public interface IWordGame
    {
        /// <summary>
        /// Checks if this game has been won. A game is considered won if
        /// all of the letters in the word to be guessed have been guessed.
        /// </summary>
        /// <returns>true if the game has been one and false otherwise.</returns>
        bool IsGameWon();

        /// <summary>
        /// Checks if the game has been lost. A game is considered lost if
        /// the number of incorrect guesses is greater than or equal to the
        /// guess limit.
        /// </summary>
        /// <returns>true if the game has been lost and false otherwise.</returns>
        bool IsGameOver();

        /// <summary>
        /// Returns the number of incorrect guesses.
        /// </summary>
        /// <returns>The number of incorrect guesses.</returns>
        int GetIncorrectGuesses();

        /// <summary>
        /// Returns the guess limit.
        /// </summary>
        /// <returns>The guess limit.</returns>
        int GetGuessLimit();

        /// <summary>
        /// Checks a users guess and returns a string message informing them of the result and updating the game state as necessary.<br/>
        /// 1. The guess is sanitized such that the case, preceding, and trailing white space are ignored.<br/>
        /// 2. If the length of the sanitized input is not 1 character, returns "You must guess a single letter".<br/>
        /// 3. If the character is not a letter, returns "You can only guess letters"<br/>
        /// 4. If the letter guessed has been previously guessed, returns "You've already guessed {guess}"<br/>
        /// 5. If the letter has not been previously guessed, it is added to the list of guessed letters.
        /// 6. If the letter is not part of the word to be guessed, the number of incorrect guesses increments by 1 and then returns "Ouch! No {guess}s"<br/>
        /// 7. If the guessed letter appears in the word once, returns "There is 1 {guess}".<br/>
        /// 8. If the letter is correct and appears multiple times, returns "There are {count} {guess}s".<br/>
        /// </summary>
        /// <param name="guess">The player's guess.</param>
        /// <returns>A message informing them of the result.</returns>
        string CheckGuess(string guess);

        /// <summary>
        /// Counts the number of times the specified character appears in the word to be guessed.
        /// The case of the letter specified is ignored.
        /// </summary>
        /// <param name="guess">The guess to check.</param>
        /// <exception cref="System.ArgumentException">Thrown if the specified guess is not a letter.</exception>
        /// <returns>The number of times the specified character appears in the word to be guessed.</returns>
        int CountLetter(char guess);

        /// <summary>
        /// Returns a string containing each letter that has been guessed in the order that they were guessed.
        /// </summary>
        /// <returns>A string containing each letter that has been guessed.</returns>
        string GetGuessedLetters();

        /// <summary>
        /// Returns the word that is to be guessed without any missing letters.
        /// </summary>
        /// <returns>The word that is being guessed.</returns>
        string GetFullWord();

        /// <summary>
        /// Returns the word that is to be guessed with each letter that has
        /// not yet been guessed replaced with an underscore.
        /// </summary>
        /// <returns>The word that is to be guessed with hidden letters.</returns>
        string GetWord();
    }
}