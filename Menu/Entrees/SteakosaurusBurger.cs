/*
 * SteakosaurusBurger.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification of making a Steakosaurus Burger.
    /// </summary>
    public class SteakosaurusBurger : Entree
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
        public override double Price
        {
            get;
            protected set;
        }

        /// <summary>
        /// The Calories in a Steakosaurus Burger.
        /// </summary>
        public override uint Calories
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gives a list of ingerdients on the Steakosaurus Burger.
        /// </summary>
        public override List<string> Ingredients
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
        /// Gets a list of special preparations
        /// for the entree.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Bun) special.Add("Hold Bun");
                if (!Pickle) special.Add("Hold Pickle");
                if (!Ketchup) special.Add("Hold Ketchup");
                if (!Mustard) special.Add("Hold Mustard");
                return special.ToArray();
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
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Remove pickle from order.
        /// </summary>
        public void HoldPickle()
        {
            Pickle = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Remove ketchup from order.
        /// </summary>
        public void HoldKetchup()
        {
            Ketchup = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Remove mustard from order.
        /// </summary>
        public void HoldMustard()
        {
            Mustard = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// String representation of SteakosaurusBurger object.
        /// </summary>
        /// <returns>Name of the entree.</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
