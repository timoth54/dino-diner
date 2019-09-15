/*
 * TRexKingBurger.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Specification of making a TRexKingBurger
    /// </summary>
    public class TRexKingBurger
    {
        /// <summary>
        /// Burger is on a bun.
        /// </summary>
        private bool Bun = true;

        /// <summary>
        /// Add lettuce to burger.
        /// </summary>
        private bool Lettuce = true;

        /// <summary>
        /// Add tomato to the burger.
        /// </summary>
        private bool Tomato = true;

        /// <summary>
        /// Add onion to the burger.
        /// </summary>
        private bool Onion = true;

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
        /// Add mayo to the burger.
        /// </summary>
        private bool Mayo = true;

        /// <summary>
        /// The price of a T-Rex King Burger.
        /// </summary>
        public double Price
        {
            get;
            private set;
        }

        /// <summary>
        /// The Calories in a T-Rex King Burger.
        /// </summary>
        public uint Calories
        {
            get;
            private set;
        }

        /// <summary>
        /// Gives a list of ingredients on the T-Rex King Burger.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                if (Pickle) ingredients.Add("Pickle");
                if (Mayo) ingredients.Add("Mayo");
                if (Lettuce) ingredients.Add("Lettuce");
                if (Onion) ingredients.Add("Onion");
                if (Tomato) ingredients.Add("Tomato");
                return ingredients;
            }
        }

        /// <summary>
        /// Makes a new T-Rex King Burger.
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
        }

        /// <summary>
        /// Remove bun from order.
        /// </summary>
        public void HoldBun()
        {
            Bun = false;
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

        /// <summary>
        /// Remove pickle from order.
        /// </summary>
        public void HoldPickle()
        {
            Pickle = false;
        }

        /// <summary>
        /// Remove mayo from order.
        /// </summary>
        public void HoldMayo()
        {
            Mayo = false;
        }

        /// <summary>
        /// Remove lettuce from order.
        /// </summary>
        public void HoldLettuce()
        {
            Lettuce = false;
        }

        /// <summary>
        /// Remove onion from order.
        /// </summary>
        public void HoldOnion()
        {
            Onion = false;
        }

        /// <summary>
        /// Remove tomato from order.
        /// </summary>
        public void HoldTomato()
        {
            Tomato = false;
        }
    }
}
