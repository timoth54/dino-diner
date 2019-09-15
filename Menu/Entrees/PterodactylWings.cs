/*
 * PterodactylWings.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Specification of making Pterodactyl Wings.
    /// </summary>
   public class PterodactylWings
    {
        /// <summary>
        /// The price of Pterodactyl Wings.
        /// </summary>
        public double Price
        {
            get;
            private set;
        }

        /// <summary>
        /// The Calories in Pterodactyl Wings.
        /// </summary>
        public uint Calories
        {
            get;
            private set;
        }

        /// <summary>
        /// Gives a list of ingredients for the Pterodactyl Wings.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Chicken", "Wing Sauce" };
            }
        }

        /// <summary>
        /// Makes new Pterodactyl Wings.
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
        }

    }
}
