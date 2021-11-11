namespace WordGuesserTests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using WordGuesser;

    /// <summary>
    /// A Test class for the IWordSelector interface.
    /// </summary>
    public class WordGameTest
    {
        /// <summary>
        /// Tests that the constructor for getting a word game throws an ArgumentException
        /// if the word contains non-letters and if the guessLimit is not valid.
        /// </summary>
        [Test]
        public void TestInvalidConstructors()
        {
            // Tests that numbers are invalid
            Assert.Throws<ArgumentException>(() => { Config.GetWordGame("3", 5); });

            // Tests that spaces are invalid
            Assert.Throws<ArgumentException>(() => { Config.GetWordGame("Some word with spaces", 5); });

            // Tests that 0 is invalid
            Assert.Throws<ArgumentException>(() => { Config.GetWordGame("valid", 0); });

            // Tests that negative number is invalid
            Assert.Throws<ArgumentException>(() => { Config.GetWordGame("valid", -5); });
        }

        /// <summary>
        /// Tests that the constructor for getting a word game returns an
        /// object when given valid parameters.
        /// </summary>
        [Test]
        public void TestValidConstructors()
        {
            // Tests that it is possible to construct word games
            IWordGame game = Config.GetWordGame("valid", 5);
            Assert.NotNull(game);

            game = Config.GetWordGame("word", 3);
            Assert.NotNull(game);

            game = Config.GetWordGame("another", 17);
            Assert.NotNull(game);
        }

        /// <summary>
        /// Tests the initial value of GetIncorrectGuesses is 0.
        /// </summary>
        [Test]
        public void TestInitialGetIncorrectGuesses()
        {
            // Tests valid constructors
            IWordGame game = Config.GetWordGame("valid", 5);
            Assert.AreEqual(0, game.GetIncorrectGuesses());

            game = Config.GetWordGame("word", 3);
            Assert.AreEqual(0, game.GetIncorrectGuesses());

            game = Config.GetWordGame("another", 17);
            Assert.AreEqual(0, game.GetIncorrectGuesses());
        }

        /// <summary>
        /// Tests GetGuessLimit returns the specifid guess limit.
        /// </summary>
        [Test]
        public void TestGetGuessLimit()
        {
            // Tests valid constructors
            IWordGame game = Config.GetWordGame("valid", 5);
            Assert.AreEqual(5, game.GetGuessLimit());

            game = Config.GetWordGame("word", 3);
            Assert.AreEqual(3, game.GetGuessLimit());

            game = Config.GetWordGame("another", 17);
            Assert.AreEqual(17, game.GetGuessLimit());
        }

        /// <summary>
        /// Tests that GetFullWord returns the specified word to be guess in all uppercase letters.
        /// </summary>
        [Test]
        public void TestGetFullWord()
        {
            // Tests valid constructors
            IWordGame game = Config.GetWordGame("valid", 5);
            Assert.AreEqual("VALID", game.GetFullWord());

            game = Config.GetWordGame("word", 3);
            Assert.AreEqual("WORD", game.GetFullWord());

            game = Config.GetWordGame("another", 17);
            Assert.AreEqual("ANOTHER", game.GetFullWord());
        }

        /// <summary>
        /// Tests that GetLettersGuessed returns an empty string immediately after
        /// being constructed.
        /// </summary>
        [Test]
        public void TestInitialGetLettersGuessed()
        {
            // Tests valid constructors
            IWordGame game = Config.GetWordGame("valid", 5);
            Assert.AreEqual(string.Empty, game.GetGuessedLetters());

            game = Config.GetWordGame("word", 3);
            Assert.AreEqual(string.Empty, game.GetGuessedLetters());

            game = Config.GetWordGame("another", 17);
            Assert.AreEqual(string.Empty, game.GetGuessedLetters());
        }

        /// <summary>
        /// Tests the functionality of the CheckGuess method.
        /// </summary>
        [Test]
        public void TestCheckGuess()
        {
            // Tests valid constructors
            IWordGame game = Config.GetWordGame("apple", 5);

            // Test non-letter guesses
            Assert.AreEqual("You must guess a single letter", game.CheckGuess(string.Empty));
            Assert.AreEqual("You must guess a single letter", game.CheckGuess("two words"));
            Assert.AreEqual("You must guess a single letter", game.CheckGuess("oneword"));
            Assert.AreEqual("You can only guess letters", game.CheckGuess("3"));
            Assert.AreEqual("You can only guess letters", game.CheckGuess("@"));
            Assert.AreEqual("You can only guess letters", game.CheckGuess("."));

            // Test Incorrect guesses with white space
            Assert.AreEqual(0, game.GetIncorrectGuesses());
            Assert.AreEqual(string.Empty, game.GetGuessedLetters());
            Assert.AreEqual("Ouch! No Bs", game.CheckGuess("    b    "));

            // The incorrect guesses should increase by 1
            Assert.AreEqual(1, game.GetIncorrectGuesses());

            // The guessed letters should contain a B.
            Assert.IsTrue(game.GetGuessedLetters().Contains("B"));

            // Test that capital B is the same as lower case b.
            Assert.AreEqual("You've already guessed B", game.CheckGuess("  B    "));

            // The incorrect guesses should not increase again.
            Assert.AreEqual(1, game.GetIncorrectGuesses());

            // Check that when an A is guessed, the correct message is returned
            Assert.AreEqual("There is 1 A", game.CheckGuess("a"));

            // When a correct guess happens, the number of incorrect guesses does not increase.
            Assert.AreEqual(1, game.GetIncorrectGuesses());

            // The guessed letters should contain a B and an A
            Assert.IsTrue(game.GetGuessedLetters().Contains("B"));
            Assert.IsTrue(game.GetGuessedLetters().Contains("A"));

            // Check that when a P is guessed, the correct message is returned
            Assert.AreEqual("There are 2 Ps", game.CheckGuess("P"));

            // When a correct guess happens, the number of incorrect guesses does not increase.
            Assert.AreEqual(1, game.GetIncorrectGuesses());

            // The guessed letters should contain a B, A, and P.
            Assert.IsTrue(game.GetGuessedLetters().Contains("B"));
            Assert.IsTrue(game.GetGuessedLetters().Contains("A"));
            Assert.IsTrue(game.GetGuessedLetters().Contains("P"));
        }

        /// <summary>
        /// Tests the functionality of the CountLetter method.
        /// </summary>
        [Test]
        public void TestCountLetter()
        {
            IWordGame game = Config.GetWordGame("apple", 5);
            Assert.AreEqual(1, game.CountLetter('a'));
            Assert.AreEqual(1, game.CountLetter('A'));
            Assert.AreEqual(0, game.CountLetter('b'));
            Assert.AreEqual(0, game.CountLetter('B'));
            Assert.AreEqual(0, game.CountLetter('b'));
            Assert.AreEqual(2, game.CountLetter('p'));
            Assert.AreEqual(2, game.CountLetter('P'));

            // Throw argument exception if the character is not a letter.
            Assert.Throws<ArgumentException>(() => { game.CountLetter('@'); });
            Assert.Throws<ArgumentException>(() => { game.CountLetter('3'); });
        }

        /// <summary>
        /// Tests the functionality of the GetGuessedLetters method.
        /// </summary>
        [Test]
        public void GetGuessedLetters()
        {
            IWordGame game = Config.GetWordGame("apple", 5);
            Assert.AreEqual(string.Empty, game.GetGuessedLetters());
            game.CheckGuess("a");
            Assert.AreEqual("A", game.GetGuessedLetters());
            game.CheckGuess("B");
            Assert.AreEqual("A B", game.GetGuessedLetters());
            game.CheckGuess("F");
            Assert.AreEqual("A B F", game.GetGuessedLetters());
            game.CheckGuess("C");
            Assert.AreEqual("A B F C", game.GetGuessedLetters());
            game.CheckGuess("A");
            Assert.AreEqual("A B F C", game.GetGuessedLetters());
            game.CheckGuess("B");
            Assert.AreEqual("A B F C", game.GetGuessedLetters());

            game = Config.GetWordGame("apple", 5);
            Assert.AreEqual(string.Empty, game.GetGuessedLetters());
            game.CheckGuess("B");
            Assert.AreEqual("B", game.GetGuessedLetters());
            game.CheckGuess("F");
            Assert.AreEqual("B F", game.GetGuessedLetters());
            game.CheckGuess("a");
            Assert.AreEqual("B F A", game.GetGuessedLetters());
        }

        /// <summary>
        /// Tests the functionality of the GetWord method.
        /// </summary>
        [Test]
        public void TestGetWord()
        {
            IWordGame game = Config.GetWordGame("apple", 5);
            Assert.AreEqual("_ _ _ _ _", game.GetWord());
            game.CheckGuess("a");
            Assert.AreEqual("A _ _ _ _", game.GetWord());
            game.CheckGuess("p");
            Assert.AreEqual("A P P _ _", game.GetWord());
            game.CheckGuess("l");
            Assert.AreEqual("A P P L _", game.GetWord());
            game.CheckGuess("e");
            Assert.AreEqual("A P P L E", game.GetWord());

            game = Config.GetWordGame("banana", 5);
            Assert.AreEqual("_ _ _ _ _ _", game.GetWord());
            game.CheckGuess("a");
            Assert.AreEqual("_ A _ A _ A", game.GetWord());
            game.CheckGuess("b");
            Assert.AreEqual("B A _ A _ A", game.GetWord());
            game.CheckGuess("n");
            Assert.AreEqual("B A N A N A", game.GetWord());
        }

        /// <summary>
        /// Tests the functionality of the IsGameWon method.
        /// </summary>
        [Test]
        public void TestIsGameWon()
        {
            IWordGame game = Config.GetWordGame("apple", 5);
            game.CheckGuess("a");
            Assert.IsFalse(game.IsGameWon());
            game.CheckGuess("p");
            Assert.IsFalse(game.IsGameWon());
            game.CheckGuess("l");
            Assert.IsFalse(game.IsGameWon());
            game.CheckGuess("e");
            Assert.IsTrue(game.IsGameWon());
        }

         /// <summary>
        /// Tests the functionality of the IsGameWon method.
        /// </summary>
        [Test]
        public void TestIsGameOver()
        {
            IWordGame game = Config.GetWordGame("apple", 5);
            Assert.IsFalse(game.IsGameOver());
            game.CheckGuess("b");
            Assert.IsFalse(game.IsGameOver());
            game.CheckGuess("c");
            Assert.IsFalse(game.IsGameOver());
            game.CheckGuess("d");
            Assert.IsFalse(game.IsGameOver());
            game.CheckGuess("f");
            Assert.IsFalse(game.IsGameOver());
            game.CheckGuess("g");
            Assert.IsTrue(game.IsGameOver());

            game = Config.GetWordGame("apple", 1);
            Assert.IsFalse(game.IsGameOver());
            game.CheckGuess("b");
            Assert.IsTrue(game.IsGameOver());

            game = Config.GetWordGame("apple", 3);
            Assert.IsFalse(game.IsGameOver());
            game.CheckGuess("b");
            Assert.IsFalse(game.IsGameOver());
            game.CheckGuess("c");
            Assert.IsFalse(game.IsGameOver());
            game.CheckGuess("d");
            Assert.IsTrue(game.IsGameOver());
        }
    }
}