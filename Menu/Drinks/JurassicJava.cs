/*
 * JurassicJava.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification for making a Jurassic Java.
    /// </summary>
    public class JurassicJava : Drink
    {
        private bool spaceForCream = false;
        private bool decaf = false;

        /// <summary>
        /// Gets or sets if the drink should have room for cream.
        /// </summary>
        public bool SpaceForCream
        {
            get
            {
                return spaceForCream;
            }
            set
            {
                spaceForCream = value;
            }
        }

        /// <summary>
        /// Gets or sets if the drink should be decaf.
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
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
                    this.Price = .59;
                    this.Calories = 2;
                    this.size = value;
                }
                else if (value == Size.Medium)
                {
                    this.Price = .99;
                    this.Calories = 4;
                    this.size = value;
                }
                else
                {
                    this.Price = 1.49;
                    this.Calories = 8;
                    this.size = value;
                }
            }

        }

        /// <summary>
        /// Gets ingredients in the drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
            }
        }

        /// <summary>
        /// Makes a new Jurrasic Java.
        /// </summary>
        public JurassicJava()
        {
            this.ice = false;
            this.Price = .59;
            this.Calories = 2;
        }

        /// <summary>
        /// Leave room for cream on the drink.
        /// </summary>
        public void LeaveSpaceForCream()
        {
            spaceForCream = true;
        }

        /// <summary>
        /// Add ice to the drink.
        /// </summary>
        public void AddIce()
        {
            this.ice = true;
        }
    }
}
