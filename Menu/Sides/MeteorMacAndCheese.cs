/*
 * MeteorMacAndCheese.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification for making Meteor Mac and Cheese
    /// </summary>
    public class MeteorMacAndCheese : Side
    {

        /// <summary>
        /// The price of MeteorMacAndCheese.
        /// </summary>
        public new double Price
        {
            get
            {
                switch (this.Size)
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
                switch (this.Size)
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
        public new Size Size { get; set; }

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
        /// Makes new MeteorMacAndCheese.
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Size = Size.Small;
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
