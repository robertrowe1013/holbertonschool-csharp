using System;

namespace Enemies
{
    /// <summary>
    /// Zombie enemy
    /// </summary>
    class Zombie
    {
        /// <summary>
        /// Zombie health
        /// </summary>
        public int health;

        /// <summary>
        /// Start a zombie at 0 health
        /// </summary>
        public Zombie(int health = 0)
        {
            this.health = health;
        }
    }
}
