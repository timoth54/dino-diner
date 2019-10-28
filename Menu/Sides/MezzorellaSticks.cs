/*
 * MezzorellaSticks.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification for making Mezzorella Sticks
    /// </summary>
    public class MezzorellaSticks : Side
    {
        private Size size;
        /// <summary>
        /// The price of Mezzorella Sticks.
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
        /// The Calories in Mezzorella Sticks. 
        /// </summary>
        public new uint Calories
        {
            get
            {
                switch (this.size)
                {
                    case Size.Small:
                        return 540;
                    case Size.Medium:
                        return 610;
                    default:
                        return 720;
                }
            }
        }

        /// <summary>
        /// Gives a list of ingredients in Mezzorella Sticks.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
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
        /// Makes new Mezzorella Sticks.
        /// </summary>
        public MezzorellaSticks()
        {
            size = Size.Small;
        }

        /// <summary>
        /// String representation of MezzorellaSticks object.
        /// </summary>
        /// <returns>Name of the side.</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Mezzorella Sticks");
        }
    }
}
