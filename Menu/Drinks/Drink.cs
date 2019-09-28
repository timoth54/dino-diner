/*
 * Drink.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Abstraction of all drinks.
    /// </summary>
    public abstract class Drink
    {
        protected Size size = Size.Small;
        protected bool ice = true;

        /// <summary>
        /// Gets and sets the size of a drink.
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        /// <summary>
        /// Gets if the drink has ice or not.
        /// </summary>
        public bool Ice { get => ice; }

        /// <summary>
        /// Gets the price of a drink.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets the calories in a drink.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets ingredients in a drink.
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Removes ice from order.
        /// </summary>
        public void HoldIce()
        {
            ice = false;
        }
    }
}
