namespace CarExample
{

    /// <summary>
    /// Defines a set of methods common for Cars.
    /// </summary>
    public interface ICar
    {

        /// <summary>
        /// Gets the name of this car.
        /// </summary>
        /// <returns>The cars name.</returns>
        string GetName();

        /// <summary>
        /// Returns the maximum speed of this Car in miles per hour.
        /// </summary>
        /// <returns>The max speed.</returns>
        int GetMaxSpeed();

        /// <summary>
        /// Returns the current speed of this Car in miles per hour.
        /// </summary>
        /// <returns>The current speed.</returns>
        int GetSpeed();

        /// <summary>
        /// Attempts to accelerate the car.
        /// </summary>
        void Accelerate();

        /// <summary>
        /// Attempts to brake the car.
        /// </summary>
        void Brake();
    }

}