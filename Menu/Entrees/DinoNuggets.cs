/*
 * DinoNuggets.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Specification of making Dino Nuggets.
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// Number of Dino Nuggets.
        /// </summary>
        private uint Nuggets;

        /// <summary>
        /// The price of Dino Nuggets.
        /// </summary>
        public double Price
        {
            get;
            private set;
        }

        /// <summary>
        /// The Calories in Dino Nuggets.
        /// </summary>
        public uint Calories
        {
            get;
            private set;
        }

        /// <summary>
        /// Gives a list of ingredients in the Dino Nuggets.
        /// </summary>
        public List<string> Ingredients
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
    }
}
