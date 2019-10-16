/*
 * CretaceousCombo.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem
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

        /// <summary>
        /// String representation of CretaceousCombo object.
        /// </summary>
        /// <returns>Name of the combo.</returns>
        public override string ToString()
        {
            return String.Format($"{Entree} Combo");
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

        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                specials.AddRange(Entree.Special);
                specials.Add(Side.ToString());
                specials.AddRange(Side.Special);
                specials.Add(Drink.ToString());
                specials.AddRange(Drink.Special);
                return specials.ToArray();
            }
        }
    }
}
