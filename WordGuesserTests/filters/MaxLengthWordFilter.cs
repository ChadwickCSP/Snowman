namespace WordGuesserTests
{
    using WordGuesser;

    /// <summary>
    /// A LengthWordFilter checks for a string that is less than or equal
    /// to the specified length.
    /// </summary>
    public class MaxLengthWordFilter : IWordFilter
    {
        private readonly int maxLength;

        /// <summary>
        /// Initializes an instance of the LengthWordFilter class specifying the maximum length of word to keep.
        /// </summary>
        /// <param name="maxLength">The maximum length of word to keep.</param>
        public MaxLengthWordFilter(int maxLength)
        {
            this.maxLength = maxLength;
        }

        /// <inheritdoc />
        public bool IsValid(string word)
        {
            return word.Length <= this.maxLength;
        }
    }
}