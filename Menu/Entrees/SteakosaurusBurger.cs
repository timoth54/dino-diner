/*
 * SteakosaurusBurger.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    /// <summary>
    /// Specification of making a Steakosaurus Burger.
    /// </summary>
    class SteakosaurusBurger
    {
        /// <summary>
        /// Burger is on a bun.
        /// </summary>
        private bool Bun = true;

        /// <summary>
        /// Add pickle to the burger.
        /// </summary>
        private bool Pickle = true;

        /// <summary>
        /// Add ketchup to the burger.
        /// </summary>
        private bool Ketchup = true;

        /// <summary>
        /// Add mustard to the burger.
        /// </summary>
        private bool Mustard = true;

        /// <summary>
        /// The price of a Steakosaurus Burger.
        /// </summary>
        public double Price
        {
            get;
            private set;
        }

        /// <summary>
        /// The Calories in a Steakosaurus Burger.
        /// </summary>
        public uint Calories
        {
            get;
            private set;
        }

        /// <summary>
        /// Gives a list of ingerdients on the Steakosaurus Burger.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                if (Pickle) ingredients.Add("Pickle");
                return ingredients;
            }
        }

        /// <summary>
        /// Makes a new Steakosaurus Burger.
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
        }

        /// <summary>
        /// Remove bun from order.
        /// </summary>
        public void HoldBun()
        {
            Bun = false;
        }

        /// <summary>
        /// Remove pickle from order.
        /// </summary>
        public void HoldPickle()
        {
            Pickle = false;
        }

        /// <summary>
        /// Remove ketchup from order.
        /// </summary>
        public void HoldKetchup()
        {
            Ketchup = false;
        }

        /// <summary>
        /// Remove mustard from order.
        /// </summary>
        public void HoldMustard()
        {
            Mustard = false;
        }

    }
}
