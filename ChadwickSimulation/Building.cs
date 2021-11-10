namespace ChadwickSimulation
{
    /// <summary>
    /// A building has a name and capacity.
    /// </summary>
    public class Building
    {
        /// <summary>
        /// The name of this building.
        /// </summary>
        public string name;

        /// <summary>
        /// The number of people this building can hold. 
        /// </summary>
        public int capacity;

        /// <summary>
        /// Initializes an instance of a Building specifying its name and capacity.
        /// </summary>
        /// <param name="name">The name of the building.</param>
        /// <param name="capacity">The capacity of the building.</param>
        public Building(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }

        /// <summary>
        /// Gets information about this building.
        /// </summary>
        /// <returns>A string with information about this building.</returns>
        public string GetInfo()
        {
            return $"{this.name} has a capacity of {this.capacity}.";
        }

    }
}