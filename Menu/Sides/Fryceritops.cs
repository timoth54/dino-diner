/*
 * Fryceritops.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification for making Fryceritops.
    /// </summary>
    public class Fryceritops : Side
    {

        private Size size; 
        /// <summary>
        /// The price of Fryceritops.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (this.size)
                {
                    case Size.Small:
                        return .99;
                    case Size.Medium:
                        return 1.45;
                    default:
                        return 1.95;
                }
            }
        }

        /// <summary>
        /// The Calories in Fryceritops. 
        /// </summary>
        public new uint Calories
        {
            get
            {
                switch (this.size)
                {
                    case Size.Small:
                        return 222;
                    case Size.Medium:
                        return 365;
                    default:
                        return 480;
                }
            }
        }

        /// <summary>
        /// Gives a list of ingredients in Fryceritops.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
        }

        /// <summary>
        /// Gets a list of special preparations
        /// for the side.
        /// </summary>
        public override string[] Special
        {
            get
            {
                return new List<string>() { }.ToArray();
            }
        }

        /// <summary>
        /// Size of the Side.
        /// </summary>
        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
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
        /// Makes new Fryceritops.
        /// </summary>
        public Fryceritops()
        {
            size = Size.Small;
        }

        /// <summary>
        /// String representation of Fryceritops object.
        /// </summary>
        /// <returns>Name of the side.</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Fryceritops");
        }
    }
}
