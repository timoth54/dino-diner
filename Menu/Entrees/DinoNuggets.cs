/*
 * DinoNuggets.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification of making Dino Nuggets.
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// Number of Dino Nuggets.
        /// </summary>
        private uint Nuggets;

        /// <summary>
        /// The price of Dino Nuggets.
        /// </summary>
        public override double Price
        {
            get;
            protected set;
        }

        /// <summary>
        /// The Calories in Dino Nuggets.
        /// </summary>
        public override uint Calories
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gives a list of ingredients in the Dino Nuggets.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (uint nugget = 0; nugget < Nuggets; nugget++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Makes new Dino Nuggets.
        /// </summary>
        public DinoNuggets()
        {
            Nuggets = 6;
            Calories = Nuggets * 59;
            Price = 4.25;
        }

        /// <summary>
        /// Add a Dino Nugget to the meal.
        /// </summary>
        public void AddNugget()
        {
            Nuggets++;
            Calories += 59;
            Price += .25;
        }

        /// <summary>
        /// String representation of DinoNuggets object.
        /// </summary>
        /// <returns>Name of the entree.</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
