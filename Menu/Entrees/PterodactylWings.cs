/*
 * PterodactylWings.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification of making Pterodactyl Wings.
    /// </summary>
   public class PterodactylWings : Entree
    {
        /// <summary>
        /// The price of Pterodactyl Wings.
        /// </summary>
        public override double Price
        {
            get;
            set;
        }

        /// <summary>
        /// The Calories in Pterodactyl Wings.
        /// </summary>
        public override uint Calories
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gives a list of ingredients for the Pterodactyl Wings.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Chicken", "Wing Sauce" };
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
                return new List<string>() { }.ToArray();
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
        /// Makes new Pterodactyl Wings.
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
        }

        /// <summary>
        /// String representation of PterodactylWings object.
        /// </summary>
        /// <returns>Name of the entree.</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
