/*
 * Fryceritops.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification for making Fryceritops.
    /// </summary>
    public class Fryceritops : Side
    {

        /// <summary>
        /// The price of Fryceritops.
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
        /// The Calories in Fryceritops. 
        /// </summary>
        public new uint Calories
        {
            get
            {
                switch (this.Size)
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
        /// Size of the Side.
        /// </summary>
        public new Size Size { get; set; }

        /// <summary>
        /// Makes new Fryceritops.
        /// </summary>
        public Fryceritops()
        {
            this.Size = Size.Small;
        }
    }
}
