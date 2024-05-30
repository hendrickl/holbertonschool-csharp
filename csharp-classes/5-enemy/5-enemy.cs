using System;

namespace Enemies
{
    /// <summary>
    /// Represents a blueprint for a zombie.
    /// </summary>
    public class Zombie
    {
        /// The health of the zombie.
        private int health;

        /// The name of the zombie
        private string name = "(No name)";

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with a specified health value.
        /// </summary>
        /// <param name="value">The health of the zombie. Must be greater than or equal to 0.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="value"/> is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
        }

        /// <summary>
        /// Gets or sets the name of the zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets the health of the zombie.
        /// </summary>
        /// <returns>The current health of the zombie.</returns>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>
        /// Returns a string that represents the current zombie.
        /// </summary>
        /// <returns>A string that contains the name and health of the zombie.</returns>
        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}
