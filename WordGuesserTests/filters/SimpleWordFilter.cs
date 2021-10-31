namespace WordGuesserTests
{
    using WordGuesser;

    /// <summary>
    /// A SimpleWordFilter checks for an exact match of a string.
    /// </summary>
    public class SimpleWordFilter : IWordFilter
    {
        private readonly string toMatch;

        /// <summary>
        /// Initializes an instance of the SimpleWordFilter class with the specified match string.
        /// </summary>
        /// <param name="toMatch">The string to match.</param>
        public SimpleWordFilter(string toMatch)
        {
            this.toMatch = toMatch;
        }

        /// <inheritdoc />
        public bool IsValid(string word)
        {
            return this.toMatch.Equals(word);
        }
    }
}