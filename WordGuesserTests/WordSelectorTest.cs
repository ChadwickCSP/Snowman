namespace WordGuesserTests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using WordGuesser;

    /// <summary>
    /// A Test class for the IWordSelector interface.
    /// </summary>
    public class WordSelectorTest
    {
        /// <summary>
        /// Tests that the dictionary supplied to the constructor is the same
        /// dictionary that is returned by GetDictionary().
        /// </summary>
        [Test]
        public void TestGetDictionary()
        {
            {
                List<string> dictionary = new List<string>();
                dictionary.Add("hello");
                dictionary.Add("banana");
                dictionary.Add("cheese");
                dictionary.Add("brains");
                IWordSelector selector = Config.GetWordSelector(dictionary, new Random());
                List<string> fullDictionary = selector.GetDictionary();
                Assert.AreEqual(dictionary, fullDictionary);
            }

            {
                List<string> dictionary = new List<string>();
                dictionary.Add("one");
                dictionary.Add("two");
                dictionary.Add("three");
                dictionary.Add("four");
                IWordSelector selector = Config.GetWordSelector(dictionary, new Random());
                List<string> fullDictionary = selector.GetDictionary();
                Assert.AreEqual(dictionary, fullDictionary);
            }
        }

        /// <summary>
        /// Tests that GetWord is using the specified random generator.
        /// </summary>
        [Test]
        public void TestRandomGetWord()
        {
            List<string> dictionary = new List<string>();
            dictionary.Add("one");
            dictionary.Add("two");
            dictionary.Add("three");
            dictionary.Add("four");
            IWordSelector selector = Config.GetWordSelector(dictionary, new MockRandom(0, 1, 2, 3));
            Assert.AreEqual("one", selector.GetWord());
            Assert.AreEqual("two", selector.GetWord());
            Assert.AreEqual("three", selector.GetWord());
            Assert.AreEqual("four", selector.GetWord());
        }

        /// <summary>
        /// Tests that GetDictionary method uses the supplied filters.
        /// </summary>
        [Test]
        public void TestGetDictionaryWithFilter()
        {
            List<string> dictionary = new List<string>();
            dictionary.Add("one");
            dictionary.Add("two");
            dictionary.Add("three");
            dictionary.Add("four");

            IWordSelector selector = Config.GetWordSelector(dictionary, new Random());

            SimpleWordFilter threeFilter = new SimpleWordFilter("three");
            Assert.AreEqual("three", selector.GetWord(threeFilter));

            SimpleWordFilter oneFilter = new SimpleWordFilter("one");
            Assert.AreEqual("one", selector.GetWord(oneFilter));

            SimpleWordFilter twoFilter = new SimpleWordFilter("two");
            Assert.AreEqual("two", selector.GetWord(twoFilter));

            SimpleWordFilter fourFilter = new SimpleWordFilter("four");
            Assert.AreEqual("four", selector.GetWord(fourFilter));
        }

        /// <summary>
        /// Tests that GetDictionary method uses the supplied filters.
        /// </summary>
        [Test]
        public void TestGetDictionaryWithMultipleFilters()
        {
            List<string> dictionary = new List<string>();
            dictionary.Add("one");
            dictionary.Add("two");
            dictionary.Add("three");
            dictionary.Add("four");

            IWordSelector selector = Config.GetWordSelector(dictionary, new Random());
            ContainsWordFilter cFilter = new ContainsWordFilter("o");
            MaxLengthWordFilter maxFilter = new MaxLengthWordFilter(3);
            MinLengthWordFilter minFilter = new MinLengthWordFilter(4);

            List<string> filteredDictionary = selector.GetDictionary(cFilter, maxFilter);
            Assert.AreEqual(2, filteredDictionary.Count);
            Assert.Contains("one", filteredDictionary);
            Assert.Contains("two", filteredDictionary);

            filteredDictionary = selector.GetDictionary(cFilter, minFilter);
            Assert.AreEqual(1, filteredDictionary.Count);
            Assert.Contains("four", filteredDictionary);

            cFilter = new ContainsWordFilter("r");
            filteredDictionary = selector.GetDictionary(cFilter, minFilter);
            Assert.AreEqual(2, filteredDictionary.Count);
            Assert.Contains("four", filteredDictionary);
            Assert.Contains("three", filteredDictionary);
        }

        /// <summary>
        /// Tests that an ArgumentException is thrown if a filter is too restrictive.
        /// </summary>
        [Test]
        public void TestFilterAll()
        {
            List<string> dictionary = new List<string>();
            dictionary.Add("one");
            dictionary.Add("two");
            dictionary.Add("three");
            dictionary.Add("four");
            IWordSelector selector = Config.GetWordSelector(dictionary, new Random());
            IWordFilter filter = new AlwaysFalseFilter();
            Assert.Throws<ArgumentException>(
                () => { selector.GetDictionary(filter); });
            Assert.Throws<ArgumentException>(
                () => { selector.GetWord(filter); });
        }

        /// <summary>
        /// Tests that a dictionary can be loaded from a file.
        /// </summary>
        [Test]
        public void TestLoadDictionaryFromFile()
        {
                IWordSelector selector = Config.GetWordSelector("../../../simple_dictionary.txt", new Random());
                List<string> dictionary = selector.GetDictionary();
                Assert.AreEqual(4, dictionary.Count);
                Assert.Contains("one", dictionary);
                Assert.Contains("two", dictionary);
                Assert.Contains("three", dictionary);
                Assert.Contains("four", dictionary);

                selector = Config.GetWordSelector("../../../simple_dictionary2.txt", new Random());
                dictionary = selector.GetDictionary();
                Assert.AreEqual(5, dictionary.Count);
                Assert.Contains("apple", dictionary);
                Assert.Contains("banana", dictionary);
                Assert.Contains("cat", dictionary);
                Assert.Contains("dog", dictionary);
                Assert.Contains("mouse", dictionary);
        }
    }
}