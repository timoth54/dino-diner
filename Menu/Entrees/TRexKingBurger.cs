﻿/*
 * TRexKingBurger.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification of making a TRexKingBurger
    /// </summary>
    public class TRexKingBurger : Entree
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
        public override double Price
        {
            get;
            protected set;
        }

        /// <summary>
        /// The Calories in a T-Rex King Burger.
        /// </summary>
        public override uint Calories
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gives a list of ingredients on the T-Rex King Burger.
        /// </summary>
        public override List<string> Ingredients
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
        /// Gets a list of special preparations
        /// for the entree.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Bun) special.Add("Hold Bun");
                if (!Ketchup) special.Add("Hold Ketchup");
                if (!Mustard) special.Add("Hold Mustard");
                if (!Pickle) special.Add("Hold Pickle");
                if (!Mayo) special.Add("Hold Mayo");
                if (!Lettuce) special.Add("Hold Lettuce");
                if (!Onion) special.Add("Hold Onion");
                if (!Tomato) special.Add("Hold Tomato");
                return special.ToArray();
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
        /// Remove pickle from order.
        /// </summary>
        public void HoldPickle()
        {
            Pickle = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Remove mayo from order.
        /// </summary>
        public void HoldMayo()
        {
            Mayo = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Remove lettuce from order.
        /// </summary>
        public void HoldLettuce()
        {
            Lettuce = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Remove onion from order.
        /// </summary>
        public void HoldOnion()
        {
            Onion = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Remove tomato from order.
        /// </summary>
        public void HoldTomato()
        {
            Tomato = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// String representation of TRexKingBurger object.
        /// </summary>
        /// <returns>Name of the entree.</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
