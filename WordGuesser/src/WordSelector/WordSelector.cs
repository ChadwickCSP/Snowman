namespace WordGuesser
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// A class for generating random words.
    /// </summary>
    public class WordSelector : IWordSelector
    {
        private readonly string[] dictionary;
        private readonly Random randomGenerator;

        /// <summary>
        /// Initializes an instance of the WordSelector class specifying the path to a
        /// file containing the words that are possible.
        /// </summary>
        /// <param name="path">A path to a file containing words.</param>
        public WordSelector(string path) : this(path, new Random())
        {
        }

        /// <summary>
        /// Initializes an instance of the WordSelector class specifying a list of strings
        /// to use as a dictionary and the random generator to use.
        /// </summary>
        /// <param name="dictionary">A list of words to use in the dictionary.</param>
        /// <param name="generator">A random generator.</param>
        public WordSelector(List<string> dictionary, Random generator)
        {
            if (generator == null)
            {
                throw new ArgumentNullException(nameof(generator));
            }

            if (dictionary.Count < 1)
            {
                throw new ArgumentException("The specified dictionary must contain at least 1 word.");
            }

            this.dictionary = dictionary.ToArray();
            this.randomGenerator = generator;
        }

        /// <summary>
        /// Initializes an instance of the WordSelector class specifying the path to
        /// a file containing the words and the random generator to use.
        /// </summary>
        /// <param name="path">A path to a file containing words.</param>
        /// <param name="generator">The random generator to use.</param>
        public WordSelector(string path, Random generator)
        {
            if (generator == null)
            {
                throw new ArgumentNullException(nameof(generator));
            }

            this.dictionary = File.ReadAllLines(path);
            if (this.dictionary.Length < 1)
            {
                throw new ArgumentException("The specified dictionary must contain at least 1 word.");
            }

            this.randomGenerator = generator;
        }

        /// <inheritdoc/>
        public List<string> GetDictionary(params IWordFilter[] filters)
        {
            List<string> results = new List<string>();

            foreach (string word in this.dictionary)
            {
                bool keepWord = true;
                foreach (IWordFilter filter in filters)
                {
                    if (filter.IsValid(word) == false)
                    {
                        keepWord = false;
                        break;
                    }
                }

                if (keepWord == false)
                {
                    continue;
                }
                else
                {
                    results.Add(word);
                }
            }

            if (results.Count == 0)
            {
                throw new ArgumentException("The specified filters produced 0 words.");
            }

            return results;
        }

        /// <inheritdoc/>
        public string GetWord(params IWordFilter[] filters)
        {
            return string.Empty;
        }
    }
}