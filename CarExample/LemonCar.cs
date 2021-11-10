namespace CarExample
{

    /// <summary>
    /// A LemonCar is a car that doesn't run.
    /// </summary>
    public class LemonCar : ICar
    {
        /// <inheritdoc/>
        public void Accelerate()
        {
            // Lemon doesn't run!
        }

        /// <inheritdoc/>
        public void Brake()
        {
            // Lemon doesn't run!
        }

        /// <inheritdoc/>
        public int GetMaxSpeed()
        {
            return 0;
        }

        public string GetName()
        {
            return "Lemon";
        }

        /// <inheritdoc/>
        public int GetSpeed()
        {
            return 0;
        }
    }

}