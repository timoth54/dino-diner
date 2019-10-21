/*
 * Brontowurst.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification of making a Brontowurst.
    /// </summary>
    public class Brontowurst : Entree, INotifyPropertyChanged
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
        public override double Price { get; set; }

        /// <summary>
        /// The Calories in a Brontowurst.
        /// </summary>
        public override uint Calories { get; protected set; }

        /// <summary>
        /// Gives a list of ingerdients on the Brontowurst.
        /// </summary>
        public override List<string> Ingredients
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
        /// Gets a list of special preparations
        /// for the entree.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Bun) special.Add("Hold Bun");
                if (!Peppers) special.Add("Hold Peppers");
                if (!Onion) special.Add("Hold Onion");
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
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Remove peppers from order.
        /// </summary>
        public void HoldPeppers()
        {
            Peppers = false;
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
        /// String representation of Brontowurst object.
        /// </summary>
        /// <returns>Name of the entree.</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
