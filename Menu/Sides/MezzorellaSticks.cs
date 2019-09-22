/*
 * MezzorellaSticks.cs
 * Author: Timothy Tucker
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Specification for making Mezzorella Sticks
    /// </summary>
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// The price of Mezzorella Sticks.
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
        /// The Calories in Mezzorella Sticks. 
        /// </summary>
        public new uint Calories
        {
            get
            {
                switch (this.Size)
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
        public new List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
            }
        }

        /// <summary>
        /// Size of the Side.
        /// </summary>
        public new Size Size { get; set; }

        /// <summary>
        /// Makes new Mezzorella Sticks.
        /// </summary>
        public MezzorellaSticks()
        {
            this.Size = Size.Small;
        }
    }
}
