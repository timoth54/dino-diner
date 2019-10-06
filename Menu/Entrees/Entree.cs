/*
 * Entree.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstraction of all entrees.
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public abstract double Price { get; protected set; }

        /// <summary>
        /// Gets and sets the calories.
        /// </summary>
        public abstract uint Calories { get; protected set; }

        /// <summary>
        /// Gets the ingredients list.
        /// </summary>
        public abstract List<string> Ingredients { get; }
    }
}
