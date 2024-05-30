using System;

namespace Enemies
{
    /// <summary>
    /// Represents a blueprint for a zombie.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// The health of the zombie.
        /// </summary>
        public int health;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }
    }
}
