namespace WordGuesser
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// A class for generating random words.
    /// </summary>
    public class WordSelector : IWordSelector
    {
        private readonly string[] dictionary;
        private readonly Random randomGenerator;

        /// <summary>
        /// Given a string, splits it on white space and uses the resulting
        /// words as a dictionary.
        /// </summary>
        /// <param name="toLoad">The string of words to use.</param>
        /// <returns>A WordSelector with the specified dictionary.</returns>
        public static WordSelector LoadFromString(string toLoad)
        {
            ISet<string> words = new HashSet<string>();

            foreach (string word in toLoad.Split().ToList())
            {
                string trimmedWord = word.Trim();
                if (trimmedWord == string.Empty)
                {
                    continue;
                }

                words.Add(trimmedWord);
            }

            return new WordSelector(words.ToList(), new Random());
        }

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
            // TODO: Throw exception if no words match?
            List<string> possibleWords = this.GetDictionary(filters);
            int ix = this.randomGenerator.Next(possibleWords.Count);

            if (possibleWords[ix].Trim() == string.Empty)
            {
                return this.GetWord(filters);
            }

            return possibleWords[ix].Trim();
        }
    }
}