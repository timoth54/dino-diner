/*
 * Triceritots.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification for making Triceritots.
    /// </summary>
    public class Triceritots : Side
    {
        private Size size = Size.Small;

        /// <summary>
        /// The price of Triceritots.
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
        /// The Calories in Triceritots. 
        /// </summary>
        public new uint Calories
        {
            get
            {
                switch (this.size)
                {
                    case Size.Small:
                        return 352;
                    case Size.Medium:
                        return 410;
                    default:
                        return 590;
                }
            }
        }

        /// <summary>
        /// Gives a list of ingredients in Triceritots.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
        }

        /// <summary>
        /// Size of the Side.
        /// </summary>
        public new Size Size
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
        /// Makes new Triceritots.
        /// </summary>
        public Triceritots()
        {
            
        }

        /// <summary>
        /// String representation of Triceritots object.
        /// </summary>
        /// <returns>Name of the side.</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Triceritots");
        }
    }
}
