﻿/*
 * Brontowurst.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Specification of making a Brontowurst.
    /// </summary>
    public class Brontowurst
    {
        /// <summary>
        /// Place the Brontowurst on a whole-wheat bun.
        /// </summary>
        private bool Bun = true;

        /// <summary>
        /// Add peppers to the Brontowurst.
        /// </summary>
        private bool Peppers = true;

        /// <summary>
        /// Add onion to the Brontowurst.
        /// </summary>
        private bool Onion = true;

        /// <summary>
        /// The price of a Brontowurst.
        /// </summary>
        public double Price { get; private set; }

        /// <summary>
        /// The Calories in a Brontowurst.
        /// </summary>
        public uint Calories { get; private set; }

        /// <summary>
        /// Gives a list of ingerdients on the Brontowurst.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Makes a new Brontowurst.
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
        }

        /// <summary>
        /// Remove bun from order.
        /// </summary>
        public void HoldBun()
        {
            Bun = false;
        }

        /// <summary>
        /// Remove peppers from order.
        /// </summary>
        public void HoldPeppers()
        {
            Peppers = false;
        }

        /// <summary>
        /// Remove onion from order.
        /// </summary>
        public void HoldOnion()
        {
            Onion = false;
        }
    }
}
