/*
 * Sodasaurus.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification for making a Sodasaurus.
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Flavor of Sodasaurus.
        /// </summary>
        public SodasaurusFlavor Flavor;

        /// <summary>
        /// Gets and sets size of drink.
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value == Size.Small)
                {
                    this.Price = 1.50;
                    this.Calories = 112;
                    this.size = value;
                }
                else if (value == Size.Medium)
                {
                    this.Price = 2.00;
                    this.Calories = 156;
                    this.size = value;
                }
                else
                {
                    this.Price = 2.50;
                    this.Calories = 208;
                    this.size = value;
                }
            }

        }

        /// <summary>
        /// Gets ingredients in the drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }

        /*public string Description
        {
            get { return this.ToString(); }
        }*/

        /// <summary>
        /// Gets a list of special preparations
        /// for the drink.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Makes a new Sodasaurus drink.
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;
            this.Flavor = SodasaurusFlavor.Cherry;
        }

        /// <summary>
        /// String representation of Sodasaurus object.
        /// </summary>
        /// <returns>Name of the drink.</returns>
        public override string ToString()
        {
            return String.Format("{0} {1} Sodasaurus", size.ToString(), Flavor.ToString());
        }
    }
}
