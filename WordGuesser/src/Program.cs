namespace WordGuesser
{
    using System;

    /// <summary>
    /// This class contains the Entry Point for running this project in the console.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The Entry Point of the entire project.
        /// </summary>
        public static void Main()
        {
            // Comment out the following lines.
            Examples.StringAnalyzer.RunExample("    27   ");
            Examples.StringAnalyzer.RunExample("Hello World!");
            Examples.StringAnalyzer.RunExample("H3110 W0r1d!");

            // When you're ready to run your GuessingGame, uncomment the following line:
            // GuessingGame.Play();
        }
    }
}
