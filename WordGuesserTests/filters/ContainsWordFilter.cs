namespace WordGuesserTests
{
    using WordGuesser;

    /// <summary>
    /// A ContainsWordFilter checks for words containing the specified string.
    /// </summary>
    public class ContainsWordFilter : IWordFilter
    {
        private readonly string toMatch;

        /// <summary>
        /// Initializes an instance of the SimpleWordFilter class with the specified match string.
        /// </summary>
        /// <param name="toMatch">The string to match.</param>
        public ContainsWordFilter(string toMatch)
        {
            this.toMatch = toMatch;
        }

        /// <inheritdoc />
        public bool IsValid(string word)
        {
            return word.Contains(this.toMatch);
        }
    }
}