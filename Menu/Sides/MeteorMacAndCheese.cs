/*
 * MeteorMacAndCheese.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification for making Meteor Mac and Cheese
    /// </summary>
    public class MeteorMacAndCheese : Side
    {

        private Size size = Size.Small;

        /// <summary>
        /// The price of MeteorMacAndCheese.
        /// </summary>
        public new double Price
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
        /// The Calories in MeteorMacAndCheese. 
        /// </summary>
        public new uint Calories
        {
            get
            {
                switch (this.size)
                {
                    case Size.Small:
                        return 420;
                    case Size.Medium:
                        return 490;
                    default:
                        return 520;
                }
            }
        }

        /// <summary>
        /// Gives a list of ingredients in MeteorMacAndCheese.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
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
        /// Makes new MeteorMacAndCheese.
        /// </summary>
        public MeteorMacAndCheese()
        {

        }

        /// <summary>
        /// String representation of MeteorMacAndCheese object.
        /// </summary>
        /// <returns>Name of the side.</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Meteor Mac and Cheese");
        }
    }
}
