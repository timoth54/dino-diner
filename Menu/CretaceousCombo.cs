/*
 * CretaceousCombo.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        /// <summary>
        /// Gets or sets the entree.
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Gets or sets the drink.
        /// </summary>
        public Drink Drink { get; set; }

        /// <summary>
        /// Gets or sets the side.
        /// </summary>
        public Side Side { get; set; }

        private Size size = Size.Small;

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
            }
        }

        /// <summary>
        /// Gets the price of the combo.
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Drink.Price + Side.Price - .25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Drink.Calories + Entree.Calories + Side.Calories;
            }
        }

        /// <summary>
        /// Gets ingredients of combo.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        public override string ToString()
        {
            return "";
        }

        private CretaceousCombo() { }

        /// <summary>
        /// Makes a new Cretaceous Combo.
        /// </summary>
        /// <param name="entree">The entree in the combo.</param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }


    }
}
