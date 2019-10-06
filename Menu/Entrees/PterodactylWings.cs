/*
 * PterodactylWings.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification of making Pterodactyl Wings.
    /// </summary>
   public class PterodactylWings : Entree
    {
        /// <summary>
        /// The price of Pterodactyl Wings.
        /// </summary>
        public override double Price
        {
            get;
            protected set;
        }

        /// <summary>
        /// The Calories in Pterodactyl Wings.
        /// </summary>
        public override uint Calories
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gives a list of ingredients for the Pterodactyl Wings.
        /// </summary>
        public override List<string> Ingredients
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
