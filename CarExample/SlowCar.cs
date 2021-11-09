namespace CarExample
{

    public class SlowCar : ICar
    {
        private int currentSpeed;

        /// <summary>
        /// Accelerates 3 MPH up to the maximum speed.
        /// </summary>
        public void Accelerate()
        {
            this.currentSpeed += 3;
            if (this.currentSpeed > this.GetMaxSpeed())
            {
                this.currentSpeed = this.GetMaxSpeed();
            }
        }

        /// <summary>
        /// Decelerates by 10 MPH down to 0 MPH.
        /// </summary>
        public void Brake()
        {
            this.currentSpeed -= 10;
            if(this.currentSpeed < 0)
            {
                this.currentSpeed = 0;
            }
        }

        /// <inheritdoc/>
        public int GetMaxSpeed()
        {
            return 35;
        }

        /// <inheritdoc/>
        public int GetSpeed()
        {
            return this.currentSpeed;
        }

        public string GetName()
        {
            return "La Tortuga";
        }

    }

}