namespace WordGuesser
{
    using System.Collections.Generic;

    /// <summary>
    /// A class for generating random words.
    /// </summary>
    public interface IWordSelector
    {
        /// <summary>
        /// Generates a list of words that match the specified WordFilters.
        /// </summary>
        /// <param name="filters">The word filters to use.</param>
        /// <returns>A list of words matching the filter.</returns>
        /// <exception cref="System.ArgumentException">Thrown if the specified filters result in no words being available.</exception>
        List<string> GetDictionary(params IWordFilter[] filters);

        /// <summary>
        /// Gets a random word from this WordSelector using the specified filters.
        /// </summary>
        /// <param name="filters">A list of filters to use for word selection.</param>
        /// <returns>A random word from that matches the specified filters.</returns>
        /// <exception cref="System.ArgumentException">Thrown if the specified filters result in no words being available.</exception>
        string GetWord(params IWordFilter[] filters);
    }

    /// <summary>
    /// A WordFilter specifies a predicate method IsValid which returns true
    /// if the specified word meets the criteria for this WordFilter.
    /// </summary>
    public interface IWordFilter
    {
        /// <summary>
        /// Checks to see if a word meets the criteria of this WordFilter.
        /// </summary>
        /// <param name="word">The word to check.</param>
        /// <returns>true if the word is valid and false otherwise.</returns>
        bool IsValid(string word);
    }
}