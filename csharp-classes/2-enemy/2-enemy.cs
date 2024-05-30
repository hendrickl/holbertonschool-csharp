﻿using System;

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
    }
}
