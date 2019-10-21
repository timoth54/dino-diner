using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification for making Water
    /// </summary>
   public class Water : Drink
    {

        private bool lemon = false;
        private bool ice = true;

        /// <summary>
        /// Gets if the drink has ice or not.
        /// </summary>
        public bool Ice { get => ice; }


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
                NotifyOfPropertyChange("Description");
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
                if (lemon) special.Add("Add Lemon");
                if (!ice) special.Add("Hold Ice");
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
        /// String representation of Water object.
        /// </summary>
        /// <returns>Name of the drink.</returns>
        public override string ToString()
        {
            return String.Format("{0} Water", size.ToString());
        }
    }
}
