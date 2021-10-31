namespace WordGuesserTests
{
    using WordGuesser;

    /// <summary>
    /// The AlwaysFalseFilter returns false for all words.
    /// </summary>
    public class AlwaysFalseFilter : IWordFilter
    {
        /// <inheritdoc />
        public bool IsValid(string word)
        {
            return false;
        }
    }
}