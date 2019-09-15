/*
 * VelociWrap.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    /// <summary>
    /// Specification of making a Veloci-Wrap
    /// </summary>
    class VelociWrap
    {
        /// <summary>
        /// Add dressing to the order.
        /// </summary>
        private bool Dressing = true;

        /// <summary>
        /// Add romaine lettuce to the order.
        /// </summary>
        private bool Lettuce = true;

        /// <summary>
        /// Add cheese to the order.
        /// </summary>
        private bool Cheese = true;

        /// <summary>
        /// The price of a Veloci-Wrap.
        /// </summary>
        public double Price
        {
            get;
            private set;
        }

        /// <summary>
        /// The Calories in a Veloci-Wrap.
        /// </summary>
        public uint Calories
        {
            get;
            private set;
        }

        /// <summary>
        /// Gives a list of ingredients on the Veloci-Wrap.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (Dressing) ingredients.Add("Dressing");
                if (Lettuce) ingredients.Add("Lettuce");
                if (Cheese) ingredients.Add("Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Makes a new Veloci-Wrap.
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
        }

        /// <summary>
        /// Remove dressing from order.
        /// </summary>
        public void HoldDressing()
        {
            Dressing = false;
        }

        /// <summary>
        /// Remove lettuce from order.
        /// </summary>
        public void HoldLettuce()
        {
            Lettuce = false;
        }

        /// <summary>
        /// Remove cheeses from order.
        /// </summary>
        public void HoldCheese()
        {
            Cheese = false;
        }
    }
}
