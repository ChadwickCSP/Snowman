namespace WordGuesserTests
{
    using WordGuesser;

    /// <summary>
    /// A LengthWordFilter checks for a string that is greater than or equal
    /// to the specified length.
    /// </summary>
    public class MinLengthWordFilter : IWordFilter
    {
        private readonly int minLength;

        /// <summary>
        /// Initializes an instance of the MinLengthWordFilter class specifying the minimum length of word to keep.
        /// </summary>
        /// <param name="minLength">The minimum length of word to keep.</param>
        public MinLengthWordFilter(int minLength)
        {
            this.minLength = minLength;
        }

        /// <inheritdoc />
        public bool IsValid(string word)
        {
            return word.Length >= this.minLength;
        }
    }
}