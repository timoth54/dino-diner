/*
 * DinoNuggets.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

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
            set;
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
        /// Gets a list of special preparations
        /// for the entree.
        /// </summary>
        public override string[] Special
        {
            get
            {
                if (Nuggets > 6)
                {
                    return new List<string>() { String.Format("{0} Extra Nuggets", (Nuggets - 6)) }.ToArray(); 
                }
                else
                {
                    return new List<string>() { }.ToArray();
                }
            }
        }

        /// <summary>
        /// The PropertyChanged event handler; notifies
        /// of changes to the Price, Description, and
        /// Special properties
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        //Helper function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Price");
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
