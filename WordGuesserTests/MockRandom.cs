namespace WordGuesserTests
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A MockRandom number generator where the sequence to generate is specified.
    /// </summary>
    public class MockRandom : Random
    {
        private readonly Queue<int> values;

        /// <summary>
        /// Initializes a MockRandom number generator specifying the values
        /// to be "generated".
        /// </summary>
        /// <param name="values">A list of values to be generated.</param>
        public MockRandom(params int[] values)
        {
            this.values = new Queue<int>(values);
        }

        /// <summary>
        /// Returns the next value in the sequence.
        /// </summary>
        /// <returns>The next value in the sequence.</returns>
        public override int Next()
        {
            return this.values.Dequeue();
        }

        /// <summary>
        /// Returns the next value in the sequence.
        /// </summary>
        /// <param name="maxValue">maxValue is ignored.</param>
        /// <returns>The next value in the sequnce.</returns>
        public override int Next(int maxValue) => this.Next();

        /// <summary>
        /// Returns the next value in the sequence.
        /// </summary>
        /// <param name="minValue">minValue is ignored.</param>
        /// <param name="maxValue">maxValue is ignored.</param>
        /// <returns>The next value in the sequnce.</returns>
        public override int Next(int minValue, int maxValue) => this.Next();
    }
}