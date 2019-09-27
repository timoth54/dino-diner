/*
 * Tyrannotea.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Specification for making a Tyrannotea.
    /// </summary>
    public class Tyrannotea : Drink
    {
        private bool sweet = false;
        private bool lemon = false;

        /// <summary>
        /// Gets or sets if the tea has sweetener.
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                if (sweet) this.Calories = this.Calories * 2;
            }
        }

        /// <summary>
        /// Gets or sets if the drink has lemon.
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
            }
        }

        /// <summary>
        /// Gets and sets size of drink.
        /// </summary>
        public new Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value == Size.Small)
                {
                    this.Price = .99;
                    this.Calories = 8;
                    this.size = value;
                }
                else if (value == Size.Medium)
                {
                    this.Price = 1.49;
                    this.Calories = 16;
                    this.size = value;
                }
                else
                {
                    this.Price = 1.99;
                    this.Calories = 32;
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
                List<string> ingredients = new List<string>() { "Water", "Tea"};
                if (sweet) ingredients.Add("Cane Sugar");
                if (lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Makes a new Tyrannotea drink.
        /// </summary>
        public Tyrannotea()
        {
            this.Price = .99;
            this.Calories = 8;
        }

        /// <summary>
        /// Adds lemon to the drink.
        /// </summary>
        public void AddLemon()
        {
            this.lemon = true;
        }
    }
}
