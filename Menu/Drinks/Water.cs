using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification for making Water
    /// </summary>
   public class Water : Drink
    {

        private bool lemon = false;
        
        /// <summary>
        /// Gets if there is lemon in the drink. 
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            private set
            {
                lemon = true;
            }
        }

        /// <summary>
        /// Gets or sets the size of the drink.
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        /// <summary>
        /// Makes a new Water.
        /// </summary>
        public Water()
        {
            this.Price = .10;
            this.Calories = 0;
        }

        /// <summary>
        /// Gets the ingredients in the drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Adds lemon to the drink.
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
        }

        /// <summary>
        /// String representation of Water object.
        /// </summary>
        /// <returns>Name of the drink.</returns>
        public override string ToString()
        {
            return String.Format("{0} Water", size.ToString());
        }
    }
}
