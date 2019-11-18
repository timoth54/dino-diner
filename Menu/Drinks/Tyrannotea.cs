/*
 * Tyrannotea.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification for making a Tyrannotea.
    /// </summary>
    public class Tyrannotea : Drink
    {
        private bool sweet = false;
        private bool lemon = false;
        private bool ice = true;


        /// <summary>
        /// Gets if the drink has ice or not.
        /// </summary>
        public bool Ice { get => ice; }

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
                if (sweet == false && value == true)
                {
                    this.Calories = this.Calories * 2;
                    sweet = value;
                }
                else
                {
                    if (sweet == true && value == false)
                    {
                        this.Calories = this.Calories / 2;
                        sweet = value;
                    }
                }

                NotifyOfPropertyChange("Description");
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
            private set
            {
                lemon = value;
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
                List<string> ingredients = new List<string>() { "Water", "Tea"};
                if (sweet) ingredients.Add("Cane Sugar");
                if (lemon) ingredients.Add("Lemon");
                return ingredients;
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
                if (!ice) special.Add("Hold Ice");
                if (lemon) special.Add("Add Lemon");
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
            NotifyOfPropertyChange("Special");
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
        /// String representation of Tyrannotea object.
        /// </summary>
        /// <returns>Name of the drink.</returns>
        public override string ToString()
        {
            if (!sweet)
            {
                return String.Format("{0} Tyrannotea", size.ToString());
            }
            else
            {
                return String.Format("{0} Sweet Tyrannotea", size.ToString());
            }
            
        }
    }
}
