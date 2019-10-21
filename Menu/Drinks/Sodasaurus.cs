/*
 * Sodasaurus.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification for making a Sodasaurus.
    /// </summary>
    public class Sodasaurus : Drink
    {
        private bool ice = true;
        private SodasaurusFlavor flavor; 

        /// <summary>
        /// Gets if the drink has ice or not.
        /// </summary>
        public bool Ice { get => ice; }

        /// <summary>
        /// Flavor of Sodasaurus.
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get => flavor;
            set
            {
                flavor = value;
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Gets and sets size of drink.
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value == Size.Small)
                {
                    this.Price = 1.50;
                    this.Calories = 112;
                    this.size = value;
                }
                else if (value == Size.Medium)
                {
                    this.Price = 2.00;
                    this.Calories = 156;
                    this.size = value;
                }
                else
                {
                    this.Price = 2.50;
                    this.Calories = 208;
                    this.size = value;
                }
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
            }

        }

        /// <summary>
        /// Gets ingredients in the drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }

        /// <summary>
        /// Gets a list of special preparations
        /// for the drink.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
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
        /// Makes a new Sodasaurus drink.
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;
            flavor = SodasaurusFlavor.Cherry;
        }

        /// <summary>
        /// Removes ice from order.
        /// </summary>
        public void HoldIce()
        {
            ice = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// String representation of Sodasaurus object.
        /// </summary>
        /// <returns>Name of the drink.</returns>
        public override string ToString()
        {
            return String.Format("{0} {1} Sodasaurus", size.ToString(), Flavor.ToString());
        }
    }
}
