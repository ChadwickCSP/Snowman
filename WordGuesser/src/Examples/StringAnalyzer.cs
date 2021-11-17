namespace Examples
{
    using System;

    /// <summary>
    /// A StringAnalyzer provides methods for analyzing strings.
    /// </summary>
    public class StringAnalyzer
    {
        private readonly string toAnalyze;
        private string fullWord;

        /// <summary>
        /// Initializes an instance of the Stringanalyzer class specifying the string to be analyzed.
        /// </summary>
        /// <param name="toAnalyze">The string to be analyzed.</param>
        public StringAnalyzer(string toAnalyze)
        {
            this.toAnalyze = toAnalyze;
        }

        /// <summary>
        /// An example usage of the StringAnalyzer.
        /// This method creates a new instance of the string analyzer and runs each of its methods.
        /// If the string being analyzed is an integer, the AsInteger() method is run.
        /// </summary>
        /// <param name="toAnalyze">The string to be analyzed.</param>
        public static void RunExample(string toAnalyze)
        {
            StringAnalyzer analyzer = new StringAnalyzer(toAnalyze);
            Console.WriteLine($"Analyzing '{toAnalyze}':");
            Console.WriteLine($"IsInteger? {analyzer.IsInteger()}");

            if (analyzer.IsInteger())
            {
                Console.WriteLine($"AsInteger(): {analyzer.AsInteger()}");
            }
            else
            {
                Console.WriteLine($"AsInteger(): Skipped!");
            }

            Console.WriteLine($"HasLetter? {analyzer.HasLetter()}");
            Console.WriteLine($"CountDigits(): {analyzer.CountDigits()}");
        }

        /// <summary>
        /// Checks to see if the string being analyzed is a non-negative Integer.
        /// </summary>
        /// <returns>true if the string is a non-negative integer, otherwise returns false.</returns>
        public bool IsInteger()
        {
            // First, we remove any blank space from the front or back of the string
            // For example, "   27   " will become "27"
            string sanitizedString;
            sanitizedString = this.toAnalyze.Trim();

            // Then, we loop through each character in the string to check that
            // each character is a digit.
            foreach (char c in sanitizedString)
            {
                // If any of the characters is not a digit, the entire string
                // is not an integer.
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Returns a non-negative integer of the string being analyzed.
        /// </summary>
        /// <exception cref="System.Exception">If the string being analyzed is not an integer an Exception is raised.</exception>
        /// <returns>The parsed integer.</returns>
        public int AsInteger()
        {
            // We check to make sure the string is an integer.
            if (!this.IsInteger())
            {
                // If it is not an integer, we throw an exception.
                throw new Exception("This StringAnalyzer does not contain an Integer.");
            }

            // We can safely parse the integer because, at this point, we know it only contains digits.
            // We Trim all of the blank space first.
            return int.Parse(this.toAnalyze.Trim());
        }

        /// <summary>
        /// Counts the number of digits in the string being analyzed.
        /// </summary>
        /// <returns>The number of times a digit appears in the string being analzyed.</returns>
        public int CountDigits()
        {
            // Declare a count variable to track the number of
            // digits and initialize the value to 0.
            int count;
            count = 0;

            // Loop through all of the characters in the string.
            foreach (char c in this.toAnalyze)
            {
                if (char.IsDigit(c))
                {
                    // If the character is a digit, we increment count by 1.
                    count++;
                }
            }

            // Finally, return the count
            return count;
        }

        /// <summary>
        /// Checks if the string being analyzed contains at least 1 letter.
        /// </summary>
        /// <returns>true if the string being analyzed contains at least 1 letter and false otherwise.</returns>
        public bool HasLetter()
        {
            // Loop through every character.
            foreach (char c in this.toAnalyze)
            {
                if (char.IsLetter(c))
                {
                    // If a character is a letter, return true immediately.
                    return true;
                }
            }

            // If none of the characters are a letter, return false.
            return false;
        }

    }
}